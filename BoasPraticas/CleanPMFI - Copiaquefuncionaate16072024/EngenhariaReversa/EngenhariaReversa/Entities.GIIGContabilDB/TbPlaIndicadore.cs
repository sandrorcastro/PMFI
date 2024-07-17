using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaIndicadore
    {
        public TbPlaIndicadore()
        {
            TbPlaIndicadoresAvaliacoesAnos = new HashSet<TbPlaIndicadoresAvaliacoesAno>();
            TbPlaIndicadoresMovimentos = new HashSet<TbPlaIndicadoresMovimento>();
            TbPlaIndicadoresObjetivoMilenioAvaliacaos = new HashSet<TbPlaIndicadoresObjetivoMilenioAvaliacao>();
            TbPlaProgramaIndicadors = new HashSet<TbPlaProgramaIndicador>();
            TbPlaProgramasObjetivosMeta = new HashSet<TbPlaProgramasObjetivosMeta>();
        }

        public int IdIndicador { get; set; }
        public short? IdEscopo { get; set; }
        public string? CdIndicador { get; set; }
        public int? IdVersaoCriacao { get; set; }
        public int? IdMovimento { get; set; }
        public string? TpComando { get; set; }

        public virtual TbPlaEscopo? IdEscopoNavigation { get; set; }
        public virtual TbPlaVerso? IdVersaoCriacaoNavigation { get; set; }
        public virtual ICollection<TbPlaIndicadoresAvaliacoesAno> TbPlaIndicadoresAvaliacoesAnos { get; set; }
        public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; }
        public virtual ICollection<TbPlaIndicadoresObjetivoMilenioAvaliacao> TbPlaIndicadoresObjetivoMilenioAvaliacaos { get; set; }
        public virtual ICollection<TbPlaProgramaIndicador> TbPlaProgramaIndicadors { get; set; }
        public virtual ICollection<TbPlaProgramasObjetivosMeta> TbPlaProgramasObjetivosMeta { get; set; }
    }
}
