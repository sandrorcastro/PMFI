using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AgeNotNoticia
    {
        public AgeNotNoticia()
        {
            AgeNotNoticiaAnexos = new HashSet<AgeNotNoticiaAnexo>();
        }

        public int Idnoticia { get; set; }
        public DateTime? DataHora { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Link { get; set; }
        public string? Situacao { get; set; }
        public int? TemaId { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public int? Acessos { get; set; }

        public virtual AgeNotTema? Tema { get; set; }
        public virtual ICollection<AgeNotNoticiaAnexo> AgeNotNoticiaAnexos { get; set; }
    }
}
