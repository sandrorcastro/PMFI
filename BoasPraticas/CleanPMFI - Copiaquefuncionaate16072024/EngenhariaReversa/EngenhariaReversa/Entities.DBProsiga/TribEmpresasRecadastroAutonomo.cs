using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEmpresasRecadastroAutonomo
    {
        public int RecAutoId { get; set; }
        public long EmprCmc { get; set; }
        public int RecAutoSequencia { get; set; }
        public int RecAutoAno { get; set; }
        public DateTime DataInclusao { get; set; }
        public string RecAutoMotivo { get; set; } = null!;
        public string RecAutoCep { get; set; } = null!;
        public int RecAutoLogradId { get; set; }
        public int RecAutoBairroId { get; set; }
        public int RecAutoCidadeId { get; set; }
        public string RecAutoNumPredial { get; set; } = null!;
        public string RecAutoComplemento { get; set; } = null!;
        public string UsuarioInclusao { get; set; } = null!;
    }
}
