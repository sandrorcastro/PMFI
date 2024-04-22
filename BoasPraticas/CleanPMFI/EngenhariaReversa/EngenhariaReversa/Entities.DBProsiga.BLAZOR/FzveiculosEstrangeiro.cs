using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FzveiculosEstrangeiro
    {
        public long FzveiId { get; set; }
        public int? VeiEspecie { get; set; }
        public int? VeiMarca { get; set; }
        public int? VeiModelo { get; set; }
        public long? PropId { get; set; }
        public long? EmprArrendatariaId { get; set; }
        public int? FztipoVeicId { get; set; }
        public long? VeiProcessoId { get; set; }
        public int? VeiCombustivel { get; set; }
        public int? AnoFabric { get; set; }
        public int? AnoModelo { get; set; }
        public string? Chassi { get; set; }
        public string? Placa { get; set; }
        public string? VeiCorPlaca { get; set; }
        public string? VeiCorPlacaLetraCorrigida { get; set; }
        public string? CorPredominante { get; set; }
        public string? CorPredOriginal { get; set; }
        public string? FzcodRenavam { get; set; }
        public int? Capacidade { get; set; }
        public int? Potencia { get; set; }
        public int? VeiNumPortas { get; set; }
        public string? AutiCorInfracao { get; set; }
        public string? VeiSituacao { get; set; }
        public int? CidadeId { get; set; }
        public int? CidadeIdEmplacamento { get; set; }
        public int? CidadeIdEmplacamentoDst { get; set; }
        public string? PaisEmplacamento { get; set; }
        public string? PaisEmplacamentoCorrigido { get; set; }
        public string? VeiPaisOrigem { get; set; }
        public string? VeiPaisOrigemCorrigido { get; set; }
        public long? UltimaVistId { get; set; }
        public DateTime? VeiDtLibVistoria { get; set; }
        public DateTime? VeiDataInclusao { get; set; }
        public DateTime? VeiDataUltAlt { get; set; }
        public DateTime? VeiDataBaixa { get; set; }
        public int? FzclassifVeiId { get; set; }
    }
}
