using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentoDecenio.Models
{
    public class INPC
    {
        public short? ano {  get; set; }
        public string? mes { get; set; }
        public decimal? nome { get; set; }
        public decimal? numero_indice { get; set; }
        public decimal? _3meses { get; set; }
        public decimal? _6meses { get; set; }
        public decimal? noano { get; set; }
        public decimal? _12meses { get; set; }
    }
}
