using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VisaoConsultaProcesso
    {
        public long Numero { get; set; }
        public string? TipoProcesso { get; set; }
        public string? Cnpjcpf { get; set; }
        public string? NomeContribuinte { get; set; }
        public string? ObjetoDoProcesso { get; set; }
        public string? SituacaoAtual { get; set; }
        public DateTime? DataEntrada { get; set; }
        public DateTime? DataPrevistaAtendimento { get; set; }
        public string? PublicaNaInternet { get; set; }
        public DateTime? DataEnvio { get; set; }
        public string? DespachoEnvio { get; set; }
        public DateTime? DataRecebimentoDestinatário { get; set; }
        public string? SituacaoRecebimento { get; set; }
        public string? RecebidoPor { get; set; }
        public long CargaId { get; set; }
        public int? DivIdOrigem { get; set; }
        public string? DivNomeOrigem { get; set; }
        public string? DivAtribuicao { get; set; }
        public int? DivIdTramitacao { get; set; }
        public string? DivDescTramitacao { get; set; }
        public long? RecIdrecebimento { get; set; }
        public string? Destinatário { get; set; }
    }
}
