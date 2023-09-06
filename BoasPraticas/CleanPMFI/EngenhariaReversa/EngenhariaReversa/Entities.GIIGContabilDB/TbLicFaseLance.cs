using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicFaseLance
    {
        public int IdLance { get; set; }
        public int? IdLicitacao { get; set; }
        public short? NrSequencia { get; set; }
        public int? IdPessoa { get; set; }
        public int? NrLote { get; set; }
        public int? IdItem { get; set; }
        public decimal? VlLance { get; set; }
        public string? FlDesclassificado { get; set; }
        public string? DsTipoDesclassificacao { get; set; }
        public string? DsMotivoDesclassificado { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsOrigem { get; set; }

        public virtual TbDspIten? IdItemNavigation { get; set; }
        public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }
        public virtual TbGerPessoa? IdPessoaNavigation { get; set; }
    }
}
