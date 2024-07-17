using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribHonorariosDivida
    {
        public TribHonorariosDivida()
        {
            TribHonorariosCda = new HashSet<TribHonorariosCdum>();
            TribHonorariosSemCda = new HashSet<TribHonorariosSemCdum>();
        }

        public int HonorarioDivId { get; set; }
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }
        public int? HonorarioId { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? DivEmp { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual ICollection<TribHonorariosCdum> TribHonorariosCda { get; set; }
        public virtual ICollection<TribHonorariosSemCdum> TribHonorariosSemCda { get; set; }
    }
}
