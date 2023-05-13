using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class IncrementoTabelas
    {
        public int IncrementoTabelasId { get; set; }
        public string? Tabela { get; set; }
        public string? Parametro { get; set; } 

        public long? valorAtual { get; set; }
        public string? Ano { get; set; }
        
        public long? valorInicial { get; set; }

        public long? valorFinal { get; set; }

        public int? valorincrementar { get; set; }
    }
}
