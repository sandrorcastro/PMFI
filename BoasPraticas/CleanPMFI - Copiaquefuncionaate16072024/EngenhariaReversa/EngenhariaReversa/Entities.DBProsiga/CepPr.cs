using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class CepPr
    {
        public int Seq { get; set; }
        public string? Localidade { get; set; }
        public string? Nome { get; set; }
        public string? BaiIni { get; set; }
        public string? BaiFim { get; set; }
        public string Cep { get; set; } = null!;
        public string? Complemento { get; set; }
        public string? Logradouro { get; set; }
        public string? SemAcento { get; set; }
        public string? LocalidadeSemAcento { get; set; }
        public string? BaiIniSemAcento { get; set; }
        public string? BaiFimSemAcento { get; set; }
    }
}
