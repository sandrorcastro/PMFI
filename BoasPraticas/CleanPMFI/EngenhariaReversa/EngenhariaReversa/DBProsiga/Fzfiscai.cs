using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Fzfiscai
    {
        public Fzfiscai()
        {
            FzvistoriaVeiculos = new HashSet<FzvistoriaVeiculo>();
        }

        /// <summary>
        /// Código de identificação do fiscal.
        /// </summary>
        public long FiscId { get; set; }
        /// <summary>
        /// Nome do fiscal.
        /// </summary>
        public string FiscNome { get; set; } = null!;
        /// <summary>
        /// Matricula funcional do fiscal.
        /// </summary>
        public string FiscMatricula { get; set; } = null!;
        /// <summary>
        /// Número do RG - Registro Geral do Fiscal.
        /// </summary>
        public string FiscRg { get; set; } = null!;
        public string? FiscCpf { get; set; }
        public int? FiscPessoaId { get; set; }
        public bool? FiscAtivo { get; set; }

        public virtual ICollection<FzvistoriaVeiculo> FzvistoriaVeiculos { get; set; }
    }
}
