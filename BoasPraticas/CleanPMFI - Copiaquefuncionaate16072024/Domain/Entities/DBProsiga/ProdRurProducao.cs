using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ProdRurProducao
    {
        public int Idproducao { get; set; }
        public int? IdprodRural { get; set; }
        public int? IdpropProdutor { get; set; }
        public int? UnMedId { get; set; }
        public decimal? Qtde { get; set; }
        public decimal? AreaProducao { get; set; }
        public DateTime? DataIni { get; set; }
        public DateTime? DataFim { get; set; }

        public virtual ProdRurProdutosRurai? IdprodRuralNavigation { get; set; }
        public virtual ProdRurPropriedadesRurProdutor? IdpropProdutorNavigation { get; set; }
        public virtual AlmUnMed? UnMed { get; set; }
    }
}
