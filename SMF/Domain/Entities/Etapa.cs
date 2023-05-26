using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Etapa
    {
        public long ProcessoId { get; set; }
        public Processo? Processo { get; set; }
        public int FluxoProcessoId { get; set; }
        public FluxoProcesso? FluxoProcesso { get; set; }
        public int TipoProcessoId { get; set; }
        public TipoProcesso TipoProcesso { get; set; }
        public int SituacaoEtapaId { get; set; }
        public SituacaoEtapa? SituacaoEtapa { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataInicio { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataFim { get; set; }

        public long ServidorId { get; set; }
        public Servidor? Servidor { get; set; }


        public ICollection<Anexo> Anexos { get; set; }

       // public long ImovelId { get; set; }
       // public Imovel? Imovel { get; set; }
     
        //public long EconomiaId { get; set; }
        //public Economia? Economia { get; set; }

        public long? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public long? PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
        public string? Ano { get; set; }
        public bool? antigo { get; set; }
        public string? protocolo { get; set; }
        public string? anoprotocolo { get; set; }
        public string? ObservacaoEtapa { get; set; }
        public bool? emailEnviado { get; set; }
        public bool? emailRecebido { get; set; }
        public bool? whatsEnviado { get; set; }
        public bool? whatsRecebido { get; set; }
    }
}
