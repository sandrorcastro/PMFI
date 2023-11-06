using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalMobile.Models
{
    public class PerfilApp
    {
        [Key]
        public int IdPerfilApp { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Matricula { get; set; }
    }
}
