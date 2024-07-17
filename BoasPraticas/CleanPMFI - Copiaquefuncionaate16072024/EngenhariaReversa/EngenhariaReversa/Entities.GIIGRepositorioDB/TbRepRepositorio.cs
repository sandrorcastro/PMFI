using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGRepositorioDB
{
    public partial class TbRepRepositorio
    {
        public TbRepRepositorio()
        {
            TbRepDadosArquivos = new HashSet<TbRepDadosArquivo>();
        }

        public int IdRepositorio { get; set; }
        public string? NrChave { get; set; }
        public string? DsRepositorio { get; set; }
        public string? NmRepositorio { get; set; }

        public virtual ICollection<TbRepDadosArquivo> TbRepDadosArquivos { get; set; }
    }
}
