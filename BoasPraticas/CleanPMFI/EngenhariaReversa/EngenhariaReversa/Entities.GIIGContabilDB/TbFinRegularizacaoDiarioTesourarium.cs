using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinRegularizacaoDiarioTesourarium
    {
        public int IdRegularizacaoDiario { get; set; }
        public int IdLancamentoDiario { get; set; }
        public int? NrRegularizacao { get; set; }
        public short? NrAnoRegularizacao { get; set; }
        public short? IdTipoDocFinanceiro { get; set; }
        public string? NrDocFinanceiro { get; set; }
        public DateTime? DtDocumento { get; set; }
        public short? IdEmpresaOrigemDestino { get; set; }
        public int? IdCc { get; set; }
        public int? IdContaContabilContraPartida { get; set; }
        public int? IdCccredor { get; set; }
        public DateTime? DtRegularizacao { get; set; }
        public int? IdPessoa { get; set; }

        public virtual TbFinDiarioTesourarium IdLancamentoDiarioNavigation { get; set; } = null!;
    }
}
