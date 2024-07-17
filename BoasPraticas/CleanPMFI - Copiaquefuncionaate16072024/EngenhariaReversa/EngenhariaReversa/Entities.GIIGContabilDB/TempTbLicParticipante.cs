using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TempTbLicParticipante
    {
        public int IdParticipante { get; set; }
        public int? IdLicitacao { get; set; }
        public DateTime? DtConvite { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdPessoaRepresentante { get; set; }
        public int? IdCrcf { get; set; }
        public DateTime? DtCredenciamento { get; set; }
        public string? FlConvidado { get; set; }
        public string? FlHabilitado { get; set; }
        public string? DsMotivoNaoHabilitacao { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? NrIdade { get; set; }
        public int? IdParticipanteOrigem { get; set; }
    }
}
