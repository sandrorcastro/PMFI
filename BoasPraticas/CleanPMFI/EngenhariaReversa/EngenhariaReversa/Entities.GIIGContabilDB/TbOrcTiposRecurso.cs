using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcTiposRecurso
    {
        public TbOrcTiposRecurso()
        {
            TbOrcAlteracoesOrcamentaria = new HashSet<TbOrcAlteracoesOrcamentaria>();
        }

        public short IdTipoRecurso { get; set; }
        public string? NmTipoRecurso { get; set; }
        public string? DsSigla { get; set; }
        public bool? FlAtivo { get; set; }
        public short? CdTc { get; set; }

        public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; }
    }
}
