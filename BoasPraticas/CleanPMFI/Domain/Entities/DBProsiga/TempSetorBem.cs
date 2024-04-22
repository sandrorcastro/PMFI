using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TempSetorBem
    {
        public TempSetorBem()
        {
            TempCadBems = new HashSet<TempCadBem>();
        }

        public int CodSetor { get; set; }
        public string? NomeSetor { get; set; }

        public virtual ICollection<TempCadBem> TempCadBems { get; set; }
    }
}
