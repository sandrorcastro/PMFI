using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbAmmDotacoesEstaduaisConvenio
    {
        public int IdDotacaoEstadual { get; set; }
        public short? IdEmpresa { get; set; }
        public string? CdConvenioAuxilio { get; set; }
        public string? CdDotacao { get; set; }
    }
}
