using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblVideo
    {
        public short Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Arqnome { get; set; }
        public string? Arqtipo { get; set; }
        public string? Arqbin { get; set; }
        public int? Arqseq { get; set; }
    }
}
