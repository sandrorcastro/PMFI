using Fazenda.Controllers;
using Fazenda.Entities.DBProsiga;
using Humanizer;
using Microsoft.CodeAnalysis.Elfie.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fazenda.Models
{
    public class IPTU
    {
        private DbprosigaContext _context;
        private long edificacaoID;
        private TribEdificaco? imovel;
        private string inscricaoImobiliaria;
        private decimal areaTerreno;
        private decimal fatorCorrecaoArea;
        private decimal testadaTerreno;
        private decimal profundidadePadrao;
        private int logradTestadaPrincipal;
        private int quadraId;
        private long fatorKID;
        private decimal fatorKValor;
        private decimal fatorLocQuadra;
        private decimal fatorPedologia;
        private decimal fatorTopografia;
        private double valorVenalTerreno;
        private decimal valorM2AreaCoberta;
        private int paramIDTipoConstrucao;
        private int paramIDEstruturaAreaCoberta;
        private int tParamIDEstrutura;
        private int tParamIDTipoConstrucao;
        private decimal fatorPosicao;
        private decimal fatorSituacao;
        private int iDPlanta;
        private int pontosEdificacao;
        private decimal valorM2;
        private int anosConstrucao;
        private decimal aliquotaDepreciacao;
        private int categID;
        private int paramID;
        private int tParamID;
        private short anoIPTU;
        private decimal areaCoberta;
        private decimal areaConstruida;
        private double valorVenalEdificacao;
        private double valorVenalCalculo;

        public IPTU()
        {
            
        }
        public IPTU(TribEdificaco imovel)
        {
            _context = new DbprosigaContext();
            this.imovel = imovel;
            EdificacaoID = this.imovel.EdificacaoId;
            InscricaoImobiliaria = this.imovel.InscricaoImobiliaria.ToString();
            if (imovel.EdifCaracteristica == "Territorial")
            {

                    AreaTerreno = (decimal) _context.TribTerrenos.Find(this.imovel.TerrenoId).TerrAreaTerreno;
                    FatorCorrecaoArea = (decimal)_context.TribFatorCorAreas.Where(f=> f.FatCorAreaDe <=  this.areaTerreno && f.FatCorAreaAte  >= this.areaTerreno).FirstOrDefault().FatCorAreaFator;
                    TestadaTerreno = (decimal)_context.TribTestadasTerrenos.Where(t => t.TerrenoId == this.imovel.TerrenoId && t.TestadasPrincipal.ToUpper()=="SIM").FirstOrDefault().TestadasMetragem;
                    ProfundidadePadrao = 40;
                    LogradTestadaPrincipal= (int) _context.TribTestadasTerrenos.Where(t => t.TerrenoId == this.imovel.TerrenoId && t.TestadasPrincipal.ToUpper() == "SIM").FirstOrDefault().LogradId;
                    QuadraId = (int)_context.TribTerrenos.Find(this.imovel.TerrenoId).QuadraId;
            
                    //////
                    //Não tem algumas quadras: Verificar EdificacaoID 7189,2,158020 e 73334  com a quadra 2
                    //FatorKID =(long) _context.TribQuadraLograds.Where(q => q.QuadraId == this.quadraId && q.LogradId == this.logradTestadaPrincipal).FirstOrDefault().FatorKid;
                    //FatorKID = (_context.TribQuadraLograds.Where(q => q.QuadraId == 2 || q.QuadraId == 5774 || q.QuadraId == 5189).FirstOrDefault().FatorKid) == null
                    //FatorKID = _context.TribQuadraLograds.Where(q => q.QuadraId == 2 || q.QuadraId == 5774 || q.QuadraId == 5189 ).IsNullOrEmpty()
                    FatorKID = _context.TribQuadraLograds.Where(q => q.QuadraId == this.quadraId && q.LogradId == this.logradTestadaPrincipal).IsNullOrEmpty() 
                                            ? 1 
                                            : (long)(_context.TribQuadraLograds.Where(q => q.QuadraId == this.quadraId && q.LogradId == this.logradTestadaPrincipal).FirstOrDefault().FatorKid);
                    //? 1 
                    //: (long)(_context.TribQuadraLograds.Where(q => q.QuadraId == this.quadraId && q.LogradId == this.logradTestadaPrincipal).FirstOrDefault().FatorKid));
                    //FatorKvalor recebemdo 1000 por problemas com a quadra 2
                    FatorKValor =   (this.fatorKID!=null || this.fatorKID !=1) ? (long)_context.TribFatorKs.Find(this.fatorKID).FatorKvalor : 1;
                    //////
                    //Localização na quadra
                    var sFatorLocQuadra = _context.SisParametros.Where(pc => pc.SiPaIdSistema == "Tribuno" && pc.SiPaIdParametro == "LocQID").FirstOrDefault().SiPaValorParametro; 
                    var FatorLocQuadraquery = from epc in _context.TribEdifParamCalculos
                                                join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                                            where(epc.EdificacaoId == this.imovel.EdificacaoId && epc.TparamId == int.Parse(sFatorLocQuadra) )
                                select new { epc,pc };
                    FatorLocQuadra =   FatorLocQuadraquery.FirstOrDefault().pc.Fator != null ? (decimal) FatorLocQuadraquery.FirstOrDefault().pc.Fator: 1 ;




                    //Pedologia
                    var sFatorPedologia = _context.SisParametros.Where(pc => pc.SiPaIdSistema == "Tribuno" && pc.SiPaIdParametro == "PedoID").FirstOrDefault().SiPaValorParametro;
                    var FatorPedologiaQuery = from epc in _context.TribEdifParamCalculos
                                             join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                                             where (epc.EdificacaoId == this.imovel.EdificacaoId && epc.TparamId == int.Parse(sFatorPedologia))
                                             select new { epc, pc };
                    FatorPedologia = FatorPedologiaQuery.FirstOrDefault().pc.Fator != null ? (decimal)FatorPedologiaQuery.FirstOrDefault().pc.Fator : 1;


                    //Topografia
                    var sFatorTopografia = _context.SisParametros.Where(pc => pc.SiPaIdSistema == "Tribuno" && pc.SiPaIdParametro == "TopoID").FirstOrDefault().SiPaValorParametro;
                    var FatorTopografiaQuery = from epc in _context.TribEdifParamCalculos
                                              join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                                              where (epc.EdificacaoId == this.imovel.EdificacaoId && epc.TparamId == int.Parse(sFatorTopografia))
                                              select new { epc, pc };
                    FatorTopografia = FatorTopografiaQuery.FirstOrDefault().pc.Fator != null ? (decimal)FatorTopografiaQuery.FirstOrDefault().pc.Fator : 1;

                    //Profundidade Padrão
                    ProfundidadePadrao = (decimal)_context.Parametros.Where(p => p.ParamId.ToUpper() == "TRIBUNO").FirstOrDefault().ParamTribProfundidadePadrao;


                    //Incia o Calulo co Valor Venal

                    //ValorVenalTerreno = ((((((Math.Sqrt((double)((this.areaTerreno * this.fatorCorrecaoArea * this.testadaTerreno) / this.profundidadePadrao))) *(double)this.fatorKValor)*(double)this.fatorLocQuadra)*(double)this.fatorPedologia)*(double)this.fatorTopografia)*(double)1.0351) ;
                    ValorVenalTerreno = Math.Sqrt((double)((this.areaTerreno * this.fatorCorrecaoArea * this.testadaTerreno) / this.profundidadePadrao));
                    ValorVenalTerreno = ValorVenalTerreno * (double)this.fatorKValor;
                    ValorVenalTerreno = ValorVenalTerreno * (double)this.fatorLocQuadra;
                    ValorVenalTerreno = ValorVenalTerreno * (double)this.fatorPedologia;
                    ValorVenalTerreno = ValorVenalTerreno * (double)this.fatorTopografia;
                    ValorVenalTerreno = ValorVenalTerreno * (double)1.035;
                    /////////////////////////////////////////////////////////////////////////////////////////
                    ////////////////////////////////////////////////////////////////////////////////////////
                    ///Incia Calculo Valor Venal Edificação
                    ///
            }else if (imovel.EdifCaracteristica=="Predial")
            {

                AreaConstruida = (decimal)_context.TribEdificacoes.Find(imovel.EdificacaoId).EdifAreaConstruida;
                AreaCoberta = (decimal)_context.TribEdificacoes.Find(imovel.EdificacaoId).EdifAreaCoberta;
                CategID = (int)_context.TribEdificacoes.Find(imovel.EdificacaoId).CategId;
                IDPlanta = (int)_context.TribEdificacoes.Find(imovel.EdificacaoId).Idplanta;

                AnoIPTU = (short)_context.Parametros.Where(p => p.ParamId.ToUpper() == "TRIBUNO").FirstOrDefault().ParamTribAnoIptu;

                AnosConstrucao = this.anoIPTU - (_context.TribEdificacoes.Where(e => e.EdificacaoId == imovel.EdificacaoId).FirstOrDefault().EdifAnoConstrucao) ?? this.anoIPTU;

                ValorM2 = (decimal)_context.TribTipoPlantasValores.Where(tpv => tpv.Idplanta == this.iDPlanta).FirstOrDefault().ValorM2;
                TParamID = int.Parse(_context.SisParametros.Where(sp => sp.SiPaIdSistema == "Tribuno" && sp.SiPaIdParametro == "EstrutID").FirstOrDefault().SiPaValorParametro);
                TParamID = TParamID.ToString().IsNullOrEmpty() ? -1: TParamID;
                
                ParamID = _context.TribEdifParamCalculos.Where(epc => epc.EdificacaoId == imovel.EdificacaoId && epc.TparamId==this.tParamID).FirstOrDefault().ParamId;

                AliquotaDepreciacao = _context.TribDepreciacaoIdades.Where(di=>di.TparamId == this.tParamID && di.ParamId==this.paramID && (di.DePrecDe <= this.anosConstrucao && di.DePrecAte >= this.anosConstrucao )).FirstOrDefault().DePrecAliquota ;
                AliquotaDepreciacao = AliquotaDepreciacao.ToString().IsNullOrEmpty() ? 0 : AliquotaDepreciacao;
                ///Incicia Calculo Area Coberta
                ValorM2AreaCoberta = 0;
                if(this.areaCoberta - this.areaConstruida > 0)
                {
                    TParamIDEstrutura = int.Parse(_context.SisParametros.Where(sp => sp.SiPaIdSistema == "Tribuno" && sp.SiPaIdParametro == "EstrutID").FirstOrDefault().SiPaValorParametro);
                    TParamIDTipoConstrucao = int.Parse(_context.SisParametros.Where(sp => sp.SiPaIdSistema == "Tribuno" && sp.SiPaIdParametro == "IdParamTipoConstr").FirstOrDefault().SiPaValorParametro);
                    ParamIDEstruturaAreaCoberta = int.Parse(_context.SisParametros.Where(sp => sp.SiPaIdSistema == "Tribuno" && sp.SiPaIdParametro == "IDParamAreaCobertaEconomia").FirstOrDefault().SiPaValorParametro);
                    ParamIDTipoConstrucao = _context.TribEdifParamCalculos.Where(epc => epc.EdificacaoId == imovel.EdificacaoId && epc.TparamId == this.tParamIDTipoConstrucao).FirstOrDefault().ParamId;

                    /*var ValorM2AreaCobertaquery = from ppv in _context.TribParamPlantaValore
                                                  join tpc in _context.TribTipoParamCalculos on ppv.TparamId equals tpc.TparamId
                                                  join pc in _context.TribParamCalculos on ppv.ParamId equals pc.ParamId 
                                                  join tpv in _context.TribTipoPlantasValores on ppv.Idplanta equals tpv.Idplanta
                                                  join ce in _context.TribCategoriaEdificacaos on tpv.CategId equals ce.CategId
                                                  where ppv.TparamId == this.tParamIDTipoConstrucao 
                                                        &&
                                                        ppv.ParamId == this.paramIDTipoConstrucao
                                                        &&
                                                        _context.TribParamPlantaValore */


                    var ValorM2AreaCobertaquery = from tpv in _context.TribParamPlantaValore
                                 join ttpc in _context.TribTipoParamCalculos on tpv.TparamId equals ttpc.TparamId
                                 join tpc in _context.TribParamCalculos on new { tpv.TparamId, tpv.ParamId } equals new { tpc.TparamId, tpc.ParamId }
                                 join ttpv in _context.TribTipoPlantasValores on tpv.Idplanta equals ttpv.Idplanta
                                 join tce in _context.TribCategoriaEdificacaos on ttpv.CategId equals tce.CategId
                                 where tpv.TparamId == TParamIDTipoConstrucao &&
                                       tpv.ParamId == ParamIDTipoConstrucao &&
                                       ttpv.AnoPlanta == AnoIPTU &&
                                       ttpv.CategId == CategID &&
                                       _context.TribParamPlantaValore.Any(
                                           tppv => tppv.TparamId == TParamIDEstrutura &&
                                                   tppv.ParamId == ParamIDEstruturaAreaCoberta &&
                                                   ttpv.AnoPlanta == AnoIPTU &&
                                                   tppv.Idplanta == tpv.Idplanta)
                                 select ttpv.ValorM2;

                    ValorVenalEdificacao = 0;
                    ValorM2AreaCoberta = (decimal)ValorM2AreaCobertaquery.FirstOrDefault();
                    if(ValorM2AreaCoberta > 0){
                        ValorVenalEdificacao = ValorVenalEdificacao * ((double)(this.valorM2AreaCoberta - this.areaConstruida));
                    }
                    ValorVenalEdificacao = ValorVenalEdificacao + ((double)(this.areaConstruida * this.valorM2));
                    ValorVenalEdificacao = ValorVenalEdificacao * (double)this.aliquotaDepreciacao;


                    /*
                     var FatorLocQuadraquery = from epc in _context.TribEdifParamCalculos
                                               join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                                               where (epc.EdificacaoId == this.imovel.EdificacaoId && epc.TparamId == int.Parse(sFatorLocQuadra))
                                               select new { epc, pc };
                FatorLocQuadra = FatorLocQuadraquery.FirstOrDefault().pc.Fator != null ? (decimal)FatorLocQuadraquery.FirstOrDefault().pc.Fator : 1;
                    */
                    //ParamIDEstruturaAreaCoberta = 



                }






            }

            ValorVenalCalculo = ValorVenalTerreno + ValorVenalEdificacao;
        }
        [Key]
        public long IPTUID { get; set; }
        public long ID { get; set; }
       // [Display(Name = "ID")]
      //  public long EdificacaoID { get; set; }
        //[Display(Name = "Insc.Imob.")]
        public TribEdificaco? Imovel { get => imovel; set => imovel = value; }
        [Display(Name = "Insc.Imob.")]
        public string InscricaoImobiliaria { get => inscricaoImobiliaria; set => inscricaoImobiliaria = value; }
        [Display(Name = "ÁreaTerreno")]
        public decimal AreaTerreno { get => areaTerreno; set => areaTerreno = value; }
        [Display(Name = "Fat.Corr.A.")]
        public decimal FatorCorrecaoArea { get => fatorCorrecaoArea; set => fatorCorrecaoArea = value; }
        [Display(Name = "Testada")]
        public decimal TestadaTerreno { get => testadaTerreno; set => testadaTerreno = value; }
        [Display(Name = "Profundidade P.")]
        public decimal ProfundidadePadrao { get => profundidadePadrao; set => profundidadePadrao = value; }
        [Display(Name = "Logr. Testad. Pri.")]
        public int LogradTestadaPrincipal { get => logradTestadaPrincipal; set => logradTestadaPrincipal = value; }
        [Display(Name = "QuadraID")]
        public int QuadraId { get => quadraId; set => quadraId = value; }
        [Display(Name = "FKID")]
        public long FatorKID { get => fatorKID; set => fatorKID = value; }
        [Display(Name = "FKValor")]
        public decimal FatorKValor { get => fatorKValor; set => fatorKValor = value; }
        [Display(Name = "Fat.Loc.Quad.")]
        public decimal FatorLocQuadra { get => fatorLocQuadra; set => fatorLocQuadra = value; }
        [Display(Name = "Fat.Pedo.")]
        public decimal FatorPedologia { get => fatorPedologia; set => fatorPedologia = value; }
        [Display(Name = "Fat.Topo.")]
        public decimal FatorTopografia { get => fatorTopografia; set => fatorTopografia = value; }

        [Display(Name = "Edif.ID")]
        public long EdificacaoID { get => edificacaoID; set => edificacaoID = Imovel.EdificacaoId; }
        [Display(Name = "VVTerreno")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public double ValorVenalTerreno { get => valorVenalTerreno; set => valorVenalTerreno = value; }

        /////////
        /// <summary>

        /// </summary>
        [Display(Name = "ÁreaConst.")]
        public decimal AreaConstruida { get => areaConstruida; set => areaConstruida = value; }
        [Display(Name = "ÁreaCoberta")]
        public decimal AreaCoberta { get => areaCoberta; set => areaCoberta = value; }
        [Display(Name = "AnoIPTU")]
        public short AnoIPTU { get => anoIPTU; set => anoIPTU = value; }
        [Display(Name = "TParamId")]
        public int TParamID { get => tParamID; set => tParamID = value; }
        [Display(Name = "ParamID")]
        public int ParamID { get => paramID; set => paramID = value; }
        [Display(Name = "Categ.ID")]
        public int CategID { get => categID; set => categID = value; }
        [Display(Name = "Aliq.Deprec.")]
        public decimal AliquotaDepreciacao { get => aliquotaDepreciacao; set => aliquotaDepreciacao = value; }
        [Display(Name = "AnoConstr.")]
        public int AnosConstrucao { get => anosConstrucao; set => anosConstrucao = value; }
        [Display(Name = "Val.M2")]
        public decimal ValorM2 { get => valorM2; set => valorM2 = value; }
        [Display(Name = "PontosEdif.")]
        public int PontosEdificacao { get => pontosEdificacao; set => pontosEdificacao = value; }
        [Display(Name = "IDPlanta")]
        public int IDPlanta { get => iDPlanta; set => iDPlanta = value; }
        [Display(Name = "FatorSit.")]
        public decimal FatorSituacao { get => fatorSituacao; set => fatorSituacao = value; }
        [Display(Name = "FatorPos.")]
        public decimal FatorPosicao { get => fatorPosicao; set => fatorPosicao = value; }

        //-- Variaveis usada para o calculo da Area Coberta 

        public int TParamIDTipoConstrucao { get => tParamIDTipoConstrucao; set => tParamIDTipoConstrucao = value; }
        public int TParamIDEstrutura { get => tParamIDEstrutura; set => tParamIDEstrutura = value; }
        public int ParamIDEstruturaAreaCoberta { get => paramIDEstruturaAreaCoberta; set => paramIDEstruturaAreaCoberta = value; }
        public int ParamIDTipoConstrucao { get => paramIDTipoConstrucao; set => paramIDTipoConstrucao = value; }
        public decimal ValorM2AreaCoberta { get => valorM2AreaCoberta; set => valorM2AreaCoberta = value; }

        [Display(Name = "VVEdif.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public double ValorVenalEdificacao { get => valorVenalEdificacao; set => valorVenalEdificacao = value; }
        [Display(Name = "VVCalculo")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public double ValorVenalCalculo { get => valorVenalCalculo; set => valorVenalCalculo = value; }

    }
}
