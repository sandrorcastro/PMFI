using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Processo
    {
       
        public long ProcessoId { get; set; }
       
       // public long? ObjetoProcessoId { get; set; }
        public ObjetoProcesso? ObjetoProcesso { get; set; }       
        public int? OrgaoId { get; set; }
        public Orgao? Orgao { get; set; }
        public int? UnidadeId { get; set; }
        public Unidade? Unidade { get; set; }
        public int? DivisaoId { get; set; }
        public Divisao? Divisao { get; set; }
        public DateTime? Ano { get; set; }
       // public int? DigitoVerificador { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int? TipoProcessoId { get; set; }
        public TipoProcesso? TipoProcesso { get; set; }
        public int? SituacaoProcessoId { get; set; }
        public SituacaoProcesso? SituacaoProcesso { get; set; }
        public int? OrgaoRemetenteId { get; set; }
        public Orgao? OrgaoRemetente { get; set; }
        public int? UnidadeRemetenteId { get; set; }
        public Unidade? UnidadeRemetente { get; set; }

        public int? DivisaoRemetenteId { get; set; }
        public Divisao? DivisaoRemetente { get; set; }
        public int? OrgaoDestinatarioId { get; set; }
        public Orgao? OrgaoDestinatario { get; set; }
        public int? UnidadeDestinatarioId { get; set; }
        public Unidade? UnidadeDestinatario { get; set; }
        public int? DivisaoDestinatarioId { get; set; }
        public Divisao? DivisaoDestinatario { get; set; }
        // public int FluxoProcessoId { get; set; }
        // public FluxoProcesso? FluxoProcesso { get; set; }
        public long? ServidorId { get; set; }
        public Servidor? Servidor { get; set; }

        public long? ServidorExecutorId { get; set; }
        public Servidor? ServidorExecutor { get; set; }
        public string? ObservacaoProcesso { get; set; }
        public ICollection<Etapa>? Etapas { get; set; }
        public bool? ProcessoEnviado { get; set; } = false;
        public bool? ProcessoRecebido { get; set; } = false;
        public bool? ProcessoAntigo { get; set; } = false;
        public bool? ProcessoInativo { get; set; } = false;

        //public NivelAcesso //Sigiloso| Restrito| Publico
    }
}
