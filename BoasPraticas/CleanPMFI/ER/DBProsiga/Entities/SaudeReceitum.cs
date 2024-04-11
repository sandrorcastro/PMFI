using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeReceitum
{
    public int Idreceita { get; set; }

    public int Idpaciente { get; set; }

    public int Idfuncionario { get; set; }

    public int IdocupacaoSaude { get; set; }

    public int? IdunidadeSaude { get; set; }

    public DateTime DataAtendimento { get; set; }

    public string? HoraAtendimento { get; set; }

    public int? Removido { get; set; }

    public int? Idatendimento { get; set; }

    public int? Status { get; set; }

    public long? AtendId { get; set; }

    public virtual ICollection<SaudeFarmaSaidaIten> SaudeFarmaSaidaItens { get; set; } = new List<SaudeFarmaSaidaIten>();

    public virtual ICollection<SaudeReceitaItem> SaudeReceitaItems { get; set; } = new List<SaudeReceitaItem>();
}
