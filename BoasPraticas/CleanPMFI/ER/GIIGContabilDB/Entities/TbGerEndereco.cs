using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerEndereco
{
    public int Idendereco { get; set; }

    public int? Idcidade { get; set; }

    public int? Idbairro { get; set; }

    public int? Idlogradouro { get; set; }

    public string? DsCep { get; set; }

    public virtual TbGerBairro? IdbairroNavigation { get; set; }

    public virtual TbGerCidade? IdcidadeNavigation { get; set; }

    public virtual TbGerLogradouro? IdlogradouroNavigation { get; set; }

    public virtual ICollection<TbGerEmpresasGoverno> TbGerEmpresasGovernos { get; set; } = new List<TbGerEmpresasGoverno>();

    public virtual ICollection<TbGerPessoa> TbGerPessoas { get; set; } = new List<TbGerPessoa>();

    public virtual ICollection<TbLicLocai> TbLicLocais { get; set; } = new List<TbLicLocai>();
}
