using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaObjetivosMilenio
    {
        public TbPlaObjetivosMilenio()
        {
            TbPlaIndicadoresObjetivoMilenioAvaliacaos = new HashSet<TbPlaIndicadoresObjetivoMilenioAvaliacao>();
            TbPlaMacroObjetivos = new HashSet<TbPlaMacroObjetivo>();
            TbPlaObjetivosMilenioAvaliacaos = new HashSet<TbPlaObjetivosMilenioAvaliacao>();
            TbPlaObjetivosMilenioMedidasEsperada = new HashSet<TbPlaObjetivosMilenioMedidasEsperada>();
            IdMovimentos = new HashSet<TbPlaAcoesMovimento>();
        }

        public short IdObjetivoMilenio { get; set; }
        public string? DsObjetivoMilenio { get; set; }

        public virtual ICollection<TbPlaIndicadoresObjetivoMilenioAvaliacao> TbPlaIndicadoresObjetivoMilenioAvaliacaos { get; set; }
        public virtual ICollection<TbPlaMacroObjetivo> TbPlaMacroObjetivos { get; set; }
        public virtual ICollection<TbPlaObjetivosMilenioAvaliacao> TbPlaObjetivosMilenioAvaliacaos { get; set; }
        public virtual ICollection<TbPlaObjetivosMilenioMedidasEsperada> TbPlaObjetivosMilenioMedidasEsperada { get; set; }

        public virtual ICollection<TbPlaAcoesMovimento> IdMovimentos { get; set; }
    }
}
