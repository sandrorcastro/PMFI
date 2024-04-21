using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasServico
    {
        public long EmprCmc { get; set; }
        public string ServId { get; set; } = null!;
        public DateTime? ServEmprDataIni { get; set; }
        public DateTime? ServEmprDataFim { get; set; }
        public string? ServEmprMotivo { get; set; }
        /// <summary>
        /// Imune, Isento, Não Tributável ou Tributável
        /// </summary>
        public string? ServEmprTipoIncidencia { get; set; }
        /// <summary>
        /// Marca se é o serviço principal da empresa.
        /// </summary>
        public string ServEmprPrincipal { get; set; } = null!;
        public string ServEmprProvisorio { get; set; } = null!;

        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
        public virtual TribTiposServico Serv { get; set; } = null!;
    }
}
