using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeAtendimento
    {
        public SaudeAtendimento()
        {
            SaudeAtendimentoDadosClinicos = new HashSet<SaudeAtendimentoDadosClinico>();
        }

        public long AtendId { get; set; }
        public int? CdPaciente { get; set; }
        public int? CdUnidadeSaude { get; set; }
        public int? CdFuncionario { get; set; }
        public int? CdOcupacaoSaude { get; set; }
        public DateTime? AtendData { get; set; }
        public int? AtendNumero { get; set; }
        public string? AtendHora { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? Situacao { get; set; }
        public string? TipoAtendimento { get; set; }

        public virtual ICollection<SaudeAtendimentoDadosClinico> SaudeAtendimentoDadosClinicos { get; set; }
    }
}
