using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeFarmaEntradasPorFormulario
    {
        public SaudeFarmaEntradasPorFormulario()
        {
            SaudeFarmaEntradasItemFormularioExtornos = new HashSet<SaudeFarmaEntradasItemFormularioExtorno>();
            SaudeFarmaEntradasItemFormularios = new HashSet<SaudeFarmaEntradasItemFormulario>();
        }

        public long IdEntrada { get; set; }
        public DateTime? DataEntrada { get; set; }
        public string? HoraEntrada { get; set; }
        public long? IdFormSaida { get; set; }
        public long? IdAlmox { get; set; }
        public long? IdEstoque { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<SaudeFarmaEntradasItemFormularioExtorno> SaudeFarmaEntradasItemFormularioExtornos { get; set; }
        public virtual ICollection<SaudeFarmaEntradasItemFormulario> SaudeFarmaEntradasItemFormularios { get; set; }
    }
}
