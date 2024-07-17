using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbconsultaprevium
{
    public int Idconsulta { get; set; }

    public string? Nrinscricaoimobiliaria { get; set; }

    public DateTime? Dtconsulta { get; set; }

    public string? Nrprotocolo { get; set; }

    public short? Zozoid { get; set; }

    public short? Idtipoempresa { get; set; }

    public bool? Fldomiciliotributario { get; set; }

    public string? Nrcpfcnpj { get; set; }

    public string? Nmempresa { get; set; }

    public string? Dstelefonecontato { get; set; }

    public decimal? Vlareacoberta { get; set; }

    public string? Dsendereco { get; set; }

    public string? Nrcep { get; set; }

    public int? Idusuarioinclusao { get; set; }

    /// <summary>
    /// Situação da Consulta: Deferida, Indeferida, Aguardando Análise, Constituida
    /// </summary>
    public string? Flsituacao { get; set; }

    /// <summary>
    /// Indica se a consulta está sendo realizada por um contador.
    /// </summary>
    public bool? Flcontador { get; set; }

    public string? Nrcpfcnpjsolicitante { get; set; }

    public string? Nmsolicitante { get; set; }

    public virtual ICollection<Tbconsultapreviadocumentoresposta> Tbconsultapreviadocumentoresposta { get; set; } = new List<Tbconsultapreviadocumentoresposta>();

    public virtual ICollection<Tbconsultapreviadocumento> Tbconsultapreviadocumentos { get; set; } = new List<Tbconsultapreviadocumento>();

    public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; } = new List<Tbconsultapreviagrauriscoresposta>();

    public virtual ICollection<Tbconsultapreviagraurisco> Tbconsultapreviagrauriscos { get; set; } = new List<Tbconsultapreviagraurisco>();

    public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; } = new List<Tbconsultapreviazoneamentoresposta>();
}
