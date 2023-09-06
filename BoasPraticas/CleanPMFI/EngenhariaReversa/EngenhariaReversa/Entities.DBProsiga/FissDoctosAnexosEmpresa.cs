using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FissDoctosAnexosEmpresa
    {
        public long Idanexo { get; set; }
        public long EmprCmc { get; set; }
        public string? TipoAnexo { get; set; }
        public DateTime? DataAnexo { get; set; }
        public string? DescricaoAnexo { get; set; }
        public int? DocId { get; set; }
        public byte[]? ObjetoAnexo { get; set; }
        public string? Extensao { get; set; }

        public virtual Documento? Doc { get; set; }
        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
    }
}
