using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpOrcReceitasMovimento
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? IdMovReceita { get; set; }
        public DateTime? Data { get; set; }
        public int? Ano { get; set; }
        public int? Mês { get; set; }
        public string? DsUnidadeOrcamentaria { get; set; }
        public string? CdReceita { get; set; }
        public string? DsReceita { get; set; }
        public string? FlReceitaIntraOrcamentaria { get; set; }
        public short? IdTipoPermissaoDeducao { get; set; }
        public decimal? Valor { get; set; }
        public string? OrgaoRepassador { get; set; }
    }
}
