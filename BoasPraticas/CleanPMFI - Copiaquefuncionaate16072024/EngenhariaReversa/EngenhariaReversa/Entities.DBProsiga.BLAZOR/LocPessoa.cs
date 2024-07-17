using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class LocPessoa
    {
        public int PessoaId { get; set; }
        public string? PesNome { get; set; }
        public DateTime? PesDtNasc { get; set; }
        public string? PesCpfCnpj { get; set; }
        public string? PesRg { get; set; }
        public string? PesUfrg { get; set; }
        public string? PesSexo { get; set; }
        public string? PesNaturalCid { get; set; }
        public string? PesNaturalUf { get; set; }
        public string? PesNacionalidade { get; set; }
        public string? PesEscolaridade { get; set; }
        public string? PesEstCivil { get; set; }
        public string? PesCep { get; set; }
        public string? PesFone { get; set; }
        public string? PesEndereco { get; set; }
        public int? PesNumPredial { get; set; }
        public string? PesEmail { get; set; }
        public string? PesTecUltAlt { get; set; }
        public string? PesHostUltAlt { get; set; }
        public DateTime? PesDtUltAlt { get; set; }
    }
}
