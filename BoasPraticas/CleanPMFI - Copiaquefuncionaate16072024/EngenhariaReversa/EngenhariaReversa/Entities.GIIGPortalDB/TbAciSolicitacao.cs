using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbAciSolicitacao
    {
        public TbAciSolicitacao()
        {
            TbAciSolicitacaoAnexos = new HashSet<TbAciSolicitacaoAnexo>();
            TbAciSolicitacaoDespachos = new HashSet<TbAciSolicitacaoDespacho>();
        }

        public int IdSolicitacao { get; set; }
        public string? DsTipoPessoa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NmPessoa { get; set; }
        public string? DsLogradouro { get; set; }
        public string? NrPredial { get; set; }
        public string? DsBairro { get; set; }
        public string? NmCidade { get; set; }
        public string? DsCep { get; set; }
        public string? NmEstado { get; set; }
        public string? DsEmail { get; set; }
        public string? NrTelefones { get; set; }
        public string? DsEspecificacaoPedido { get; set; }
        public int? IdTipoRecebimento { get; set; }
        public string? TpRecebimento { get; set; }
        public int? IdInteressadoDespachoAtual { get; set; }
        public string? DsStatus { get; set; }
        public string? DsParecerFinal { get; set; }
        public int? NrSolicitacao { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtSolicitcao { get; set; }
        public int? ProcId { get; set; }
        public int? ProcSequencia { get; set; }
        public int? ProcAno { get; set; }

        public virtual ICollection<TbAciSolicitacaoAnexo> TbAciSolicitacaoAnexos { get; set; }
        public virtual ICollection<TbAciSolicitacaoDespacho> TbAciSolicitacaoDespachos { get; set; }
    }
}
