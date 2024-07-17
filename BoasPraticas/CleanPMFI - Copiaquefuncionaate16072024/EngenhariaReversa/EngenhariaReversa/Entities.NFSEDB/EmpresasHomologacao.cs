using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class EmpresasHomologacao
    {
        public int IdContribuinte { get; set; }
        public string? NomeContribuinte { get; set; }
        public string? CpfCnpj { get; set; }
        public string? TipoPessoa { get; set; }
        public int IdEmpresa { get; set; }
        public string Situacao { get; set; } = null!;
        public DateTime DataInclusao { get; set; }
        public DateTime? DataHomologacao { get; set; }
        public string? Motivo { get; set; }
        public DateTime? DataLiberacao { get; set; }
        public string? Cmc { get; set; }
    }
}
