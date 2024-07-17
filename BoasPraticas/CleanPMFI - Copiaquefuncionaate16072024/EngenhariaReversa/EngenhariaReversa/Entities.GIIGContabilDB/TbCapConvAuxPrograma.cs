using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapConvAuxPrograma
    {
        public TbCapConvAuxPrograma()
        {
            TbCapAditivosConvenios = new HashSet<TbCapAditivosConvenio>();
            TbCapConvAuxProgramasConta = new HashSet<TbCapConvAuxProgramasConta>();
            TbCapConvAuxProgramasRepasses = new HashSet<TbCapConvAuxProgramasRepass>();
            TbCapConvAuxProgramasSituacos = new HashSet<TbCapConvAuxProgramasSituaco>();
            TbCapExecucaoAntecipada = new HashSet<TbCapExecucaoAntecipadum>();
        }

        public int IdRecurso { get; set; }
        public int? NrTransferencia { get; set; }
        public int? NrConvenio { get; set; }
        public short? NrAnoConvenio { get; set; }
        public int? CdCap { get; set; }
        public string? DsTipoRecurso { get; set; }
        public string? NrTermo { get; set; }
        public DateTime? DtCelebracaoTermo { get; set; }
        public DateTime? DtTerminoVigencia { get; set; }
        public int? NrDoe { get; set; }
        public short? NrAnoPublicacaoDoe { get; set; }
        public DateTime? DtPublicacaoDoe { get; set; }
        public decimal? VlPrevisto { get; set; }
        public decimal? VlContraPartida { get; set; }
        public decimal? VlMetaPrevista { get; set; }
        public short? IdUnidadeMedida { get; set; }
        public DateTime? DtEvento { get; set; }
        public string? DsObjeto { get; set; }
        public string? DsTipoRecursoRepassador { get; set; }
        public DateTime? DtInicioVigencia { get; set; }
        public long? IdDividaFundada { get; set; }
        public int? IdOrgaoOficial { get; set; }
        public string? FlPublicacaoDiario { get; set; }
        public DateTime? DtBaseTce { get; set; }

        public virtual TbGerOrgaoOficialPublicacao? IdOrgaoOficialNavigation { get; set; }
        public virtual TbCapRecurso IdRecursoNavigation { get; set; } = null!;
        public virtual TbPlaUnidadesMedidum? IdUnidadeMedidaNavigation { get; set; }
        public virtual ICollection<TbCapAditivosConvenio> TbCapAditivosConvenios { get; set; }
        public virtual ICollection<TbCapConvAuxProgramasConta> TbCapConvAuxProgramasConta { get; set; }
        public virtual ICollection<TbCapConvAuxProgramasRepass> TbCapConvAuxProgramasRepasses { get; set; }
        public virtual ICollection<TbCapConvAuxProgramasSituaco> TbCapConvAuxProgramasSituacos { get; set; }
        public virtual ICollection<TbCapExecucaoAntecipadum> TbCapExecucaoAntecipada { get; set; }
    }
}
