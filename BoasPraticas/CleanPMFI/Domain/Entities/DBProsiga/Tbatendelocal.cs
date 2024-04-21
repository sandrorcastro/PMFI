using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Tbatendelocal
    {
        public int Idlocal { get; set; }
        public string? Nmlocal { get; set; }
        public string? Dsendereco { get; set; }
        public string? Nrlatitude { get; set; }
        public string? Nrlongitude { get; set; }
        /// <summary>
        /// 1 - GERAL
        /// 2 - RESTRIÇÃO
        /// </summary>
        public string Fltipoacesso { get; set; } = null!;
        /// <summary>
        /// S: Permite atendimento retroativo
        /// N: Não permite atendimento retroativo
        /// </summary>
        public string Flpermiteatendretroativo { get; set; } = null!;
    }
}
