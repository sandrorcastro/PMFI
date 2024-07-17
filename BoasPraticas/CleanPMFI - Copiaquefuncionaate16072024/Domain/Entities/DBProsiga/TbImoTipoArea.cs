using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbImoTipoArea
    {
        public TbImoTipoArea()
        {
            ImobensImoveis = new HashSet<ImobensImovei>();
        }

        public int IdtipoArea { get; set; }
        public string DsTipoArea { get; set; } = null!;
        public short CdTipoConta { get; set; }

        public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; }
    }
}
