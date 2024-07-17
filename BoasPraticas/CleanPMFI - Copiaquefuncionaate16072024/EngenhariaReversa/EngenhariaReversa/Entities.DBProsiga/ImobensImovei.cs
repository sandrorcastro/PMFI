using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ImobensImovei
    {
        public ImobensImovei()
        {
            BaixaImoveisImobens = new HashSet<BaixaImoveisImoben>();
            ContratoConcessaos = new HashSet<ContratoConcessao>();
            GrupoImobensDepuDespesas = new HashSet<GrupoImobensDepuDespesa>();
            GrupoImobensMovimentos = new HashSet<GrupoImobensMovimento>();
            GrupoImoveisContribuintes = new HashSet<GrupoImoveisContribuinte>();
            TbDeprecicaoValorizacaos = new HashSet<TbDeprecicaoValorizacao>();
            TbImoInvasaos = new HashSet<TbImoInvasao>();
            TbImoObras = new HashSet<TbImoObra>();
        }

        public string ImoCnpjfilial { get; set; } = null!;
        public string ImoInscricao { get; set; } = null!;
        public int? ImoIdLoteamento { get; set; }
        public decimal? ImoAreaTotal { get; set; }
        public string? ImoNumMatricula { get; set; }
        public long? ImoRegImoveis { get; set; }
        public string? ImoTipoArea { get; set; }
        public string? ImoObservacao { get; set; }
        public byte[]? ImoImgImovel { get; set; }
        public long? ImoTpImoId { get; set; }
        public DateTime? ImoDtIncorporacao { get; set; }
        public decimal? ImoValor { get; set; }
        public string? ImoLogradouro { get; set; }
        public int? ImoNumero { get; set; }
        public string? ImoComplemento { get; set; }
        public string? ImoCep { get; set; }
        public string? ImoDescricao { get; set; }
        public int? ImoModAid { get; set; }
        public string? ImoEstCons { get; set; }
        public decimal? ImoVlrAtual { get; set; }
        public int? ImoTipoAreaIdtipoArea { get; set; }
        public short? ImoNrAnoLic { get; set; }
        public short? ImoNrLicitacao { get; set; }
        public short? ImoIdModalidade { get; set; }
        public string? ImoCdTombamento { get; set; }
        public short? ImoIdTipoBens { get; set; }

        public virtual Loteamento? ImoIdLoteamentoNavigation { get; set; }
        public virtual ModoAquisicao? ImoModA { get; set; }
        public virtual TbImoTipoArea? ImoTipoAreaIdtipoAreaNavigation { get; set; }
        public virtual TipoImovel? ImoTpImo { get; set; }
        public virtual ICollection<BaixaImoveisImoben> BaixaImoveisImobens { get; set; }
        public virtual ICollection<ContratoConcessao> ContratoConcessaos { get; set; }
        public virtual ICollection<GrupoImobensDepuDespesa> GrupoImobensDepuDespesas { get; set; }
        public virtual ICollection<GrupoImobensMovimento> GrupoImobensMovimentos { get; set; }
        public virtual ICollection<GrupoImoveisContribuinte> GrupoImoveisContribuintes { get; set; }
        public virtual ICollection<TbDeprecicaoValorizacao> TbDeprecicaoValorizacaos { get; set; }
        public virtual ICollection<TbImoInvasao> TbImoInvasaos { get; set; }
        public virtual ICollection<TbImoObra> TbImoObras { get; set; }
    }
}
