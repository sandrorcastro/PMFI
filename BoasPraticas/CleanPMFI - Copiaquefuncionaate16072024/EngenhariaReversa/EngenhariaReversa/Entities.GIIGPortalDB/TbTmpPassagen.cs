using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpPassagen
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public string? NmPessoa { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public decimal? NrDiarias { get; set; }
        public string? DsDestino { get; set; }
        public string? DsObjetivo { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public string? DsTipoLocomocao { get; set; }
        public string? DsNatDespesa { get; set; }
        public string? Cdnatdespesa { get; set; }
    }
}
