using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ViewModels
{
    public class ProcessoViewModel
    {
        //   public int ProtocoloId { get; set; }
        // public Protocolo? Protocolo { get; set; }
        public int OrgaoId { get; set; }
        public Orgao? Orgao { get; set; }

        public long SequenciaNumerica { get; set; }
        public DateTime Ano { get; set; }
        public int DigitoVerificador { get; set; }
        public DateTime DataCadastro { get; set; }
        public int TipoProcessoId { get; set; }
        public TipoProcesso? TipoProcesso { get; set; }

        public int OrgaoRemetenteId { get; set; }
        public Orgao? OrgaoRemetente { get; set; }

        public int UnidadeRemetenteId { get; set; }
        public Unidade? UnidadeRemetente { get; set; }

        public int OrgaoDestinatarioId { get; set; }
        public Orgao? OrgaoDestinatario { get; set; }

        public int UnidadeDestinatarioId { get; set; }
        public Unidade? UnidadeDestinatario { get; set; }
        public int FluxoProcessoId { get; set; }
        public FluxoProcesso? FluxoProcesso { get; set; }

        public string? ObservacaoProcesso { get; set; }
        public ICollection<Etapa>? Etapas { get; set; }
        public bool ProcessoEnviado { get; set; } = false;
        public bool ProcessoRecebido { get; set; } = false;
        
        //public NivelAcesso //Sigiloso| Restrito| Publico
    }
}
