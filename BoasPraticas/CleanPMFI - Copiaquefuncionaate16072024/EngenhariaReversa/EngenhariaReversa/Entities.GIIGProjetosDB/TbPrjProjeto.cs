using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbPrjProjeto
    {
        public TbPrjProjeto()
        {
            TbAvaProjetosCriterios = new HashSet<TbAvaProjetosCriterio>();
            TbAvaProjetosStatuses = new HashSet<TbAvaProjetosStatus>();
        }

        public int IdProjeto { get; set; }
        public int IdVersao { get; set; }
        public int? IdObjetivo { get; set; }
        public int? CdProjeto { get; set; }
        public string? NmProjeto { get; set; }
        public string? DsEscopo { get; set; }
        public string? DsMetas { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public decimal? VlOrcado { get; set; }
        public string? DsTaxaInternaRetorno { get; set; }
        public short? NrAnoElaboracao { get; set; }
        public string? CdOrgaoResponsavel { get; set; }
        public string? CdUnidadeResposavel { get; set; }
        public string? DsFase { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbMapObjetivo? IdObjetivoNavigation { get; set; }
        public virtual TbMapVerso IdVersaoNavigation { get; set; } = null!;
        public virtual ICollection<TbAvaProjetosCriterio> TbAvaProjetosCriterios { get; set; }
        public virtual ICollection<TbAvaProjetosStatus> TbAvaProjetosStatuses { get; set; }
    }
}
