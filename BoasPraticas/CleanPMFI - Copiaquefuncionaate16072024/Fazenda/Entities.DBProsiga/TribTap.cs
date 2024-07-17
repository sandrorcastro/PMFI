using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribTap
{
    public long TapId { get; set; }

    public long? TapNumero { get; set; }

    public DateTime? TapData { get; set; }

    public string? TapLeiNum { get; set; }

    public decimal? TapPercDescMulta { get; set; }

    public decimal? TapPercDescMultaDa { get; set; }

    public decimal? TapPercDescJuros { get; set; }

    public decimal? TapPercDescCorrec { get; set; }

    public int? TapNumParcelas { get; set; }

    public long? ConId { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public long? LeiDescId { get; set; }

    public long? EdificacaoIddestino { get; set; }

    public long? EmprCmcDestino { get; set; }

    public long? ConIddestino { get; set; }

    /// <summary>
    /// Tipo do lançamento do tap: Automático=Lançamento do Sistema, Manual=&gt;Lançamento do Usuário.
    /// </summary>
    public string? TapTipoLanc { get; set; }

    /// <summary>
    /// Marca a situação das dividas DESTINO do TAP: &apos;Pendente&apos; ou &apos;Baixada&apos;
    /// </summary>
    public string TapSituacao { get; set; } = null!;

    public string? TapPossuiEntrada { get; set; }

    public string? IpRequest { get; set; }

    public string? TapPossuiRescisao { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual Contribuinte? ConIddestinoNavigation { get; set; }

    public virtual TribEdificaco? EdificacaoIddestinoNavigation { get; set; }

    public virtual TribEmpresa? EmprCmcDestinoNavigation { get; set; }

    public virtual TribLeisDesc? LeiDesc { get; set; }

    public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; } = new List<TribTapDestino>();

    public virtual ICollection<TribTapInscrOrigem> TribTapInscrOrigems { get; set; } = new List<TribTapInscrOrigem>();

    public virtual ICollection<TribTapMapa> TribTapMapas { get; set; } = new List<TribTapMapa>();

    public virtual ICollection<TribTapOrigem> TribTapOrigems { get; set; } = new List<TribTapOrigem>();
}
