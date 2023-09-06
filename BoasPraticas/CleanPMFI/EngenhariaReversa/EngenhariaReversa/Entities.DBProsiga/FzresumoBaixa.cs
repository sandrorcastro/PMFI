using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FzresumoBaixa
    {
        public DateTime RebxData { get; set; }
        public int ConvenioId { get; set; }
        /// <summary>
        /// Valor total do arquivo de baixa, fornecido pelo banco.
        /// </summary>
        public decimal RebxVlrTotalArquivo { get; set; }
        /// <summary>
        /// Valor total baixado do arquivo fornecido pelo banco.
        /// </summary>
        public decimal RebxVlrBaixado { get; set; }
        /// <summary>
        /// Valor que possui erros e não foi possivel realizar a baixa.
        /// </summary>
        public decimal RebxVlrNaoBaixado { get; set; }
        /// <summary>
        /// Nome do arquivo de baixa fornecido pelo banco.
        /// </summary>
        public string RebxNomeArquivo { get; set; } = null!;
        public int? RebxQtdeBaixado { get; set; }
        public int? RebxQtdeErro { get; set; }
        public int? RebxQtdeGeral { get; set; }
    }
}
