using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DesifDemonstrativoIssqnmensalRecolher
    {
        public int Iddemissmenrec { get; set; }
        public int Iddeclaracao { get; set; }
        public string? Stcnpj { get; set; }
        public string? Stcodtribdesif { get; set; }
        public decimal Vlrecdeccons { get; set; }
        public decimal? Vldeddecsub { get; set; }
        public decimal? Vldeddeccons { get; set; }
        public string? Stdescdedu { get; set; }
        public decimal Vlbasecalculo { get; set; }
        public decimal? Nualiquota { get; set; }
        public decimal Vlissqn { get; set; }
        public decimal? Vlissqnretido { get; set; }
        public decimal? Vlincentfiscsub { get; set; }
        public decimal? Vlincentivofisc { get; set; }
        public string? Stdescincentfisc { get; set; }
        public decimal? Vlcredcompensa { get; set; }
        public string? Stdesccompensa { get; set; }
        public DateTime? Dtcompcredito { get; set; }
        public decimal? Vlorigemcred { get; set; }
        public decimal? Vlissrecolhido { get; set; }
        public byte? Numotivonaoexig { get; set; }
        public string? Nuprocnaoexig { get; set; }
        public decimal? Vlissrecolher { get; set; }
    }
}
