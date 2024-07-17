using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabAssunto
    {
        public TabAssunto()
        {
            TabCapas = new HashSet<TabCapa>();
            TabDocumentoTipoAssuntos = new HashSet<TabDocumentoTipoAssunto>();
            TabModeloAssuntos = new HashSet<TabModeloAssunto>();
            TabProcessos = new HashSet<TabProcesso>();
            TabRoteiros = new HashSet<TabRoteiro>();
            TabUsuarioAssuntos = new HashSet<TabUsuarioAssunto>();
            Atris = new HashSet<TabAtributo>();
        }

        public short AssuId { get; set; }
        public string? AssuNome { get; set; }
        public string? AssuDescricao { get; set; }
        public string? AssuFlUsaPortal { get; set; }
        public string AssuFlAtivo { get; set; } = null!;
        public short? UnidIdPadrao { get; set; }
        public int? Idsubgrupo { get; set; }
        /// <summary>
        /// Extensões adicionais que podem ser enviadas além de PDF para este assunto.
        /// </summary>
        public string? Dsextensaoadicional { get; set; }

        public virtual ICollection<TabCapa> TabCapas { get; set; }
        public virtual ICollection<TabDocumentoTipoAssunto> TabDocumentoTipoAssuntos { get; set; }
        public virtual ICollection<TabModeloAssunto> TabModeloAssuntos { get; set; }
        public virtual ICollection<TabProcesso> TabProcessos { get; set; }
        public virtual ICollection<TabRoteiro> TabRoteiros { get; set; }
        public virtual ICollection<TabUsuarioAssunto> TabUsuarioAssuntos { get; set; }

        public virtual ICollection<TabAtributo> Atris { get; set; }
    }
}
