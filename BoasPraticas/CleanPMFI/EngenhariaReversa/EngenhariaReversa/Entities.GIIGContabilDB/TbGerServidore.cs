using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerServidore
    {
        public TbGerServidore()
        {
            TbCtiSetoresServidores = new HashSet<TbCtiSetoresServidore>();
            TbGerCargosServidores = new HashSet<TbGerCargosServidore>();
            TbParAssinaturasDocumentos = new HashSet<TbParAssinaturasDocumento>();
        }

        public int IdServidor { get; set; }
        public short? IdEmpresa { get; set; }
        public string? NmServidor { get; set; }
        public string? DsTipoDoc { get; set; }
        public string? NrRgCpf { get; set; }
        public string? DsMatricula { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtDesativacao { get; set; }
        public string? NrRegProfissional { get; set; }
        public int? IdPessoa { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbCtiSetoresServidore> TbCtiSetoresServidores { get; set; }
        public virtual ICollection<TbGerCargosServidore> TbGerCargosServidores { get; set; }
        public virtual ICollection<TbParAssinaturasDocumento> TbParAssinaturasDocumentos { get; set; }
    }
}
