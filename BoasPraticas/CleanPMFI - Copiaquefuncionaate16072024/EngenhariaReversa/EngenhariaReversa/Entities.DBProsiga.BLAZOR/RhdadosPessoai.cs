using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class RhdadosPessoai
    {
        public RhdadosPessoai()
        {
            RhdadosFuncionais = new HashSet<RhdadosFuncionai>();
        }

        public string MemCnpj { get; set; } = null!;
        public long DadPmatricula { get; set; }
        public long? ConId { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual Membro MemCnpjNavigation { get; set; } = null!;
        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionais { get; set; }
    }
}
