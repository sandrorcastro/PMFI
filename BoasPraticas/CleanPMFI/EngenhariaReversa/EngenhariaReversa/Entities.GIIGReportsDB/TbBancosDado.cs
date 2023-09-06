using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbBancosDado
    {
        public TbBancosDado()
        {
            TbPermissos = new HashSet<TbPermisso>();
            TbTabelas = new HashSet<TbTabela>();
        }

        public int IdBancoDados { get; set; }
        public string? NmBancoDados { get; set; }
        public string? NmAmigavel { get; set; }
        public string? DsServidor { get; set; }
        public string? DsUsuario { get; set; }
        public string? DsSenha { get; set; }
        public string? DsConnectionString { get; set; }
        public string? TpBancoDados { get; set; }

        public virtual ICollection<TbPermisso> TbPermissos { get; set; }
        public virtual ICollection<TbTabela> TbTabelas { get; set; }
    }
}
