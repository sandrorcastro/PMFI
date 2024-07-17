using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblDeclaracaoPendente
    {
        public int Iddeclaracaopendente { get; set; }
        public long? Idnfse { get; set; }
        public string? Idregime { get; set; }
        public int? Idempresa { get; set; }
        public int? Nunumero { get; set; }
        public string? Stissretido { get; set; }
        public string? Stenviaporemail { get; set; }
        public string? Strecolheiss { get; set; }
        public string? Stsituacao { get; set; }
        public string? Sttompessoatipo { get; set; }
        public decimal? Vlservicos { get; set; }
        public decimal? Vltotaliss { get; set; }
        public DateTime? Dtcompetencia { get; set; }
        public DateTime? Dtpagamento { get; set; }
        public string? Flprocessado { get; set; }
        public string Idusuario { get; set; } = null!;

        public virtual NfseTblEmpresa? IdempresaNavigation { get; set; }
        public virtual NfseTblNfse? IdnfseNavigation { get; set; }
    }
}
