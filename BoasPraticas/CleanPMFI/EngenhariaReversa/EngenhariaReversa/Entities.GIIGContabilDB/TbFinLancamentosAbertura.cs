using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinLancamentosAbertura
    {
        public int IdLancamento { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? CdEvento { get; set; }
        public DateTime? DtLancamento { get; set; }
        public decimal? VlLancamento { get; set; }
        public string? DsHistorico { get; set; }
        /// <summary>
        /// Indica a operação a ser feita no lançamento de abertura
        /// </summary>
        public string? DsOperacao { get; set; }
        /// <summary>
        /// Nome do Objeto, ContaContabil,  Contrato, Divida Fundada , etc
        /// </summary>
        public string? DsObjeto { get; set; }
        /// <summary>
        /// Identificador do Objeto
        /// </summary>
        public int? IdObjeto { get; set; }
        /// <summary>
        /// Indica se ja processou o lançamento de abertura
        /// </summary>
        public bool? FlProcessado { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? DsLogin { get; set; }
        public string? NrEnderecoIp { get; set; }
        public string? DsErro { get; set; }
    }
}
