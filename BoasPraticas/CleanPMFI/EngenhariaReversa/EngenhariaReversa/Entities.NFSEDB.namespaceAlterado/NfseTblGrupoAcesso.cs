using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblGrupoAcesso
    {
        public int Idgrupoacess { get; set; }
        public int Idempresa { get; set; }
        public string? Stdescricao { get; set; }
        public string? Stemitenfse { get; set; }
        public string? Stsubstituinfse { get; set; }
        public string? Stcancelanfse { get; set; }
        public string? Stimprimenfse { get; set; }
        public string? Stconsultanfseemitida { get; set; }
        public string? Stconsultanfserecebida { get; set; }
        public string? Stconsultanfseporrps { get; set; }
        public string? Stcredencia { get; set; }
        public string? Stconsultasituloterps { get; set; }
        public string? Stenvialoterps { get; set; }
        public string? Stconsultaloterps { get; set; }
        public string? Stemitirboletos { get; set; }
        public string? Stcancelarboletos { get; set; }
        public string? Stimprimirboletos { get; set; }
        public string? Stconsultarboletos { get; set; }
        public string? Stencerracompetencia { get; set; }
        public string? Stexportanfse { get; set; }
        public string? Stgerarlivrofiscal { get; set; }
        public string? Stconsultaextrato { get; set; }
        public string? Stdecinfcommun { get; set; }
        public string? Stconinfcommun { get; set; }
        public string? Stdecdemcontab { get; set; }
        public string? Stcondemcontab { get; set; }
        public string? Stdecapumeniss { get; set; }
        public string? Stconapumeniss { get; set; }
        public string? Stdecdemparlan { get; set; }
        public string? Stcondemparlan { get; set; }
        public string? Stcriagrupos { get; set; }
        public string? Stdeclaracoes { get; set; }
        public string? Strecibos { get; set; }
        public string? Stintervenecf { get; set; }
        public string? Sthomologacao { get; set; }
        public string? Stexportanfserecebidas { get; set; }
        public string? Stcadaliquota { get; set; }
    }
}
