using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FztipoPonto
    {
        public FztipoPonto()
        {
            Fzpontos = new HashSet<Fzponto>();
        }

        /// <summary>
        /// Código de Identificação do Tipo do Ponto
        /// </summary>
        public int FztipoPontoId { get; set; }
        /// <summary>
        /// Descrição do Tipo do Ponto de Veiculo, definido normalmente pelo Tipo do Veículo como MotoTaxi, Taxi, etc. 
        /// </summary>
        public string? FztipoPontoNome { get; set; }

        public virtual ICollection<Fzponto> Fzpontos { get; set; }
    }
}
