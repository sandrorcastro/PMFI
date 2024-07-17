using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class VwMegaDataContribuinte
    {
        public int? AnoAberturaEmpresa { get; set; }
        public int? MesAberturaEmpresa { get; set; }
        public string CodigoTom { get; set; } = null!;
        public string? CnpjContribuinte { get; set; }
        public int Situacao { get; set; }
        public string? RazaoSocial { get; set; }
        public string Inicio { get; set; } = null!;
        public string Fim { get; set; } = null!;
        public int ContribuinteEstimado { get; set; }
        public string? Cnaes { get; set; }
        public decimal Vlrestimado { get; set; }
        public string? Dtexportacao { get; set; }
        public string? Endereco { get; set; }
        public string? EmailContribuinte { get; set; }
    }
}
