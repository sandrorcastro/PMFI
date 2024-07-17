using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblUsuario
    {
        public NfseTblUsuario()
        {
            NfseTblCredenciamentos = new HashSet<NfseTblCredenciamento>();
            NfseTblDeclaracaoSemIncidencia = new HashSet<NfseTblDeclaracaoSemIncidencium>();
            NfseTblDeclaracaoSemMovimentos = new HashSet<NfseTblDeclaracaoSemMovimento>();
            NfseTblEmpresaContratosHomologacaos = new HashSet<NfseTblEmpresaContratosHomologacao>();
            NfseTblLogAcaos = new HashSet<NfseTblLogAcao>();
            NfseTblLogs = new HashSet<NfseTblLog>();
            NfseTblPedAlteraRegimes = new HashSet<NfseTblPedAlteraRegime>();
            NfseTblPedCancelamentos = new HashSet<NfseTblPedCancelamento>();
            NfseTblPedSubstituicaos = new HashSet<NfseTblPedSubstituicao>();
            NfseTblReciboRetencaos = new HashSet<NfseTblReciboRetencao>();
        }

        public string Idusuario { get; set; } = null!;
        public int? Idcontribuinte { get; set; }
        public string? Stsenha { get; set; }
        public string? Stsituacao { get; set; }
        public DateTime? Dtvalidadesenha { get; set; }
        public string? Atualizado { get; set; }

        public virtual NfseTblContribuinte? IdcontribuinteNavigation { get; set; }
        public virtual ICollection<NfseTblCredenciamento> NfseTblCredenciamentos { get; set; }
        public virtual ICollection<NfseTblDeclaracaoSemIncidencium> NfseTblDeclaracaoSemIncidencia { get; set; }
        public virtual ICollection<NfseTblDeclaracaoSemMovimento> NfseTblDeclaracaoSemMovimentos { get; set; }
        public virtual ICollection<NfseTblEmpresaContratosHomologacao> NfseTblEmpresaContratosHomologacaos { get; set; }
        public virtual ICollection<NfseTblLogAcao> NfseTblLogAcaos { get; set; }
        public virtual ICollection<NfseTblLog> NfseTblLogs { get; set; }
        public virtual ICollection<NfseTblPedAlteraRegime> NfseTblPedAlteraRegimes { get; set; }
        public virtual ICollection<NfseTblPedCancelamento> NfseTblPedCancelamentos { get; set; }
        public virtual ICollection<NfseTblPedSubstituicao> NfseTblPedSubstituicaos { get; set; }
        public virtual ICollection<NfseTblReciboRetencao> NfseTblReciboRetencaos { get; set; }
    }
}
