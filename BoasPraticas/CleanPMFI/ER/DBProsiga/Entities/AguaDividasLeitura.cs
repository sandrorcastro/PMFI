using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AguaDividasLeitura
{
    public long DividasLeitAguaId { get; set; }

    public long? LeituraId { get; set; }

    public long? ConIddivida { get; set; }

    public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }

    public virtual AguaLeituraHidrometro? Leitura { get; set; }
}
