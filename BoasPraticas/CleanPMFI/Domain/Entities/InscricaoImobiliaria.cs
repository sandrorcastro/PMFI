using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InscricaoImobiliaria

    {
        Quadrante Quadrante { get; set; }
        Quadricula  Quadricula { get; set; }
        Setor Setor { get; set; }
        Quadra Quadra { get; set; }
        Lote Lote { get; set; }
        Economia Economia { get; set; }
    }
}
