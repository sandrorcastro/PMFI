using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class CombustivelSaidum
    {
        public CombustivelSaidum()
        {
            CombustivelSaidaCupomFiscals = new HashSet<CombustivelSaidaCupomFiscal>();
            CombustivelSaidaMovimentos = new HashSet<CombustivelSaidaMovimento>();
        }

        public long ReqNum { get; set; }
        public long CodDeposito { get; set; }
        public long? VeiculoId { get; set; }
        public decimal QtdeLitros { get; set; }
        public DateTime DtEmissao { get; set; }
        public int DivId { get; set; }
        public long ServId { get; set; }
        public decimal? KmVeiculo { get; set; }
        public string? NumReqlocal { get; set; }
        public int? Via { get; set; }
        public string? Situacao { get; set; }
        public long? CombSaidaIdCondut { get; set; }
        public long? MovEquipId { get; set; }
        public long? ServIdOperario { get; set; }
        public int? TipoSaidaId { get; set; }

        public virtual CombustivelDeposito CodDepositoNavigation { get; set; } = null!;
        public virtual Condutores1registro? CombSaidaIdCondutNavigation { get; set; }
        public virtual Diviso Div { get; set; } = null!;
        public virtual MoveisEquipamento? MovEquip { get; set; }
        public virtual Servidore Serv { get; set; } = null!;
        public virtual Servidore? ServIdOperarioNavigation { get; set; }
        public virtual Veiculo? Veiculo { get; set; }
        public virtual ICollection<CombustivelSaidaCupomFiscal> CombustivelSaidaCupomFiscals { get; set; }
        public virtual ICollection<CombustivelSaidaMovimento> CombustivelSaidaMovimentos { get; set; }
    }
}
