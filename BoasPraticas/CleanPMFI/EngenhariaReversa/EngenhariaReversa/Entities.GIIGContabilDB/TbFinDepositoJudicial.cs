using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinDepositoJudicial
    {
        public int IdDeposito { get; set; }
        public int? IdCctransf { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? DsTipoPessoa { get; set; }
        public string? NmCc { get; set; }
        public int? IdAgencia { get; set; }
        public string? DsTipoContaPessoa { get; set; }
        public DateTime? DtDeposito { get; set; }
        public decimal? VlDeposito { get; set; }
        public string? IdDepositoJudicial { get; set; }
        public string? NrCodigoBarrasDj { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? IdLiqDocto { get; set; }
    }
}
