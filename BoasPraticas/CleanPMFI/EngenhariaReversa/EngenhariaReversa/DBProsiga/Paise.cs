using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Paise
    {
        public Paise()
        {
            Cidades = new HashSet<Cidade>();
        }

        /// <summary>
        /// Código|Código de identificacao do pais
        /// </summary>
        public int PaisId { get; set; }
        /// <summary>
        /// Nome do Pais|Nome do pais
        /// </summary>
        public string? PaisNome { get; set; }
        /// <summary>
        /// Sigla|Sigla de identificação do pais.
        /// </summary>
        public string? PaisSigla { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
