using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class GuiaAvulsaAnexo
    {
        public int Id { get; set; }
        public long Idguia { get; set; }
        public byte[] Arqanexo { get; set; } = null!;
        public string Arqext { get; set; } = null!;

        public virtual GuiaAvulsa IdguiaNavigation { get; set; } = null!;
    }
}
