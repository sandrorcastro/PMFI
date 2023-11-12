using Fazenda.Entities.DBProsiga;
using Microsoft.CodeAnalysis.Elfie.Extensions;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Fazenda.Models
{
    public class IPTU
    {

        public TribEdificaco? Imovel { get; set; }
        //public TribTerreno? Terreno { get; set; }

        public IPTU()
        {
            
        }
        public IPTU(TribEdificaco imovel)
        {
            Imovel = imovel;
            EdificacaoID = imovel.EdificacaoId;
            ID = imovel.EdificacaoId;
            InscricaoImobiliaria = imovel.InscricaoImobiliaria;
            EdifCaracteristica = imovel.EdifCaracteristica;
            //
            ValorVenalCalculo = getValorVenalCalculo();
            ValorVenalEdificacao = getValorVenalEdificacao();
            ValorVenalTerrenoParaEdificacao = getValorVenalTerreno();
            //
            ValorVenalEdificacaoGIIG = (decimal) imovel.ValorVenalEdificacao;
            ValorVenalTerrenoParaEdificacaoGIIG =  (decimal) imovel.ValorVenalTerrenoParaEdificacao; 
            ValorVenalCalculoGIIG = (decimal)imovel.ValorVenalCalculo;
         
        
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
            if(Imovel.Terreno.TerrAreaTerreno <= 10000)
            {
                //VT = Valor Venal do terreno;
                //G = Fator Geométrico(área do imóvel corrigida em relação ao padrão);
                //K = Fator Codificado de valor do metro quadrado do imóvel, segundo o local onde se situa(Anexo I -Tabela I);
                //F = Fator Localização na Quadra(Anexo I - Tabela III);
                //T = Fator Topográfico(Anexo I - Tabela IV);
                //P = Fator Pedológico(Anexo I - Tabela V); e
                //FI = Fração Ideal da Unidade Autônoma(Fração obtida através da proporção de cada edificação existente no imóvel com relação à área total do imóvel).
                return getFatorG() * GetFatorK() * getFatorF() * getFatorP() * getFatorT()*getFatorFI();
            }
            return  2;
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
                return 1;
            }
            return 1;
        }

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
        public decimal ValorVenalCalculo { get; set; }
        public decimal ValorVenalEdificacao { get; set; }
        public decimal ValorVenalTerrenoParaEdificacao { get; set; }

        [Display(Name = "Caracteristica")]
        public string EdifCaracteristica { get; set; }




    }
}
