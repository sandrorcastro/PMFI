using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribInstalacaoEletrica
    {
        public TribInstalacaoEletrica()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int EletricaId { get; set; }
        public string? EletricaNome { get; set; }
        public decimal? EletricaFator { get; set; }
        public int? EletricaPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
