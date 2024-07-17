using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribItbiex
    {
        public TribItbiex()
        {
            TribAmostraMercadoItbis = new HashSet<TribAmostraMercadoItbi>();
            TribItbiexAnexos = new HashSet<TribItbiexAnexo>();
            TribItbiexAvaliacaos = new HashSet<TribItbiexAvaliacao>();
            TribItbiexEdifs = new HashSet<TribItbiexEdif>();
        }

        public long Itbiid { get; set; }
        public DateTime? ItbidataLanc { get; set; }
        public string? Itbiobservacao { get; set; }
        public string Itbisituacao { get; set; } = null!;
        public string? Itbiusuario { get; set; }
        public long? Itbiidreal { get; set; }
        public long? ConId { get; set; }
        public string? Itbiip { get; set; }
        public string ItbidsTipo { get; set; } = null!;

        public virtual ICollection<TribAmostraMercadoItbi> TribAmostraMercadoItbis { get; set; }
        public virtual ICollection<TribItbiexAnexo> TribItbiexAnexos { get; set; }
        public virtual ICollection<TribItbiexAvaliacao> TribItbiexAvaliacaos { get; set; }
        public virtual ICollection<TribItbiexEdif> TribItbiexEdifs { get; set; }
    }
}
