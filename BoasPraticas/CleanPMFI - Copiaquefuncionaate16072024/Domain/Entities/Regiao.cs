using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Regiao
    {
        public Regiao() { }
        public int IdRegiao { get; set; }
        public string? Descricao { get; set; }
        public int? CidadeId { get; set; }
        public decimal? PercentualUvc { get; set; }
        /// <summary>
        /// Valor da Longitude na area central da região
        /// </summary>
        public string? CentroGrauLon { get; set; }
        /// <summary>
        /// Valor da Latitude na area central da região
        /// </summary>
        public string? CentroGrauLat { get; set; }

        public virtual Cidade? Cidade { get; set; }
    }
}
