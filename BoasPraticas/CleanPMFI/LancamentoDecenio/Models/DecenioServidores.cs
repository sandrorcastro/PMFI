using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentoDecenio.Models
{
    public class DecenioServidores

    {
       
        public string? CPF;
        public int? Matricula;
        public string? Nome;
        public virtual List<DecenioBase> DecenioBase {  get; set; }
    }
}
