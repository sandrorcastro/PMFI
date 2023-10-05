using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class EncerramentosAjustado
    {
        public decimal Vltotal { get; set; }
        public int Idencerramento { get; set; }
        public byte Numescompetencia { get; set; }
        public short Nuanocompetencia { get; set; }
        public string Sttiporecolhimento { get; set; } = null!;
        public string? Stim { get; set; }
        public long DivEmpId { get; set; }
        public long? EmprCmc { get; set; }
        public int? EmprDivAno { get; set; }
        public int? EmprDivMes { get; set; }
        public DateTime? EmprDivDataGeracao { get; set; }
        public string? EmprDivOrigemLancamento { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? EmprDivObs { get; set; }
        public decimal EmprDivValor { get; set; }
        public int TipoBxId { get; set; }
        public string? TipoBxNome { get; set; }
        public int TipoTribId { get; set; }
        public string? TipoTribNome { get; set; }
    }
}
