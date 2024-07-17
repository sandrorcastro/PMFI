using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FztipoVistorium
    {
        public FztipoVistorium()
        {
            FzparametrosVistoria = new HashSet<FzparametrosVistoria>();
            FzvistoriaVeiculos = new HashSet<FzvistoriaVeiculo>();
            Txes = new HashSet<Fztaxa>();
        }

        public long FztipoVistId { get; set; }
        public string? FztipoVistNome { get; set; }

        public virtual ICollection<FzparametrosVistoria> FzparametrosVistoria { get; set; }
        public virtual ICollection<FzvistoriaVeiculo> FzvistoriaVeiculos { get; set; }

        public virtual ICollection<Fztaxa> Txes { get; set; }
    }
}
