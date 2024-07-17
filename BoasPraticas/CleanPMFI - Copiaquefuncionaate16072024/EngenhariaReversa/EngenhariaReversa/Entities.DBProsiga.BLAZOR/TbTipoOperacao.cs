using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbTipoOperacao
    {
        public TbTipoOperacao()
        {
            TbDeprecicaoValorizacaos = new HashSet<TbDeprecicaoValorizacao>();
        }

        public int IdTipoOperacao { get; set; }
        public string DsTipooperacao { get; set; } = null!;
        public int CdTribunal { get; set; }

        public virtual ICollection<TbDeprecicaoValorizacao> TbDeprecicaoValorizacaos { get; set; }
    }
}
