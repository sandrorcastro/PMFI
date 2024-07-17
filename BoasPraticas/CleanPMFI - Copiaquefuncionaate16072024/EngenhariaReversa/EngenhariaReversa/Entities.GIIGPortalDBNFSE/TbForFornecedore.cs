using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbForFornecedore
    {
        public TbForFornecedore()
        {
            TbForDownloadsFornecedors = new HashSet<TbForDownloadsFornecedor>();
            TbForLicitacoesParticipantes = new HashSet<TbForLicitacoesParticipante>();
        }

        public int IdFornecedor { get; set; }
        public string? DsTipoPessoa { get; set; }
        public string? NmPessoa { get; set; }
        public string? NmFantasia { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NrRgIe { get; set; }
        public string? NrRegistroJuntaComercial { get; set; }
        public string? DsAtividade { get; set; }
        public string? NmPessoaResponsavel { get; set; }
        public string? DsSite { get; set; }
        public string? FlClientesAreaPublica { get; set; }
        public string? FlAssociadoSindicato { get; set; }
        public string? DsEmail { get; set; }
        public int? IdEndereco { get; set; }
        public string? NrCep { get; set; }
        public string? NmLogradouro { get; set; }
        public string? NmBairro { get; set; }
        public string? NmCidade { get; set; }
        public string? NmUf { get; set; }
        public string? NrPredial { get; set; }
        public string? NrTelefone { get; set; }
        public string? NrFax { get; set; }
        public string? NrCelular { get; set; }
        public byte[]? BnSenha { get; set; }
        public string? DsSituacao { get; set; }

        public virtual ICollection<TbForDownloadsFornecedor> TbForDownloadsFornecedors { get; set; }
        public virtual ICollection<TbForLicitacoesParticipante> TbForLicitacoesParticipantes { get; set; }
    }
}
