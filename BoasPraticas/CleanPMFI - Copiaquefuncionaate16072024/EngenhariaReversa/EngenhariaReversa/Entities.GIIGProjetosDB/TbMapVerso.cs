using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbMapVerso
    {
        public TbMapVerso()
        {
            TbMapObjetivosGlobais = new HashSet<TbMapObjetivosGlobai>();
            TbMapVersoesValores = new HashSet<TbMapVersoesValore>();
            TbPrjCriterios = new HashSet<TbPrjCriterio>();
            TbPrjEscalas = new HashSet<TbPrjEscala>();
            TbPrjProjetos = new HashSet<TbPrjProjeto>();
        }

        public int IdVersao { get; set; }
        public short? NrAnoElaboracao { get; set; }
        public short? NrAnoInicio { get; set; }
        public short? NrAnoFim { get; set; }
        public short? NrVersao { get; set; }
        public string? DsStatus { get; set; }
        public string? DsMissao { get; set; }
        public string? DsVisao { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbMapObjetivosGlobai> TbMapObjetivosGlobais { get; set; }
        public virtual ICollection<TbMapVersoesValore> TbMapVersoesValores { get; set; }
        public virtual ICollection<TbPrjCriterio> TbPrjCriterios { get; set; }
        public virtual ICollection<TbPrjEscala> TbPrjEscalas { get; set; }
        public virtual ICollection<TbPrjProjeto> TbPrjProjetos { get; set; }
    }
}
