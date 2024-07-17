using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FztermoVistorium
    {
        /// <summary>
        /// Código de Identificação do Auto de Infração.
        /// </summary>
        public long AutIid { get; set; }
        /// <summary>
        /// Data da notificação.
        /// </summary>
        public DateTime? AutiDataTermo { get; set; }
        /// <summary>
        /// Código de identificação da vistoria.
        /// </summary>
        public long? VistId { get; set; }
        public string? AutiRespVeiculo { get; set; }
        /// <summary>
        /// Nome do responsável pelo pátio onde esta o veículo.
        /// </summary>
        public string? AutiRespPatio { get; set; }
        /// <summary>
        /// Data de entrada do veículo no pátio.
        /// </summary>
        public DateTime? AutiDataEntrada { get; set; }
        /// <summary>
        /// Data da saída do veículo do pátio.
        /// </summary>
        public DateTime? AutiDataSaida { get; set; }
        /// <summary>
        /// Responsável pela retirada do veículo do pátio.
        /// </summary>
        public string? AutiRespRetirada { get; set; }

        public virtual FzautoInfraco AutI { get; set; } = null!;
        public virtual FzvistoriaVeiculo? Vist { get; set; }
    }
}
