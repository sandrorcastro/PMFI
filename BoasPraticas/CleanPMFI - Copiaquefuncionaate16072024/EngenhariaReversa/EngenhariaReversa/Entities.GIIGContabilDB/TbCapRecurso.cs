using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapRecurso
    {
        public TbCapRecurso()
        {
            TbCapRecursosContasCorrentes = new HashSet<TbCapRecursosContasCorrente>();
            TbCapRecursosOrgaoUnidades = new HashSet<TbCapRecursosOrgaoUnidade>();
            TbCapRecursosSaldosAnteriores = new HashSet<TbCapRecursosSaldosAnteriore>();
            TbCntApostilamentoRecursos = new HashSet<TbCntApostilamentoRecurso>();
            TbCntContratosRecursos = new HashSet<TbCntContratosRecurso>();
            TbDspConsignacos = new HashSet<TbDspConsignaco>();
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbLicRecursos = new HashSet<TbLicRecurso>();
            TbRecMovimentoReceita = new HashSet<TbRecMovimentoReceita>();
        }

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
        public virtual ICollection<TbCapRecursosContasCorrente> TbCapRecursosContasCorrentes { get; set; }
        public virtual ICollection<TbCapRecursosOrgaoUnidade> TbCapRecursosOrgaoUnidades { get; set; }
        public virtual ICollection<TbCapRecursosSaldosAnteriore> TbCapRecursosSaldosAnteriores { get; set; }
        public virtual ICollection<TbCntApostilamentoRecurso> TbCntApostilamentoRecursos { get; set; }
        public virtual ICollection<TbCntContratosRecurso> TbCntContratosRecursos { get; set; }
        public virtual ICollection<TbDspConsignaco> TbDspConsignacos { get; set; }
        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbLicRecurso> TbLicRecursos { get; set; }
        public virtual ICollection<TbRecMovimentoReceita> TbRecMovimentoReceita { get; set; }
    }
}
