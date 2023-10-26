using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistoria.Data
{
    public class Imovel
    {
        [Name("InscricaoImobiliaria")]
        public string inscricao { get; set; }
        [Name("conNome")]
        public string proprietario { get; set; }
    }
}
