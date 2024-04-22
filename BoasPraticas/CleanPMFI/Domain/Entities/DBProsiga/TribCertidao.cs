using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribCertidao
    {
        public int CertId { get; set; }
        public string? CertTipoCertidao { get; set; }
        public long? CertInscricaoId { get; set; }
        public string? CertInscricaoTipo { get; set; }
        public int? CertAno { get; set; }
        public DateTime? CertData { get; set; }
        public string? CertForcada { get; set; }
        public DateTime? CertValidade { get; set; }
        public byte[]? CertObjeto { get; set; }
        public long? CertTempCertNegId { get; set; }
        public string? CertUsuarioInclusao { get; set; }
        public DateTime? CertDataInclusao { get; set; }
    }
}
