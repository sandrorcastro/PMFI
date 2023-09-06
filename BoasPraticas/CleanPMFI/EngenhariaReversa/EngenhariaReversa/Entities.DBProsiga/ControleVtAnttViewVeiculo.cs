using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ControleVtAnttViewVeiculo
    {
        public string? AcessoOperadorCpf { get; set; }
        public long FzveiId { get; set; }
        public string? Placa { get; set; }
        public int? AnoFabric { get; set; }
        public int? AnoModelo { get; set; }
        public string? ConCnpjcpf { get; set; }
        public string? RazaoSocial { get; set; }
    }
}
