using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerContasCorrente
    {
        public TbGerContasCorrente()
        {
            TbCapRecursosContasCorrentes = new HashSet<TbCapRecursosContasCorrente>();
            TbDspOrdensPagamentos = new HashSet<TbDspOrdensPagamento>();
            TbFinConciliacoesBancaria = new HashSet<TbFinConciliacoesBancaria>();
            TbFinContasContabeisContasCorrentes = new HashSet<TbFinContasContabeisContasCorrente>();
            TbFinOrdensCreditos = new HashSet<TbFinOrdensCredito>();
            TbFinOrdensCreditosDetalhes = new HashSet<TbFinOrdensCreditosDetalhe>();
            TbFinSaldosMensaisContasCorrentes = new HashSet<TbFinSaldosMensaisContasCorrente>();
            TbGerContasCorrOrgaosUnidades = new HashSet<TbGerContasCorrOrgaosUnidade>();
            TbGerContasCorrenteBaixas = new HashSet<TbGerContasCorrenteBaixa>();
            TbGerContasCorrentesResponsaveis = new HashSet<TbGerContasCorrentesResponsavei>();
            TbGerContasCorrentesVinculos = new HashSet<TbGerContasCorrentesVinculo>();
            TbSbsSubvencaoSocialCompls = new HashSet<TbSbsSubvencaoSocialCompl>();
        }

        public int IdCc { get; set; }
        public string? NrCc { get; set; }
        public string? NrDv { get; set; }
        public int? IdAgencia { get; set; }
        public string? NmCc { get; set; }
        public string? FlVinculada { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdPessoa { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtDesativacao { get; set; }
        public string? NrCctc { get; set; }
        public short? IdEmpresaExecutora { get; set; }
        public string? CdConvenio { get; set; }
        public string? DsTipo { get; set; }
        public string? FlTransferencia { get; set; }
        public int? IdTitularContaCorrente { get; set; }
        public short? IdTipoContaBancaria { get; set; }
        public string? DsMotivoDesativacao { get; set; }
        public string? FlContaConvenio { get; set; }
        public string? CdConvenioOc { get; set; }
        public string? NrCpfFavorecido { get; set; }
        public string? FlTransferenciaDiversa { get; set; }
        public string? FlTipoOrdemBancaria { get; set; }
        public string? FlContaPadraoPag { get; set; }
        public int? IdContaBacen { get; set; }

        public virtual TbGerAgencia? IdAgenciaNavigation { get; set; }
        public virtual TbGerTiposContaBancarium? IdTipoContaBancariaNavigation { get; set; }
        public virtual ICollection<TbCapRecursosContasCorrente> TbCapRecursosContasCorrentes { get; set; }
        public virtual ICollection<TbDspOrdensPagamento> TbDspOrdensPagamentos { get; set; }
        public virtual ICollection<TbFinConciliacoesBancaria> TbFinConciliacoesBancaria { get; set; }
        public virtual ICollection<TbFinContasContabeisContasCorrente> TbFinContasContabeisContasCorrentes { get; set; }
        public virtual ICollection<TbFinOrdensCredito> TbFinOrdensCreditos { get; set; }
        public virtual ICollection<TbFinOrdensCreditosDetalhe> TbFinOrdensCreditosDetalhes { get; set; }
        public virtual ICollection<TbFinSaldosMensaisContasCorrente> TbFinSaldosMensaisContasCorrentes { get; set; }
        public virtual ICollection<TbGerContasCorrOrgaosUnidade> TbGerContasCorrOrgaosUnidades { get; set; }
        public virtual ICollection<TbGerContasCorrenteBaixa> TbGerContasCorrenteBaixas { get; set; }
        public virtual ICollection<TbGerContasCorrentesResponsavei> TbGerContasCorrentesResponsaveis { get; set; }
        public virtual ICollection<TbGerContasCorrentesVinculo> TbGerContasCorrentesVinculos { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocialCompl> TbSbsSubvencaoSocialCompls { get; set; }
    }
}
