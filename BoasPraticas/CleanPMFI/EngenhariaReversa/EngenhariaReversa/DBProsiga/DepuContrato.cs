using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class DepuContrato
    {
        public DepuContrato()
        {
            DePuAditivosContrs = new HashSet<DePuAditivosContr>();
            LocacaoFrota = new HashSet<LocacaoFrotum>();
            LocacaoMoveisEquipamentos = new HashSet<LocacaoMoveisEquipamento>();
        }

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
        public virtual ICollection<DePuAditivosContr> DePuAditivosContrs { get; set; }
        public virtual ICollection<LocacaoFrotum> LocacaoFrota { get; set; }
        public virtual ICollection<LocacaoMoveisEquipamento> LocacaoMoveisEquipamentos { get; set; }
    }
}
