using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabCep
    {
        public int CepId { get; set; }
        public string? CepCep { get; set; }
        public string? CepTipoLogradouro { get; set; }
        public string? CepLogradouro { get; set; }
        public string? CepComplemento { get; set; }
        public string? CepBairro { get; set; }
        public int? CidaId { get; set; }

        public virtual TabCidade? Cida { get; set; }
    }
}
