using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class _24hrsGuia
    {
        public _24hrsGuia()
        {
            _24hrsMenus = new HashSet<_24hrsMenu>();
        }

        public string Nomeguia { get; set; } = null!;
        public string? Titulopagina { get; set; }
        public string? Visivel { get; set; }
        public string? Link { get; set; }
        public byte? Ordem { get; set; }

        public virtual ICollection<_24hrsMenu> _24hrsMenus { get; set; }
    }
}
