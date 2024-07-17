using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeEstoque
    {
        public SaudeEstoque()
        {
            SaudeFarmaSaldoInicials = new HashSet<SaudeFarmaSaldoInicial>();
            Usus = new HashSet<Usuario>();
        }

        public int IdEstoque { get; set; }
        public string? NomeEstoque { get; set; }
        public string? EmailResponsavel { get; set; }
        public int? IdSetor { get; set; }
        public int? IdUnidadeSaudeSetor { get; set; }

        public virtual ICollection<SaudeFarmaSaldoInicial> SaudeFarmaSaldoInicials { get; set; }

        public virtual ICollection<Usuario> Usus { get; set; }
    }
}
