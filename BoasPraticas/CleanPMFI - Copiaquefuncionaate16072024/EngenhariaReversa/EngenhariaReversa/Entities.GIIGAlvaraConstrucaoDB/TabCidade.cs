using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGAlvaraConstrucaoDB
{
    public partial class TabCidade
    {
        public TabCidade()
        {
            TabPessoas = new HashSet<TabPessoa>();
        }

        public int CidaId { get; set; }
        public string? CidaNome { get; set; }
        public string? CidaUf { get; set; }

        public virtual ICollection<TabPessoa> TabPessoas { get; set; }
    }
}
