using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerCidade
    {
        public TbGerCidade()
        {
            TbDspDiaria = new HashSet<TbDspDiaria>();
            TbGerAgencia = new HashSet<TbGerAgencia>();
            TbGerEnderecos = new HashSet<TbGerEndereco>();
        }

        public int Idcidade { get; set; }
        public string? NmCidade { get; set; }
        public string? DsUf { get; set; }
        public int? Idpais { get; set; }
        public int? CdIbge { get; set; }

        public virtual TbGerPaise? IdpaisNavigation { get; set; }
        public virtual ICollection<TbDspDiaria> TbDspDiaria { get; set; }
        public virtual ICollection<TbGerAgencia> TbGerAgencia { get; set; }
        public virtual ICollection<TbGerEndereco> TbGerEnderecos { get; set; }
    }
}
