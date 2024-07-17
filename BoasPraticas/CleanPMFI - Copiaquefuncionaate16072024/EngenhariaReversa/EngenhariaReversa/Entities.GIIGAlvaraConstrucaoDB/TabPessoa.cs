using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGAlvaraConstrucaoDB
{
    public partial class TabPessoa
    {
        public TabPessoa()
        {
            TabSolicitacos = new HashSet<TabSolicitaco>();
            TabUsuarios = new HashSet<TabUsuario>();
        }

        public int PessId { get; set; }
        public string? PessTipo { get; set; }
        public string? PessNome { get; set; }
        public string? PessCpfcnpj { get; set; }
        public string? PessCep { get; set; }
        public string? PessTipoLogradouro { get; set; }
        public string? PessLogradouro { get; set; }
        public string? PessNumero { get; set; }
        public string? PessBairro { get; set; }
        public string? PessComplemento { get; set; }
        public int? CidaId { get; set; }
        public string? PessNomeMae { get; set; }
        public string? PessEmail { get; set; }
        public string? PessInscricaoMunicipal { get; set; }
        public string? PessCrea { get; set; }
        public string? PessProfissao { get; set; }
        public string? PessTelefone { get; set; }

        public virtual TabCidade? Cida { get; set; }
        public virtual ICollection<TabSolicitaco> TabSolicitacos { get; set; }
        public virtual ICollection<TabUsuario> TabUsuarios { get; set; }
    }
}
