using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapExecucaoAntecipadum
    {
        public TbCapExecucaoAntecipadum()
        {
            TbCapEstornosExecucaoAntecipada = new HashSet<TbCapEstornosExecucaoAntecipadum>();
        }

        public int IdExecucao { get; set; }
        public int IdRecurso { get; set; }
        /// <summary>
        /// O-Operação de Credito, C-Convenios, S-SIT
        /// </summary>
        public string? TpRecurso { get; set; }
        public short? NrExecucao { get; set; }
        public short? NrAnoExecucao { get; set; }
        public int? NrSequenciaAno { get; set; }
        public short? IdTipoExecucaoAntecipada { get; set; }
        public DateTime? DtExecucao { get; set; }
        /// <summary>
        /// Identificador do lançamento contábil da transferencia, entre contas, ou de deposito ou ressarcimento
        /// </summary>
        public int? IdLancamentoBanco { get; set; }
        public decimal? VlExecucao { get; set; }
        public int? IdEmpenho { get; set; }
        /// <summary>
        /// Identificador da transferencia no SIT para convenios do SIT
        /// </summary>
        public int? IdTransferencia { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual TbCapConvAuxPrograma IdRecursoNavigation { get; set; } = null!;
        public virtual TbCapTiposExecucaoAntecipadum? IdTipoExecucaoAntecipadaNavigation { get; set; }
        public virtual ICollection<TbCapEstornosExecucaoAntecipadum> TbCapEstornosExecucaoAntecipada { get; set; }
    }
}
