using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerContasCorrente
{
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

    public virtual ICollection<TbCapRecursosContasCorrente> TbCapRecursosContasCorrentes { get; set; } = new List<TbCapRecursosContasCorrente>();

    public virtual ICollection<TbDspOrdensPagamento> TbDspOrdensPagamentos { get; set; } = new List<TbDspOrdensPagamento>();

    public virtual ICollection<TbFinConciliacoesBancaria> TbFinConciliacoesBancaria { get; set; } = new List<TbFinConciliacoesBancaria>();

    public virtual ICollection<TbFinContasContabeisContasCorrente> TbFinContasContabeisContasCorrentes { get; set; } = new List<TbFinContasContabeisContasCorrente>();

    public virtual ICollection<TbFinOrdensCredito> TbFinOrdensCreditos { get; set; } = new List<TbFinOrdensCredito>();

    public virtual ICollection<TbFinOrdensCreditosDetalhe> TbFinOrdensCreditosDetalhes { get; set; } = new List<TbFinOrdensCreditosDetalhe>();

    public virtual ICollection<TbFinSaldosMensaisContasCorrente> TbFinSaldosMensaisContasCorrentes { get; set; } = new List<TbFinSaldosMensaisContasCorrente>();

    public virtual ICollection<TbGerContasCorrOrgaosUnidade> TbGerContasCorrOrgaosUnidades { get; set; } = new List<TbGerContasCorrOrgaosUnidade>();

    public virtual ICollection<TbGerContasCorrenteBaixa> TbGerContasCorrenteBaixas { get; set; } = new List<TbGerContasCorrenteBaixa>();

    public virtual ICollection<TbGerContasCorrentesResponsavei> TbGerContasCorrentesResponsaveis { get; set; } = new List<TbGerContasCorrentesResponsavei>();

    public virtual ICollection<TbGerContasCorrentesVinculo> TbGerContasCorrentesVinculos { get; set; } = new List<TbGerContasCorrentesVinculo>();

    public virtual ICollection<TbSbsSubvencaoSocialCompl> TbSbsSubvencaoSocialCompls { get; set; } = new List<TbSbsSubvencaoSocialCompl>();
}
