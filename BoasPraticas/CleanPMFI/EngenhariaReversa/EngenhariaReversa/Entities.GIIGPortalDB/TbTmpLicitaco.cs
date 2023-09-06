using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpLicitaco
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int? IdLicitacao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? NrLicitacao { get; set; }
        public short? NrAno { get; set; }
        public string? DsModalidade { get; set; }
        public short? IdModalidade { get; set; }
        public DateTime? DtEdital { get; set; }
        public string? DsObjeto { get; set; }
        public DateTime? DtAbertura { get; set; }
        public string? DsHoraAbertura { get; set; }
        public DateTime? DtJulgamento { get; set; }
        public string? DsHoraJulgamento { get; set; }
        public decimal? VlMinimo { get; set; }
        public decimal? VlMaximo { get; set; }
        public string? DsRegimeExecucao { get; set; }
        public string? DsClassificacaoObjeto { get; set; }
        public string? DsNaturezaProcedimento { get; set; }
        public string? DsTipoAvaliacao { get; set; }
        public string? NmSetorCompra { get; set; }
    }
}
