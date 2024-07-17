using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaAco
    {
        public TbPlaAco()
        {
            TbPlaAcao2012s = new HashSet<TbPlaAcao2012>();
            TbPlaAcoesAvaliacoesAnos = new HashSet<TbPlaAcoesAvaliacoesAno>();
            TbPlaAcoesCorrelacaoIdAcaoCorrelacaoNavigations = new HashSet<TbPlaAcoesCorrelacao>();
            TbPlaAcoesCorrelacaoIdAcaoNavigations = new HashSet<TbPlaAcoesCorrelacao>();
            TbPlaAcoesMeta = new HashSet<TbPlaAcoesMeta>();
            TbPlaAcoesProgramas = new HashSet<TbPlaAcoesPrograma>();
            TbPlaAcoesSemCorrelacaos = new HashSet<TbPlaAcoesSemCorrelacao>();
            TbPlaProjetosAtividadesAcos = new HashSet<TbPlaProjetosAtividadesAco>();
            IdLicitacaos = new HashSet<TbLicLicitaco>();
        }

        public int IdAcao { get; set; }
        public short? IdEscopo { get; set; }
        public string CdAcao { get; set; } = null!;
        public int? IdVersaoCriacao { get; set; }
        public int? IdMovimento { get; set; }
        public string? TpComando { get; set; }
        public string? NmAcao { get; set; }

        public virtual ICollection<TbPlaAcao2012> TbPlaAcao2012s { get; set; }
        public virtual ICollection<TbPlaAcoesAvaliacoesAno> TbPlaAcoesAvaliacoesAnos { get; set; }
        public virtual ICollection<TbPlaAcoesCorrelacao> TbPlaAcoesCorrelacaoIdAcaoCorrelacaoNavigations { get; set; }
        public virtual ICollection<TbPlaAcoesCorrelacao> TbPlaAcoesCorrelacaoIdAcaoNavigations { get; set; }
        public virtual ICollection<TbPlaAcoesMeta> TbPlaAcoesMeta { get; set; }
        public virtual ICollection<TbPlaAcoesPrograma> TbPlaAcoesProgramas { get; set; }
        public virtual ICollection<TbPlaAcoesSemCorrelacao> TbPlaAcoesSemCorrelacaos { get; set; }
        public virtual ICollection<TbPlaProjetosAtividadesAco> TbPlaProjetosAtividadesAcos { get; set; }

        public virtual ICollection<TbLicLicitaco> IdLicitacaos { get; set; }
    }
}
