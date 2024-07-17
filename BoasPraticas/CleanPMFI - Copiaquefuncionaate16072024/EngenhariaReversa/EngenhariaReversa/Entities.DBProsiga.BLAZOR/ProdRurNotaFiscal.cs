using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class ProdRurNotaFiscal
    {
        public ProdRurNotaFiscal()
        {
            ProdRurNotaFiscaisCancelada = new HashSet<ProdRurNotaFiscaisCancelada>();
            ProdRurNotaFiscalItens = new HashSet<ProdRurNotaFiscalIten>();
            ProdRurNotaFiscalOcorrs = new HashSet<ProdRurNotaFiscalOcorr>();
            Idprotocolos = new HashSet<ProdRurProtocolo>();
        }

        public int IdnotaFiscal { get; set; }
        public DateTime? DataValidade { get; set; }
        public int? NumNotaFiscal { get; set; }
        public int? IdpropProdutor { get; set; }
        public long? ConIdcomprador { get; set; }
        public int? IdnatOperacao { get; set; }
        public DateTime? DataEmissao { get; set; }
        public long? ConIdtransportador { get; set; }
        public string? VeicTransPlacaPref { get; set; }
        public string? VeicTransPlacaNum { get; set; }
        public string? FretePorConta { get; set; }
        public decimal? ValorBaseImposto { get; set; }
        public decimal? ValorImposto { get; set; }
        public string? NumNfcomprador { get; set; }
        public decimal? ValorNfcomprador { get; set; }

        public virtual Contribuinte? ConIdcompradorNavigation { get; set; }
        public virtual Contribuinte? ConIdtransportadorNavigation { get; set; }
        public virtual ProdRurNaturezaOperacao? IdnatOperacaoNavigation { get; set; }
        public virtual ProdRurPropriedadesRurProdutor? IdpropProdutorNavigation { get; set; }
        public virtual ICollection<ProdRurNotaFiscaisCancelada> ProdRurNotaFiscaisCancelada { get; set; }
        public virtual ICollection<ProdRurNotaFiscalIten> ProdRurNotaFiscalItens { get; set; }
        public virtual ICollection<ProdRurNotaFiscalOcorr> ProdRurNotaFiscalOcorrs { get; set; }

        public virtual ICollection<ProdRurProtocolo> Idprotocolos { get; set; }
    }
}
