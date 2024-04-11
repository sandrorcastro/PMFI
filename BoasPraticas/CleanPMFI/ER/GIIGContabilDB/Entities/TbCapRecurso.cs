using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCapRecurso
{
    public int IdRecurso { get; set; }

    public string? DsRecurso { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdFonte { get; set; }

    public int? IdOrgaoRepassador { get; set; }

    public string? DsOrgaoCedente { get; set; }

    public string? DsTipoRecurso { get; set; }

    public string? CdContaContabilConsignar { get; set; }

    public string? DsSigla { get; set; }

    public bool? FlInativo { get; set; }

    public DateTime? DtBaseTce { get; set; }

    public string? FlUsaObn { get; set; }

    public virtual TbCapOrgaosRepassador? IdOrgaoRepassadorNavigation { get; set; }

    public virtual TbCapConvAuxPrograma? TbCapConvAuxPrograma { get; set; }

    public virtual ICollection<TbCapRecursosContasCorrente> TbCapRecursosContasCorrentes { get; set; } = new List<TbCapRecursosContasCorrente>();

    public virtual ICollection<TbCapRecursosOrgaoUnidade> TbCapRecursosOrgaoUnidades { get; set; } = new List<TbCapRecursosOrgaoUnidade>();

    public virtual ICollection<TbCapRecursosSaldosAnteriore> TbCapRecursosSaldosAnteriores { get; set; } = new List<TbCapRecursosSaldosAnteriore>();

    public virtual ICollection<TbCntApostilamentoRecurso> TbCntApostilamentoRecursos { get; set; } = new List<TbCntApostilamentoRecurso>();

    public virtual ICollection<TbCntContratosRecurso> TbCntContratosRecursos { get; set; } = new List<TbCntContratosRecurso>();

    public virtual ICollection<TbDspConsignaco> TbDspConsignacos { get; set; } = new List<TbDspConsignaco>();

    public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; } = new List<TbDspEmpenho>();

    public virtual ICollection<TbLicRecurso> TbLicRecursos { get; set; } = new List<TbLicRecurso>();

    public virtual ICollection<TbRecMovimentoReceita> TbRecMovimentoReceita { get; set; } = new List<TbRecMovimentoReceita>();
}
