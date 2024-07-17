using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FzitensDeVistorium
    {
        public FzitensDeVistorium()
        {
            FzitensVistoriados = new HashSet<FzitensVistoriado>();
            FzparametrosVistoria = new HashSet<FzparametrosVistoria>();
        }

        public int ItemVistId { get; set; }
        public string? ItemVistNome { get; set; }

        public virtual ICollection<FzitensVistoriado> FzitensVistoriados { get; set; }
        public virtual ICollection<FzparametrosVistoria> FzparametrosVistoria { get; set; }
    }
}
