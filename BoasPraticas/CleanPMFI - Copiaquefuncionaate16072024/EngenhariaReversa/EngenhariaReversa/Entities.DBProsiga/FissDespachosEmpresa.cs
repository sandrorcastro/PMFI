using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FissDespachosEmpresa
    {
        public FissDespachosEmpresa()
        {
            FissTributosDespachosEmpresas = new HashSet<FissTributosDespachosEmpresa>();
        }

        public long IddespachoEmpresa { get; set; }
        public long? IdtipoDespacho { get; set; }
        public long? ServId { get; set; }
        public DateTime? DataCadDespacho { get; set; }
        public string? Texto { get; set; }
        /// <summary>
        /// Atende Requisito Legais, Nao Atende Requisitos Legais, Dispensa Requisitos Conforme Legislação Vigente
        /// </summary>
        public string? StatusDespacho { get; set; }
        public long? EmprCmc { get; set; }

        public virtual TribEmpresa? EmprCmcNavigation { get; set; }
        public virtual FissDespachosServidore? FissDespachosServidore { get; set; }
        public virtual ICollection<FissTributosDespachosEmpresa> FissTributosDespachosEmpresas { get; set; }
    }
}
