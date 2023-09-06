using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerEndereco
    {
        public TbGerEndereco()
        {
            TbGerEmpresasGovernos = new HashSet<TbGerEmpresasGoverno>();
            TbGerPessoas = new HashSet<TbGerPessoa>();
            TbLicLocais = new HashSet<TbLicLocai>();
        }

        public int Idendereco { get; set; }
        public int? Idcidade { get; set; }
        public int? Idbairro { get; set; }
        public int? Idlogradouro { get; set; }
        public string? DsCep { get; set; }

        public virtual TbGerBairro? IdbairroNavigation { get; set; }
        public virtual TbGerCidade? IdcidadeNavigation { get; set; }
        public virtual TbGerLogradouro? IdlogradouroNavigation { get; set; }
        public virtual ICollection<TbGerEmpresasGoverno> TbGerEmpresasGovernos { get; set; }
        public virtual ICollection<TbGerPessoa> TbGerPessoas { get; set; }
        public virtual ICollection<TbLicLocai> TbLicLocais { get; set; }
    }
}
