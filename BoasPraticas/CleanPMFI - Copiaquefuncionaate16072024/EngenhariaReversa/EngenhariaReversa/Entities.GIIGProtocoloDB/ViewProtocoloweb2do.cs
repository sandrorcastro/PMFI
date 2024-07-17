using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class ViewProtocoloweb2do
    {
        public long ProcId { get; set; }
        public short? ProcAno { get; set; }
        public int? ProcSequencia { get; set; }
        public string? AssuNome { get; set; }
        public string? PessCpfcnpj { get; set; }
        public string? PessNome { get; set; }
        public string? ProcComplemento { get; set; }
        public string? PessFone { get; set; }
        public DateTime? ProcData { get; set; }
        public string? PessCep { get; set; }
        public string? PessLogradouro { get; set; }
        public string? PessTipoLogradouro { get; set; }
        public string? PessBairro { get; set; }
        public string? CidaNome { get; set; }
        public string? CidaUf { get; set; }
    }
}
