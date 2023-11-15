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
        [Key]
        public long IPTUID { get; set; }
        public long ID { get; set; }
        public DbprosigaContext _context;
        public long EdificacaoID; //deve ser int
        public long TerrenoID; 
        public TribEdificaco? Imovel;
        [Display(Name = "Insc.Imob.")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public string InscricaoImobiliaria;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal AreaTerreno;
        [Display(Name = "Fat.Corr.A.")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal FatorCorrecaoArea;
        [Display(Name = "Test.Terreno")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal TestadaTerreno;
        [Display(Name = "Prof.Padrão")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal ProfundidadePadrao;
         [Display(Name = "Log.Test.Pric")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int LogradTestadaPrincipal;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int QuadraId;
        public long FatorKID;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal FatorKValor;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal FatorLocQuadra;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal FatorPedologia;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal FatorTopografia;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal ValorM2AreaCoberta;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int ParamIDTipoConstrucao;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int ParamIDEstruturaAreaCoberta;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int TParamIDEstrutura;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int TParamIDTipoConstrucao;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal FatorPosicao;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal FatorSituacao;
        public int IDPlanta;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int PontosEdificacao;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal ValorM2;
        public int AnosConstrucao;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal AliquotaDepreciacao;
        //[Display(Name = "CategoriaID")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int CategID;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int ParamID;
        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public int TParamID;
        //[Display(Name = "AVVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public short AnoIPTU;
        [Display(Name = "A.Cob.")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal AreaCoberta;
        [Display(Name = "A.Contr.")]
        //[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal AreaConstruida;
        [Display(Name = "VVTerreno")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal ValorVenalTerreno;
        [Display(Name = "VVEdificação")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal ValorVenalEdificacao;
        [Display(Name = "VVCalculo")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal ValorVenalCalculo;
        [Display(Name = "Frac.Ideal")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal FracaoIdealEdificacao;
        //[Display(Name = "VVCalculo")]
        //[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Uf;


        public IPTU()
        {
            
        }
        public IPTU(TribEdificaco imovel)
        {
            _context = new DbprosigaContext();
            this.Imovel = imovel;
           
            inificalizaVariaveis(imovel);
            ValorVenalCalculo =  getValorVenalCalculo();
        }

        public void inificalizaVariaveis(TribEdificaco imovel)
        {
            
            this.Imovel = imovel;
            IPTUID = long.Parse(Imovel.InscricaoImobiliaria);
            EdificacaoID = this.Imovel.EdificacaoId;
            TerrenoID = (long)this.Imovel.TerrenoId;
            FracaoIdealEdificacao = this.Imovel.EdifFracaoIdealEdificacao;
            InscricaoImobiliaria = this.Imovel.InscricaoImobiliaria.ToString();
            Uf = 1.0351M;
            AreaTerreno = getAreaTerreno(TerrenoID);
            FatorCorrecaoArea = getFatorCorrecaoArea();
            TestadaTerreno = getTestadaTerreno(TerrenoID);
            LogradTestadaPrincipal = getLogradTestedaPrincipal(TerrenoID);
            QuadraId = getQuadraId(TerrenoID);
            FatorKID = getFatorKID(LogradTestadaPrincipal,QuadraId);
            FatorKValor = getFatorKValor(FatorKID);
            FatorLocQuadra = getFatorLocQuadra(EdificacaoID);
            FatorPedologia = getFatorPedologia(EdificacaoID);
            FatorTopografia = getFatorTopografia(EdificacaoID);
            ProfundidadePadrao = getProfundidadePadrao();


        }

        public decimal getProfundidadePadrao()
        {
            return _context.Parametros.Where(x => x.ParamId.ToUpper() == "TRIBUNO").FirstOrDefault().ParamTribProfundidadePadrao;
        }

        public decimal getFatorTopografia(long edificacaoID)
        {
            var sispavalorparametro = getsisParametros("Tribuno", "TopoID");
            var query = from epc in _context.TribEdifParamCalculos
                        join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                        where epc.ParamId == pc.ParamId && epc.EdificacaoId == edificacaoID && epc.TparamId == sispavalorparametro
                        select pc.Fator;
            var result = query.FirstOrDefault();
            return result != null ? (decimal)result : 1;
        }

        public decimal getFatorPedologia(long edificacaoID)
        {
            var sispavalorparametro = getsisParametros("Tribuno", "PedoID");
            var query = from epc in _context.TribEdifParamCalculos
                        join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                        where epc.ParamId == pc.ParamId && epc.EdificacaoId == edificacaoID && epc.TparamId == sispavalorparametro
                        select pc.Fator;
            var result = query.FirstOrDefault();
            return result != null ? (decimal)result : 1;
        }

        public decimal getFatorLocQuadra(long edificacaoID)
        {
            var sispavalorparametro = getsisParametros("Tribuno", "LocQID");
            var query = from epc in _context.TribEdifParamCalculos
                            join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                        where epc.ParamId == pc.ParamId && epc.EdificacaoId==edificacaoID && epc.TparamId==sispavalorparametro
                        select pc.Fator;
            var result = query.FirstOrDefault();
            return result != null ? (decimal)result : 1;

        }

        public int getsisParametros(string sipaidsistema,string sipaidparametro)
        {
            return int.Parse(_context.SisParametros.Where(x => x.SiPaIdSistema == sipaidsistema && x.SiPaIdParametro == sipaidparametro).FirstOrDefault().SiPaValorParametro);
        }
        public decimal getFatorKValor(long fatorKID)
        {
            var result =  (decimal)_context.TribFatorKs.Where(x=>x.FatorKid==fatorKID).FirstOrDefault().FatorKvalor;
            return result != null ? (decimal)result : (decimal)-9999999999.0009;
        }

        public long getFatorKID(int logradTestadaPrincipal,int quadraId)
        {
            return (long)_context.TribQuadraLograds.Where(x => x.QuadraId==quadraId && x.LogradId==logradTestadaPrincipal).FirstOrDefault().FatorKid;
            //return result != null ? (decimal)result : (decimal)-9999999999.0007; ;;
        }

        public int getQuadraId(long terrenoID)
        {
            return (int)_context.TribTerrenos.Where(t => t.TerrenoId == terrenoID).FirstOrDefault().QuadraId;
            //return result != null ? (decimal)result : (decimal)-9999999999.0007; ;
        }

        public int getLogradTestedaPrincipal(long terrenoID)
        {
            return (int) _context.TribTestadasTerrenos.Where(t => t.TerrenoId == terrenoID && t.TestadasPrincipal.ToUpper() == "SIM").FirstOrDefault().LogradId;
            //return result != null ? (decimal)result : (decimal)-9999999999.0007; ;
        }

        public decimal getTestadaTerreno(long terrenoID)
        {
            var result = _context.TribTestadasTerrenos.Where(t => t.TerrenoId==terrenoID && t.TestadasPrincipal.ToUpper()=="SIM").FirstOrDefault().TestadasMetragem;
            return result != null ? (decimal)result : (decimal)-9999999999.0007; ;
        }

        public decimal getFatorCorrecaoArea()
        {
            var result = _context.TribFatorCorAreas.Where(f=> f.FatCorAreaDe <= AreaTerreno && f.FatCorAreaAte >= AreaTerreno).FirstOrDefault().FatCorAreaFator;
            return result != null ? (decimal)result : (decimal)-9999999999.0006; ;
        }

        public decimal getAreaTerreno(long? terrenoId)
        {
            var result = _context.TribTerrenos.Where(t => t.TerrenoId == terrenoId).FirstOrDefault().TerrAreaTerreno;
            return result != null ? (decimal) result : (decimal) -9999999999.0005;
        }

        public decimal getValorVenalCalculo()
        {
            return  getValorVenalEdificacao()+ (getValorVenalTerreno() *  FracaoIdealEdificacao);

        }

        public decimal getValorVenalTerreno()
        {
             double  resultado=0;

            if (AreaTerreno > 10000)
            {

                 resultado = Math.Sqrt((double)AreaTerreno * (double)FatorCorrecaoArea * (double)TestadaTerreno / (double)ProfundidadePadrao);
                //-- Multiplica pelo Fator K
                resultado = resultado * (double)FatorKValor;
                //--Multiplica pelo Fator de Localizacao da Quadra
                resultado = resultado * (double)FatorLocQuadra;
                //--Multiplica pelo Fator da Pedologia
                resultado = resultado * (double)FatorPedologia;
                //--Multiplica pelo Fator da Topografia
                resultado = resultado * (double)FatorTopografia;
                //--Multiplica pelo Variação da UF ..
                resultado = resultado * (double)Uf;
            }
            else
            {
                resultado = (double) getFatorG()* (double)getFatorK()* (double) getFatorF()* (double) getFatorT()* (double)getFatorFI();
            }

            ValorVenalTerreno = (decimal)resultado;
            return (decimal) resultado;
        }

        private decimal getFatorG()
        {
            return  (decimal) Math.Sqrt((double)AreaTerreno *  (double)TestadaTerreno / (double)ProfundidadePadrao);
        }
        private decimal getFatorK()
        {
            var result = (decimal)_context.TribFatorKs.Where(x => x.FatorKid == FatorKID).FirstOrDefault().FatorKvalor;
            return result != null ? (decimal)result : (decimal)-9999999999.0009;
        }
        private decimal getFatorC()
        {
            return 1;// Math.Sqrt((double)AreaTerreno * (double)TestadaTerreno / (double)ProfundidadePadrao);
        }
        private decimal getFatorT()
        {
            var sispavalorparametro = getsisParametros("Tribuno", "TopoID");
            var query = from epc in _context.TribEdifParamCalculos
                        join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                        where epc.ParamId == pc.ParamId && epc.EdificacaoId == EdificacaoID && epc.TparamId == sispavalorparametro
                        select pc.Fator;
            var result = query.FirstOrDefault();
            return result != null ? (decimal)result : 1;
        }
        private decimal getFatorF()
        {
            var sispavalorparametro = getsisParametros("Tribuno", "LocQID");
            var query = from epc in _context.TribEdifParamCalculos
                        join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                        where epc.ParamId == pc.ParamId && epc.EdificacaoId == EdificacaoID && epc.TparamId == sispavalorparametro
                        select pc.Fator;
            var result = query.FirstOrDefault();
            return result != null ? (decimal)result : 1;
        }
        private decimal getFatorP()
        {
            var sispavalorparametro = getsisParametros("Tribuno", "PedoID");
            var query = from epc in _context.TribEdifParamCalculos
                        join pc in _context.TribParamCalculos on epc.TparamId equals pc.TparamId
                        where epc.ParamId == pc.ParamId && epc.EdificacaoId == EdificacaoID && epc.TparamId == sispavalorparametro
                        select pc.Fator;
            var result = query.FirstOrDefault();
            return result != null ? (decimal)result : 1;
        }
        private decimal getFatorFI()
        {
            return FracaoIdealEdificacao;
        }

        public decimal getValorVenalEdificacao()
        {
            return ValorVenalEdificacao= 1;
            //throw new NotImplementedException();
        }






        //  [Display(Name = "VVCalculo")]
        //  [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        //  public double ValorVenalCalculo { get => valorVenalCalculo; set => valorVenalCalculo = value; }

    }
}
