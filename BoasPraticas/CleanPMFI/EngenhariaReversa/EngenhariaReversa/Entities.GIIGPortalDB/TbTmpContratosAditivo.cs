using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpContratosAditivo
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public short? CdTipoAtoContratual { get; set; }
        public string? TipoAtoContratual { get; set; }
        public short? NrAno { get; set; }
        public string? DsTipoContrato { get; set; }
        public int? NrContrato { get; set; }
        public string? NmTipoAtoContratual { get; set; }
        public int? NrAditivo { get; set; }
        public string? DsTipoAditivo { get; set; }
        public DateTime? DtTermo { get; set; }
        public DateTime? DtPublicacaoTermo { get; set; }
        public decimal? VlAditivo { get; set; }
        public decimal? VlAtualizadoContrato { get; set; }
        public DateTime? DtNovaTermino { get; set; }
        public string? DsMotivo { get; set; }
    }
}
