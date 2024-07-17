using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Imovel
    {
        public long IdImovel { get; set; }
        public Collection<EntidadeEndereco> Enderecos { get; set; }

    }
}
