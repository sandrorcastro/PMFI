using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpCapConvAuxPrograma
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? CdCap { get; set; }
        public string? DsRecurso { get; set; }
        public string? DsTipoRecurso { get; set; }
        public string? TipoConvenio { get; set; }
        public string? NrTermo { get; set; }
        public DateTime? DtCelebracaoTermo { get; set; }
        public DateTime? DtInicioVigencia { get; set; }
        public DateTime? DtTerminoVigencia { get; set; }
        public int? NrDoe { get; set; }
        public decimal? VlPrevisto { get; set; }
        public decimal? VlContraPartida { get; set; }
        public string? DsObjeto { get; set; }
        public decimal? VlRecebido { get; set; }
        public string? DsOrgaoRepassador { get; set; }
    }
}
