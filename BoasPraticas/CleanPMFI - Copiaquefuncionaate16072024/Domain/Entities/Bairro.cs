using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Bairro
    {   public int IdBairro { get; set; }
        public string Nome { get; set; }
        public int? IdRegiao { get; set; }
        public virtual Regiao? Regiao { get; set; }
    }
}
