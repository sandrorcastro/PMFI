using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ContratoConcessao
{
    public long IdContratoConcessao { get; set; }

    public string? ImoCnpjfilial { get; set; }

    public string ImoInscricao { get; set; } = null!;

    public DateTime DataIniContrat { get; set; }

    public DateTime? DataFimContrat { get; set; }

    public decimal? Valor { get; set; }

    public long? NumContrato { get; set; }

    public string? DescricaoContrat { get; set; }

    public int? IdTipoConcessao { get; set; }

    public int? NumLicitacao { get; set; }

    public int? IdTipoLicitacao { get; set; }

    public DateTime? DataBaixaContrato { get; set; }

    public decimal? ValorBaixaContrato { get; set; }

    public int? NumParcela { get; set; }

    public string? MotivoBaixa { get; set; }

    public string? ObsBaixa { get; set; }

    public virtual TipoConcessao? IdTipoConcessaoNavigation { get; set; }

    public virtual TipoLicitacao? IdTipoLicitacaoNavigation { get; set; }

    public virtual ImobensImovei? Imo { get; set; }
}
