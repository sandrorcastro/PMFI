using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapAditivosConvenio
    {
        public TbCapAditivosConvenio()
        {
            TbCapCancelamentosAditivosConvenios = new HashSet<TbCapCancelamentosAditivosConvenio>();
        }

        public int IdAditivo { get; set; }
        public int IdRecurso { get; set; }
        public int? NrAditivo { get; set; }
        public short? NrAnoAditivo { get; set; }
        public short? IdTipoAditivo { get; set; }
        public int? NrTermoAditivo { get; set; }
        public DateTime? DtTermoAditivo { get; set; }
        public DateTime? DtFimVigencia { get; set; }
        public int? NrDiarioOficial { get; set; }
        public short? NrAnoDiarioOficial { get; set; }
        public DateTime? DtPublicacaoDiario { get; set; }
        public int? IdOrgaoOficial { get; set; }
        public decimal? VlAditivo { get; set; }
        public decimal? VlContraPartidaAditivo { get; set; }
        public decimal? VlConcedente { get; set; }
        public decimal? VlContrapartida { get; set; }
        public string? DsAditivo { get; set; }
        public DateTime? DtBaseTce { get; set; }

        public virtual TbCapConvAuxPrograma IdRecursoNavigation { get; set; } = null!;
        public virtual TbCapTiposAditivo? IdTipoAditivoNavigation { get; set; }
        public virtual ICollection<TbCapCancelamentosAditivosConvenio> TbCapCancelamentosAditivosConvenios { get; set; }
    }
}
