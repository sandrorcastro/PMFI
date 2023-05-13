using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TelefoneResidencial : Telefone
    {
        public string? Numero { get; set; }
       
    }
}
