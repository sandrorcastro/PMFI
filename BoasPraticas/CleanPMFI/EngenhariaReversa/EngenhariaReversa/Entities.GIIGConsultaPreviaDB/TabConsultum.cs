using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultum
    {
        public TabConsultum()
        {
            TabConsultaAnexos = new HashSet<TabConsultaAnexo>();
            TabConsultaAvisos = new HashSet<TabConsultaAviso>();
            TabConsultaCnaes = new HashSet<TabConsultaCnae>();
            TabConsultaDados = new HashSet<TabConsultaDado>();
            TabConsultaDocumentos = new HashSet<TabConsultaDocumento>();
        }

        public int ConsId { get; set; }
        public string? ConsInscricao { get; set; }
        public string? ConsStatus { get; set; }
        public DateTime? ConsData { get; set; }
        public string ConsLocalizador { get; set; } = null!;
        public short? TipoId { get; set; }
        public byte[]? ConsCodigoBarra { get; set; }
        public long? IdDivida { get; set; }
        public int? ConsImpressa { get; set; }
        public DateTime? DtDeferimento { get; set; }
        public int? IdZoneamento { get; set; }
        public int? ConsIdNovo { get; set; }
        public string? VlLatitude { get; set; }
        public string? VlLongitude { get; set; }
        public string? DsZoneamento { get; set; }
        public string? DsArquivoXmlorigem { get; set; }
        public string? FlDomicilioTributario { get; set; }
        public string? FlrespostaXmlnovamente { get; set; }
        public string? FlIndeferidoSomenteJunta { get; set; }
        public string? ConsObservacao { get; set; }
        public string? FlIntegradoDuc { get; set; }

        public virtual ICollection<TabConsultaAnexo> TabConsultaAnexos { get; set; }
        public virtual ICollection<TabConsultaAviso> TabConsultaAvisos { get; set; }
        public virtual ICollection<TabConsultaCnae> TabConsultaCnaes { get; set; }
        public virtual ICollection<TabConsultaDado> TabConsultaDados { get; set; }
        public virtual ICollection<TabConsultaDocumento> TabConsultaDocumentos { get; set; }
    }
}
