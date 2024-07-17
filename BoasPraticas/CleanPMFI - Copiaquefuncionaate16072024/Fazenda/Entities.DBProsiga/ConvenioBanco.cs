using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ConvenioBanco
{
    public int ConvenioId { get; set; }

    public string? ConvContaCorId { get; set; }

    public string? ConvAgenciaId { get; set; }

    public string? ConvBancoId { get; set; }

    public string? ConvNumConvenio { get; set; }

    public string? ConvNmConvenio { get; set; }

    public string? ConvFuncaoConvenio { get; set; }

    public long? ConvNossoNumero { get; set; }

    /// <summary>
    /// Código bancário para o cedente
    /// </summary>
    public string? ConvCodCedente { get; set; }

    /// <summary>
    /// Tipo do Bloqueto Bancário, para geração dos boletos.
    /// </summary>
    public string? ConvTipoBloqueto { get; set; }

    public string? ConvInstJuros { get; set; }

    public string? ConvInstMulta { get; set; }

    public string? ConvOrigemArq { get; set; }

    /// <summary>
    /// Endereço do arquivo de baixa sem erros
    /// </summary>
    public string? ConvDestinoArqSemErros { get; set; }

    /// <summary>
    /// Endereço do arquivo de baixa com erros
    /// </summary>
    public string? ConvDestinoArqComErros { get; set; }

    public string? ConvTecUltAlt { get; set; }

    public DateTime? ConvDtUltAlt { get; set; }

    public string? ConvCedente { get; set; }

    public string? ConvLocalPgto { get; set; }

    public string? ConvCarteira { get; set; }

    /// <summary>
    /// Informa se deve concatenar a Carteira como prefixo do Nosso Numero
    /// </summary>
    public string? ConvJuntarNncarteira { get; set; }

    public string? ConvContaContabil { get; set; }

    public short? ConvSegmento { get; set; }

    public short? ConvValorRealRef { get; set; }

    public string? ConvIdentifOrgao { get; set; }

    public bool? ConvRegistrado { get; set; }

    public virtual ICollection<ConvenioRegistrado> ConvenioRegistrados { get; set; } = new List<ConvenioRegistrado>();

    public virtual ICollection<LocBoleto> LocBoletos { get; set; } = new List<LocBoleto>();

    public virtual ICollection<LocReceitum> LocReceita { get; set; } = new List<LocReceitum>();

    public virtual ICollection<TribClassificaReceitum> TribClassificaReceita { get; set; } = new List<TribClassificaReceitum>();

    public virtual ICollection<TribDividasBaixa> TribDividasBaixas { get; set; } = new List<TribDividasBaixa>();

    public virtual ICollection<TribEstornoPagamento> TribEstornoPagamentos { get; set; } = new List<TribEstornoPagamento>();

    public virtual ICollection<TribParametro> TribParametros { get; set; } = new List<TribParametro>();

    public virtual ICollection<TribTipoTributo> TribTipoTributos { get; set; } = new List<TribTipoTributo>();
}
