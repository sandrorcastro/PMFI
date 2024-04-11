using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class RhdadosPessoai
{
    public string MemCnpj { get; set; } = null!;

    public long DadPmatricula { get; set; }

    public long? ConId { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual Membro MemCnpjNavigation { get; set; } = null!;

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionais { get; set; } = new List<RhdadosFuncionai>();
}
