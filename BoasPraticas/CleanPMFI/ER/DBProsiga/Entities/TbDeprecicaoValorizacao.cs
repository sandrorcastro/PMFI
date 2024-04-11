using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbDeprecicaoValorizacao
{
    public int IdDepVal { get; set; }

    public DateTime DtDepVal { get; set; }

    public decimal VlAnt { get; set; }

    public decimal VlAtual { get; set; }

    public string DsDepVal { get; set; } = null!;

    public string? ObdDepVal { get; set; }

    public string? ImoCnpjfilial { get; set; }

    public string? ImoInscricao { get; set; }

    public string? DsPortaria { get; set; }

    public string? DsDecreto { get; set; }

    public long? VeiculoId { get; set; }

    public long? MoeMovEquipId { get; set; }

    public int? IdTipoOperacao { get; set; }

    public virtual TbTipoOperacao? IdTipoOperacaoNavigation { get; set; }

    public virtual ImobensImovei? Imo { get; set; }

    public virtual MoveisEquipamento? MoeMovEquip { get; set; }

    public virtual Veiculo? Veiculo { get; set; }

    public virtual ICollection<Servidore> Servs { get; set; } = new List<Servidore>();
}
