using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbtribativpergunta
{
    /// <summary>
    /// Identificação do registro.
    /// </summary>
    public int Idpergunta { get; set; }

    /// <summary>
    /// Descrição da pergunta
    /// </summary>
    public string? Dspergunta { get; set; }

    /// <summary>
    /// Número da pergunta (Se houver)
    /// </summary>
    public int? Nrpergunta { get; set; }

    /// <summary>
    /// Indica que a pergunta será exibida quando o resultado da Consulta Prévia der PROIBIDO.
    /// </summary>
    public bool? Flperguntacnaeproibido { get; set; }

    public string? Dssecretaria { get; set; }

    public string? CoIdentificadorPergunta { get; set; }

    public virtual ICollection<Tbconsultapreviadocumentoresposta> Tbconsultapreviadocumentoresposta { get; set; } = new List<Tbconsultapreviadocumentoresposta>();

    public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; } = new List<Tbconsultapreviagrauriscoresposta>();

    public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; } = new List<Tbconsultapreviazoneamentoresposta>();

    public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; } = new List<TbtribZonaZoneamentoAtividadePergunta>();

    public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; } = new List<TribAtivAtividadeGrauRiscoPergunta>();

    public virtual ICollection<TribAtivAtividadePergunta> TribAtivAtividadePergunta { get; set; } = new List<TribAtivAtividadePergunta>();
}
