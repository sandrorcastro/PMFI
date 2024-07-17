using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaResposta
    {
        public int ConsIdResposta { get; set; }
        public int? ConsId { get; set; }
        public string? ConsInscricao { get; set; }
        public string? ConsLocalizador { get; set; }
        public DateTime? ConsDataSolicitacao { get; set; }
        public string? ConsMotivo { get; set; }
        public DateTime ConsDataResposta { get; set; }
        public string? Flenviarnovamente { get; set; }
        public string? DscodigoretornoWs { get; set; }
        public string? FlConsultaDeferida { get; set; }
        public string? Fldomiciliotributario { get; set; }
        public string? DsArquivoXmlorigem { get; set; }
    }
}
