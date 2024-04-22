using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEmpresasEdificaco
    {
        public long EmprCmc { get; set; }
        public long EdificacaoId { get; set; }
        /// <summary>
        /// Logradouro da transversal 1.
        /// </summary>
        public int? LogradIdtransversal1 { get; set; }
        /// <summary>
        /// Logradouro da transversal 2.
        /// </summary>
        public int? LogradIdtransversal2 { get; set; }
        /// <summary>
        /// Complemento do endereço do imóvel da empresa.
        /// </summary>
        public string ComplEndereco { get; set; } = null!;
        public int? LogradIdfundos { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
    }
}
