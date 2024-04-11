using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcReceitasFontesOperacao
{
    public int IdReceitaFonte { get; set; }

    public int? IdReceita { get; set; }

    public short? IdTipoOperacaoReceita { get; set; }

    public virtual TbOrcReceita? IdReceitaNavigation { get; set; }

    public virtual ICollection<TbOrcReceitasFontesDesmembra> TbOrcReceitasFontesDesmembras { get; set; } = new List<TbOrcReceitasFontesDesmembra>();
}
