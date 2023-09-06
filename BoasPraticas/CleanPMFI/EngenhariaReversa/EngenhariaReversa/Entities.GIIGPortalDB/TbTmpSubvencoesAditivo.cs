using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpSubvencoesAditivo
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public string? DsTipoExecucao { get; set; }
        public int? CdSubvencaoSocial { get; set; }
        public int? NrAno { get; set; }
        public string? DsTpEntidade { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NmPessoa { get; set; }
        public long? NrAditivo { get; set; }
        public DateTime? DtAditivo { get; set; }
        public DateTime? DtVencimentoConvenio { get; set; }
        public string? DsAditivoObjeto { get; set; }
        public string? Dotacao { get; set; }
    }
}
