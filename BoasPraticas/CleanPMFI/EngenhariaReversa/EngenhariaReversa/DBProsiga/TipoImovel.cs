using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TipoImovel
    {
        public TipoImovel()
        {
            ImobensImoveis = new HashSet<ImobensImovei>();
            Imoveis = new HashSet<Imovei>();
        }

        public long TpImovelId { get; set; }
        public string TpImovelDesc { get; set; } = null!;

        public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; }
        public virtual ICollection<Imovei> Imoveis { get; set; }
    }
}
