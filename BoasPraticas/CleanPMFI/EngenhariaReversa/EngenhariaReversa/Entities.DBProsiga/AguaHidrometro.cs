using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AguaHidrometro
    {
        public AguaHidrometro()
        {
            AguaCobrancaBancos = new HashSet<AguaCobrancaBanco>();
            AguaEdificacoesHidrometros = new HashSet<AguaEdificacoesHidrometro>();
            AguaLeituraHidrometros = new HashSet<AguaLeituraHidrometro>();
            AguaRateios = new HashSet<AguaRateio>();
            AguaReqSolicitacaoServicos = new HashSet<AguaReqSolicitacaoServico>();
            AguaRuraisHidrometros = new HashSet<AguaRuraisHidrometro>();
        }

        public int HidroId { get; set; }
        public long? ConId { get; set; }
        public int? LogradId { get; set; }
        public int? BairroId { get; set; }
        public int? CidadeId { get; set; }
        public string? HidroIdentAnterior { get; set; }
        public string? HidroSituacao { get; set; }
        public DateTime? HidroData { get; set; }
        public int? HidroAnoFabric { get; set; }
        public string? HidroLogradNum { get; set; }
        public string? HidroDistrito { get; set; }
        public string? HidroQuadra { get; set; }
        public string? HidroLote { get; set; }
        public string? HidroSetor { get; set; }
        public int? CadernoId { get; set; }
        public int? HidroOrdem { get; set; }
        public string? HidroComplemento { get; set; }
        public string? HidroCodAnterior { get; set; }
        public long? HidroConIdresponsavel { get; set; }
        public string? HidroNumReferencia { get; set; }
        public int? HidroCaderno { get; set; }
        public string? HidroContaCorrente { get; set; }
        public string? BancoId { get; set; }

        public virtual ICollection<AguaCobrancaBanco> AguaCobrancaBancos { get; set; }
        public virtual ICollection<AguaEdificacoesHidrometro> AguaEdificacoesHidrometros { get; set; }
        public virtual ICollection<AguaLeituraHidrometro> AguaLeituraHidrometros { get; set; }
        public virtual ICollection<AguaRateio> AguaRateios { get; set; }
        public virtual ICollection<AguaReqSolicitacaoServico> AguaReqSolicitacaoServicos { get; set; }
        public virtual ICollection<AguaRuraisHidrometro> AguaRuraisHidrometros { get; set; }
    }
}
