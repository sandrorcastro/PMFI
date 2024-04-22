using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FztipoVeiculo
    {
        public FztipoVeiculo()
        {
            Fzcredencials = new HashSet<Fzcredencial>();
            FzparametrosVistoria = new HashSet<FzparametrosVistoria>();
            Fzveiculos = new HashSet<Fzveiculo>();
        }

        public int FztipoVeicId { get; set; }
        public string FztipoVeicNome { get; set; } = null!;
        public string? Flvistorialocal { get; set; }
        public bool? Flexigepontovistoria { get; set; }
        public bool? Flexigesegurovistoria { get; set; }
        public bool? Flexigeemplacvistoria { get; set; }
        public bool? Flexigecondutorvistoria { get; set; }
        public byte? Nrvistoriaprazovencto { get; set; }
        public bool? Flutilizanrveiculo { get; set; }
        public bool? Flexigepermissionario { get; set; }
        public int? Nrvigenciameses { get; set; }
        public string? Dspermissaotipo { get; set; }
        public int? Idusuariogravacao { get; set; }
        public DateTime? Dtgravacao { get; set; }
        public int? Idusuarioultalt { get; set; }
        public DateTime? Dtultalt { get; set; }

        public virtual ICollection<Fzcredencial> Fzcredencials { get; set; }
        public virtual ICollection<FzparametrosVistoria> FzparametrosVistoria { get; set; }
        public virtual ICollection<Fzveiculo> Fzveiculos { get; set; }
    }
}
