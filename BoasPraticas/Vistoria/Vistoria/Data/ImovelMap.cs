using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistoria.Data
{
    public class ImovelMap : ClassMap<Imovel>
    {
        public ImovelMap()
        {
            Map(m => m.inscricao).Name("InscricaoImobiliaria");
            Map(m => m.proprietario).Name("conNome");
            
        }
    }
}
