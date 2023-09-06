using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabPessoa
    {
        public TabPessoa()
        {
            TabAgenda = new HashSet<TabAgendum>();
            TabProcessoInteressados = new HashSet<TabProcessoInteressado>();
            TabProcessos = new HashSet<TabProcesso>();
            TabProtocolos = new HashSet<TabProtocolo>();
        }

        public int PessId { get; set; }
        public string? PessTipo { get; set; }
        public string? PessNome { get; set; }
        public string? PessCpfcnpj { get; set; }
        public string? PessRg { get; set; }
        public string? PessTituloEleitor { get; set; }
        public string? PessCep { get; set; }
        public string? PessTipoLogradouro { get; set; }
        public string? PessLogradouro { get; set; }
        public string? PessNumero { get; set; }
        public string? PessBairro { get; set; }
        public string? PessComplemento { get; set; }
        public int? CidaId { get; set; }
        public string? PessNomeMae { get; set; }
        public string? PessEmail { get; set; }
        public string? PessFone { get; set; }
        public DateTime? PessDataNascimento { get; set; }
        public string? PessEstadoCivil { get; set; }
        public string? PessProfissao { get; set; }
        public int? CidaOrigemId { get; set; }
        public long? ConId { get; set; }

        public virtual TabCidade? Cida { get; set; }
        public virtual ICollection<TabAgendum> TabAgenda { get; set; }
        public virtual ICollection<TabProcessoInteressado> TabProcessoInteressados { get; set; }
        public virtual ICollection<TabProcesso> TabProcessos { get; set; }
        public virtual ICollection<TabProtocolo> TabProtocolos { get; set; }
    }
}
