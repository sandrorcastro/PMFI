using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcReceitasFontesOperacao
    {
        public TbOrcReceitasFontesOperacao()
        {
            TbOrcReceitasFontesDesmembras = new HashSet<TbOrcReceitasFontesDesmembra>();
        }

        public int IdReceitaFonte { get; set; }
        public int? IdReceita { get; set; }
        public short? IdTipoOperacaoReceita { get; set; }

        public virtual TbOrcReceita? IdReceitaNavigation { get; set; }
        public virtual ICollection<TbOrcReceitasFontesDesmembra> TbOrcReceitasFontesDesmembras { get; set; }
    }
}
