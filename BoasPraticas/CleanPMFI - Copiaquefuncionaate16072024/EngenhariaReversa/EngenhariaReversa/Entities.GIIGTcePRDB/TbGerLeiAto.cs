using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerLeiAto
    {
        public TbGerLeiAto()
        {
            TbDivLancamentoAtualizacaoCreditoEstornos = new HashSet<TbDivLancamentoAtualizacaoCreditoEstorno>();
            TbDivLancamentoAtualizacaoMonetariaCreditos = new HashSet<TbDivLancamentoAtualizacaoMonetariaCredito>();
            TbDivLancamentoCreditoEstornos = new HashSet<TbDivLancamentoCreditoEstorno>();
            TbDivLancamentoCreditos = new HashSet<TbDivLancamentoCredito>();
            TbDivLancamentoDeducaoCreditoEstornos = new HashSet<TbDivLancamentoDeducaoCreditoEstorno>();
            TbDivLancamentoDeducaoCreditos = new HashSet<TbDivLancamentoDeducaoCredito>();
            TbGerPublicacaoOrgaoOficials = new HashSet<TbGerPublicacaoOrgaoOficial>();
        }

        public int IdLeiAto { get; set; }
        public short? IdEmpresa { get; set; }
        public int? CdControleLeiAto { get; set; }
        public short? IdPessoaOrigem { get; set; }
        public short? IdTipoDocumento { get; set; }
        public short? IdEscopo { get; set; }
        public DateTime? DtLeiAto { get; set; }
        public int? NrLeiAto { get; set; }
        public short? NrAnoLeiAto { get; set; }
        public int? CdControleDocumento { get; set; }
        public short? NrAnoInicialAplicacao { get; set; }
        public string? FlSituacao { get; set; }
        public string? DsLeiAto { get; set; }
        public DateTime? DtReferenciaTce { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public bool? FlImpotaTce { get; set; }

        public virtual TbGerEscopo? IdEscopoNavigation { get; set; }
        public virtual TbGerTipoDocumentoLeiAto? IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<TbDivLancamentoAtualizacaoCreditoEstorno> TbDivLancamentoAtualizacaoCreditoEstornos { get; set; }
        public virtual ICollection<TbDivLancamentoAtualizacaoMonetariaCredito> TbDivLancamentoAtualizacaoMonetariaCreditos { get; set; }
        public virtual ICollection<TbDivLancamentoCreditoEstorno> TbDivLancamentoCreditoEstornos { get; set; }
        public virtual ICollection<TbDivLancamentoCredito> TbDivLancamentoCreditos { get; set; }
        public virtual ICollection<TbDivLancamentoDeducaoCreditoEstorno> TbDivLancamentoDeducaoCreditoEstornos { get; set; }
        public virtual ICollection<TbDivLancamentoDeducaoCredito> TbDivLancamentoDeducaoCreditos { get; set; }
        public virtual ICollection<TbGerPublicacaoOrgaoOficial> TbGerPublicacaoOrgaoOficials { get; set; }
    }
}
