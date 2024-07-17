using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcTiposAlteracaoOrcamentarium
    {
        public TbOrcTiposAlteracaoOrcamentarium()
        {
            TbOrcAlteracoesOrcamentaria = new HashSet<TbOrcAlteracoesOrcamentaria>();
        }

        public short IdTipoAlteracao { get; set; }
        public string? NmTipoAlteracao { get; set; }
        public string? DsSigla { get; set; }
        public bool? FlAtivo { get; set; }
        public short? CdTc { get; set; }

        public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; }
    }
}
