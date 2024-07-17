using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaIncentivoFiscal
    {
        public int Idempincfisc { get; set; }
        public int? Idempresa { get; set; }
        public short? Idincentivo { get; set; }
        public string? Idservico { get; set; }
        public DateTime? Dtvigenciainicial { get; set; }
        public DateTime? Dtvigenciafinal { get; set; }
        public decimal? Staliquota { get; set; }
        public string? Stobservacao { get; set; }
        public string? Stsituacao { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Datainclusao { get; set; }
    }
}
