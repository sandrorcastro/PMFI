using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class VwDashBoardProcess
    {
        public long IdProcesso { get; set; }
        public int? Numero { get; set; }
        public short? Ano { get; set; }
        public DateTime? DataEntrada { get; set; }
        public string? Requerente { get; set; }
        public short? AssuntoId { get; set; }
        public string? Assunto { get; set; }
        public DateTime? UltimoMovimento { get; set; }
        public int? DiasEmTramite { get; set; }
        public int? DiasSemMovimento { get; set; }
        public short UnidadeAtualId { get; set; }
        public string? UnidadeAtual { get; set; }
        public string? DespachadoPor { get; set; }
        public short? EnviadoParaId { get; set; }
        public string? EnviadoPara { get; set; }
        public short? RecebidoPorId { get; set; }
        public string? RecebidoPor { get; set; }
        public string Situacao { get; set; } = null!;
    }
}
