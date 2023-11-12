using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Diviso
{
    public int DivId { get; set; }

    public string? DivNome { get; set; }

    public string? DivAtribuicao { get; set; }

    public long? DivServRespId { get; set; }

    public int? DivUnidadeId { get; set; }

    public int? DivLocalId { get; set; }

    public string? DivEmail { get; set; }

    public string? DivFone { get; set; }

    /// <summary>
    /// Sim ou Branco - Indica se a divisão foi extinta.
    /// </summary>
    public string? DivExtincao { get; set; }

    /// <summary>
    /// Data em que foi extinta a divisão.
    /// </summary>
    public DateTime? DivDtExtincao { get; set; }

    public string? DivIntegrProsiga { get; set; }

    public string? DivNomeResp { get; set; }

    public string? DivCargoResp { get; set; }

    public virtual ICollection<CargasProcesso> CargasProcessoCargaDivisaoIdorigemNavigations { get; set; } = new List<CargasProcesso>();

    public virtual ICollection<CargasProcesso> CargasProcessoCargaDivisaos { get; set; } = new List<CargasProcesso>();

    public virtual ICollection<CombustivelSaidum> CombustivelSaida { get; set; } = new List<CombustivelSaidum>();

    public virtual Localizacao? DivLocal { get; set; }

    public virtual Unidade? DivUnidade { get; set; }

    public virtual ICollection<FluxoProcesso> FluxoProcessos { get; set; } = new List<FluxoProcesso>();

    public virtual ICollection<Processo> Processos { get; set; } = new List<Processo>();

    public virtual ICollection<PubDocumento> PubDocumentos { get; set; } = new List<PubDocumento>();

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionais { get; set; } = new List<RhdadosFuncionai>();

    public virtual ICollection<TribFiscTiposVistorium> TribFiscTiposVistoria { get; set; } = new List<TribFiscTiposVistorium>();

    public virtual ICollection<TribProtestoLote> TribProtestoLotes { get; set; } = new List<TribProtestoLote>();

    public virtual ICollection<VeicSolicitacao> VeicSolicitacaos { get; set; } = new List<VeicSolicitacao>();

    public virtual ICollection<Usuario> DivAutUsuarios { get; set; } = new List<Usuario>();
}
