using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpLicitacoesv2
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int IdLicitacao { get; set; }
        public short? IdEmpresaLicit { get; set; }
        public int? NrLicitacao { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsModalidade { get; set; }
        public string? DsObjeto { get; set; }
        public DateTime? DtAbertura { get; set; }
        public string? Situacao { get; set; }
        public short? IdEmpresaOrigem { get; set; }
        public DateTime? DtPublicacao { get; set; }
    }
}
