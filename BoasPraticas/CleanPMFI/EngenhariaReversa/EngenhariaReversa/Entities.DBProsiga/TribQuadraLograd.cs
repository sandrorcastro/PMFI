using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribQuadraLograd
    {
        public TribQuadraLograd()
        {
            TribQuadraLogradTributos = new HashSet<TribQuadraLogradTributo>();
            TribSecaos = new HashSet<TribSecao>();
            TribZonaZoneamentoQuadraLograds = new HashSet<TribZonaZoneamentoQuadraLograd>();
            Cmprocs = new HashSet<TribCmprocesso>();
        }

        public int QuadraId { get; set; }
        public int LogradId { get; set; }
        public int? Idloteamento { get; set; }
        public long? FatorKid { get; set; }
        public long? Cep { get; set; }
        public long? SecaoLograd { get; set; }
        public string? LadoSecaoLograd { get; set; }
        public int? Setor { get; set; }
        public int? ClViId { get; set; }
        /// <summary>
        /// Faz parte da informação do sistema viário. 
        /// </summary>
        public string? Atingido { get; set; }
        /// <summary>
        /// Previsão da caixa da rua em metros, nesta quadra de acordo com o sistema viário.
        /// </summary>
        public decimal? PrevCaixaRua { get; set; }
        /// <summary>
        /// Recuo mínimo permitido para o imóvel a contar da caixa da rua de acordo com o sistema  viário.
        /// </summary>
        public decimal? RecuoMinimo { get; set; }
        public int? TiViId { get; set; }
        public decimal? VlrMetroQuadrado { get; set; }
        public int? SicoId { get; set; }
        public long? FatorKidanterior { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? CoordInicialLo { get; set; }
        public string? CoordInicialNs { get; set; }
        public string? CoordFinalLo { get; set; }
        public string? CoordFinalNs { get; set; }
        public int? OrdemQuadra { get; set; }

        public virtual TribZonaClassificacaoVium? ClVi { get; set; }
        public virtual TribFatorK? FatorK { get; set; }
        public virtual Loteamento? IdloteamentoNavigation { get; set; }
        public virtual Logradouro Lograd { get; set; } = null!;
        public virtual TribQuadra Quadra { get; set; } = null!;
        public virtual SisCore? Sico { get; set; }
        public virtual TribZonaTipoViaUrbana? TiVi { get; set; }
        public virtual ICollection<TribQuadraLogradTributo> TribQuadraLogradTributos { get; set; }
        public virtual ICollection<TribSecao> TribSecaos { get; set; }
        public virtual ICollection<TribZonaZoneamentoQuadraLograd> TribZonaZoneamentoQuadraLograds { get; set; }

        public virtual ICollection<TribCmprocesso> Cmprocs { get; set; }
    }
}
