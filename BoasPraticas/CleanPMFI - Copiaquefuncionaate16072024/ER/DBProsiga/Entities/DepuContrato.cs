using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class DepuContrato
{
    public long CntIdcontrato { get; set; }

    public string? CntCnpjfilial { get; set; }

    public long? CntIdFornec { get; set; }

    public int? CntAno { get; set; }

    public string? CntNumero { get; set; }

    public DateTime? CntData { get; set; }

    public DateTime? CntVencimento { get; set; }

    public string? CntHistDescr { get; set; }

    public decimal? CntValor { get; set; }

    public virtual Contribuinte? CntIdFornecNavigation { get; set; }

    public virtual ICollection<DePuAditivosContr> DePuAditivosContrs { get; set; } = new List<DePuAditivosContr>();

    public virtual ICollection<LocacaoFrotum> LocacaoFrota { get; set; } = new List<LocacaoFrotum>();

    public virtual ICollection<LocacaoMoveisEquipamento> LocacaoMoveisEquipamentos { get; set; } = new List<LocacaoMoveisEquipamento>();
}
