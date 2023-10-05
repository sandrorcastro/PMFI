using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DesifDemApuRecTribIssqnsubtitulo
    {
        public int Iddemapurectribisssub { get; set; }
        public int Iddeclaracao { get; set; }
        public string Stcoddepende { get; set; } = null!;
        public string Stsubtitulo { get; set; } = null!;
        public string Stcodtribdesif { get; set; } = null!;
        public decimal Vlcreditomens { get; set; }
        public decimal Vldebitomens { get; set; }
        public decimal Vlreceita { get; set; }
        public decimal? Vldeducaoreceita { get; set; }
        public string? Stdescdeducao { get; set; }
        public decimal Vlbasecalculo { get; set; }
        public decimal Nualiquota { get; set; }
        public decimal? Vlincentivofisc { get; set; }
        public string? Stdescincentfisc { get; set; }
        public byte? Numotivonaoexig { get; set; }
        public string? Nuprocnaoexig { get; set; }
    }
}
