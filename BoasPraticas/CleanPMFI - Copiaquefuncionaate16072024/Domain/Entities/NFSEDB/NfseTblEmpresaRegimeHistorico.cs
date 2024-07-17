using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaRegimeHistorico
    {
        public int Idhistorico { get; set; }
        public int Idempresa { get; set; }
        public byte Idregime { get; set; }
        public DateTime Dtentrada { get; set; }
        public DateTime? Dtsaida { get; set; }
        public decimal? Vlmensal { get; set; }
        public decimal? Vlestimado { get; set; }
        public decimal? Aliqprincipal { get; set; }
    }
}
