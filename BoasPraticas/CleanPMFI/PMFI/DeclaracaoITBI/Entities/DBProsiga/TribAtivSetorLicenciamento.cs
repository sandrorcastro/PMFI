using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAtivSetorLicenciamento
{
    public short SetorId { get; set; }

    public string? SetorNome { get; set; }

    /// <summary>
    /// Assunto que será usado para criação do Protocolo Digital
    /// </summary>
    public int? AssuntoId { get; set; }

    public int? UnidadeId { get; set; }

    /// <summary>
    /// Assunto que será usado para criação do Protocolo Digital quando se tratar de MEI Domicilio Tributário
    /// </summary>
    public int? AssuntoIdmeidomicTrib { get; set; }

    public int? AssuntoIdmeiestab { get; set; }

    public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; } = new List<Tbconsultapreviagrauriscoresposta>();

    public virtual ICollection<Tbconsultapreviagraurisco> Tbconsultapreviagrauriscos { get; set; } = new List<Tbconsultapreviagraurisco>();

    public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; } = new List<TribAtivAtividadeGrauRiscoPergunta>();

    public virtual ICollection<TribAtivAtividadeGrauRisco> TribAtivAtividadeGrauRiscos { get; set; } = new List<TribAtivAtividadeGrauRisco>();
}
