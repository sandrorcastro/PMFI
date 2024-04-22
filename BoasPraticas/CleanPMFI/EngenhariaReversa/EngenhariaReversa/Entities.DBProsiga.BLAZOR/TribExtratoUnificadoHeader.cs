using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribExtratoUnificadoHeader
    {
        public string Sessao { get; set; } = null!;
        public string TipoCadastro { get; set; } = null!;
        public long Idinscricao { get; set; }
        public int? ConId { get; set; }
        public string? Cpfcnpj { get; set; }
        public string? Nome { get; set; }
        public string? NomeFantasia { get; set; }
        public string? Endereco { get; set; }
        public string? BairroLoteamento { get; set; }
        public string? Regiao { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public string? RefAnterior { get; set; }
        public string? Complemento { get; set; }
        public string? Situacao { get; set; }
        public string? Matricula { get; set; }
        public string? Propietario { get; set; }
        public string? Responsavel { get; set; }
        public string? Caracteristica { get; set; }
        public string? ContinuacaoTerreno { get; set; }
        public string? RazaoSocial { get; set; }
        public long? Englobamento { get; set; }
        public string? EnderecoContrib { get; set; }
        public string? Cnpj { get; set; }
        public string? BairroContrib { get; set; }
        public string? CoResponsavel { get; set; }
    }
}
