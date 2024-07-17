using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpReceitasSuporte
    {
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? IdReceita { get; set; }
        public string? CdReceita { get; set; }
        public string? DsReceita { get; set; }
        public decimal? VlOrcado { get; set; }
        public decimal? VlCorrigido { get; set; }
        public decimal? Janeiro { get; set; }
        public decimal? Fevereiro { get; set; }
        public decimal? Março { get; set; }
        public decimal? Abril { get; set; }
        public decimal? Maio { get; set; }
        public decimal? Junho { get; set; }
        public decimal? Julho { get; set; }
        public decimal? Agosto { get; set; }
        public decimal? Setembro { get; set; }
        public decimal? Outubro { get; set; }
        public decimal? Novembro { get; set; }
        public decimal? Dezembro { get; set; }
        public decimal? Acumulado { get; set; }
        public int? IdReceitaNivelSuper { get; set; }
        public short? IdEmpresaOrc { get; set; }
        public string? Tipo { get; set; }
        public short? AnoArrec { get; set; }
        public string? Orgao { get; set; }
        public string? Unidade { get; set; }
    }
}
