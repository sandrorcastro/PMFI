using Fazenda.Controllers;
using Fazenda.Entities.DBProsiga;
using Microsoft.CodeAnalysis.Elfie.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Fazenda.Models
{
    public class IPTU01
    {
        private DbprosigaContext _context;
        public TribEdificaco? Imovel { get; set; }
        //public TribTerreno? Terreno { get; set; }

        public IPTU01()
        {
            
        }
        public IPTU01(TribEdificaco imovel)
        {

            _context = new DbprosigaContext();
            Imovel = imovel;
            EdificacaoID = imovel.EdificacaoId;
            ID = imovel.EdificacaoId;
            IPTUID = imovel.EdificacaoId;
            InscricaoImobiliaria = imovel.InscricaoImobiliaria;
            EdifCaracteristica = imovel.EdifCaracteristica;
           // InscricoesImobiliariaPorQuadra = new List<IPTU>();
            //obterInscricoesImobiliariaPorQuadra(); // = _context.TribEdificacoes.Where(insc => insc.InscricaoImobiliaria.Substring(7, 7) == Imovel.InscricaoImobiliaria.Substring(7, 7)).ToList(); //.Select(i=>i.EdificacaoId).ToList();
            //
            ValorVenalCalculo = getValorVenalCalculo();
            ValorVenalEdificacao = getValorVenalEdificacao();
            ValorVenalTerrenoParaEdificacao = getValorVenalTerreno();
            //
            ValorVenalEdificacaoGIIG = (decimal) imovel.ValorVenalEdificacao;
            ValorVenalTerrenoParaEdificacaoGIIG =  (decimal) imovel.ValorVenalTerrenoParaEdificacao; 
            ValorVenalCalculoGIIG = (decimal)imovel.ValorVenalCalculo;
         
        
    }

        public async void obterInscricoesImobiliariaPorQuadra()
        {
            //this.InscricoesImobiliariaPorQuadra = await _context.TribEdificacoes.Where(insc => insc.InscricaoImobiliaria.Substring(0, 6) == Imovel.InscricaoImobiliaria.Substring(0, 6)).AsNoTracking().ToListAsync(); //.Select(i=>i.EdificacaoId).ToList();
            var imoveis = from Imoveis in _context.TribEdificacoes.Where(insc => insc.EdifSituacao=="Normal" && insc.InscricaoImobiliaria.Substring(0, 6) == Imovel.InscricaoImobiliaria.Substring(0, 6)) select Imoveis; //.Select(i=>i.EdificacaoId).ToList();
                                                                   
            /*InscricoesImobiliariaPorQuadra = new List<Type>();
            foreach (TribEdificaco imovel in imoveis.AsNoTracking().ToList())
            {
                //Console.WriteLine($"Id: {imovel.Id}, Nome: {imovel.Nome}");
                //  TribFatorCorArea  fatorA = imovel.Terreno.TerrAreaTerreno < 10000 ? new TribFatorCorArea() { FatCorAreaAte=1}  :  _context.TribFatorCorAreas.Where(fa => fa.FatCorAreaDe < imovel.Terreno.TerrAreaTerreno && fa.FatCorAreaAte >= imovel.Terreno.TerrAreaTerreno).FirstOrDefault();
                //iPTUs.Add(new IPTU(imovel) { FatorA= (decimal) fatorA.FatCorAreaFator.GetValueOrDefault()});
               // InscricoesImobiliariaPorQuadra.Add(imovel);
            }*/
        }

        private decimal getValorVenalCalculo()
        {
            return ValorVenalCalculo = getValorVenalTerreno() + getValorVenalEdificacao();
            //return 1;
        }

        private long  getValorVenalEdificacao()
        {
            return 1;
        }

        private decimal getValorVenalTerreno()
        {
            if (Imovel.Terreno.TerrAreaTerreno != null)
            {
                if (Imovel.Terreno.TerrAreaTerreno <= 10000)
                {
                    //VT = Valor Venal do terreno;
                    //G = Fator Geométrico(área do imóvel corrigida em relação ao padrão);
                    //K = Fator Codificado de valor do metro quadrado do imóvel, segundo o local onde se situa(Anexo I -Tabela I);
                    //F = Fator Localização na Quadra(Anexo I - Tabela III);
                    //T = Fator Topográfico(Anexo I - Tabela IV);
                    //P = Fator Pedológico(Anexo I - Tabela V); e
                    //FI = Fração Ideal da Unidade Autônoma(Fração obtida através da proporção de cada edificação existente no imóvel com relação à área total do imóvel).
                    return getFatorG() * GetFatorK() * getFatorF() * getFatorT() * getFatorP() * getFatorFI();
                } else if(Imovel.Terreno.TerrAreaTerreno > 10000)
                {
                    //VT = Valor Venal do Terreno;
                    //A = Área do Terreno;
                    //C = Fator de Correção(Anexo I -Tabela II);
                    //K = Fator Codificado de valor do metro quadrado, segundo o local onde se situa o imóvel(Anexo I -Tabela I);
                    //F = Fator Localização na Quadra(Anexo I - Tabela III);
                    //T = Fator Topográfico(Anexo I - Tabela IV);
                    //P = Fator Pedológico(Anexo I - Tabela V);
                    //FI = Fração Ideal da Unidade Autônoma(Fração obtida através da proporção de cada edificação existente no imóvel com relação à área total do imóvel); e
                    //40 = Profundidade Padrão.
                    return (getFatorA() * GetFatorC() * GetFatorK() * getFatorF() * getFatorT() * getFatorP() * getFatorFI())/40;
                }
            }
            return  1;
        }

        private decimal GetFatorC()
        {
            return 1; // (decimal) Imovel.
        }

        private decimal getFatorA()
        {
            return (decimal) Imovel.Terreno.TerrAreaTerreno;
        }

        private decimal getFatorT()
        {
            return (decimal) Imovel.Terreno.Topo.TopoFator;
        }

        private decimal getFatorFI()
        {
            return Imovel.EdifFracaoIdealEdificacao;
        }

        private decimal getFatorP()
        {
            return (decimal) Imovel.Terreno.Pedo.PedoFator;
        }

        private decimal getFatorF()
        {
            return (decimal)Imovel.Terreno.LocQ.LocQfator;
        }

        private decimal GetFatorK()
        {
            return 1; // (decimal) Imovel.Terreno
        }

        private decimal getFatorG()
        {
                if (Imovel.Terreno.TerrAreaTerreno <= 10000)
                {

                    return (getFatorA() * getFatorTT())/40;



                } else if( Imovel.Terreno.TerrAreaTerreno > 10000)
                {
                    return 1;
                }

            
            return 1;
        }

        private decimal getFatorTT()
        {
            return (decimal) _context.TribTestadasTerrenos.Where(t=>t.TerrenoId == Imovel.TerrenoId && t.LogradId==Imovel.LogradId && t.TestadasPrincipal=="Sim").FirstOrDefault().TestadasMetragem;
        }

        [Key]
        public long IPTUID { get; set; }
        public long ID { get; set; }
        [Display(Name = "ID")]
        public long EdificacaoID { get; set; }
        [Display(Name = "Insc.Imob.")]
        public string InscricaoImobiliaria { get; set; }


        //Para comparacao com o GIIG
        [Display(Name = "VVCGIIG")]
        public decimal  ValorVenalCalculoGIIG { get; set; }
        [Display(Name = "VVEGIIG")]
        public decimal ValorVenalEdificacaoGIIG { get; set; }
        [Display(Name = "VVTPEGIIG")]
        public decimal ValorVenalTerrenoParaEdificacaoGIIG { get; set; }

        
        //Novo Sistema
        public decimal FatorA { get; set; }
        public decimal ValorVenalCalculo { get; set; }
        public decimal ValorVenalEdificacao { get; set; }
        public decimal ValorVenalTerrenoParaEdificacao { get; set; }

        [Display(Name = "Caracteristica")]
        public string EdifCaracteristica { get; set; }

        //public virtual List<IPTU> InscricoesImobiliariaPorQuadra { get; set; }
       // public virtual List<Type> InscricoesImobiliariaPorQuadra { get; set; }




    }
}
