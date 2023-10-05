using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class EmpresasBaixadasPosRevisao
    {
        public long EmprCmc { get; set; }
        public long? ConId { get; set; }
        public int? LogradId { get; set; }
        public string? EmprEnderecoNum { get; set; }
        public int? BairroId { get; set; }
        public int? CidadeId { get; set; }
        public string? EmprComplemento { get; set; }
        public long? ContadorId { get; set; }
        public long? EmprRegJuntaCom { get; set; }
        public DateTime? EmprRegJuntaComData { get; set; }
        public string? EstabGrupo { get; set; }
        public decimal? EmprAreaAberta { get; set; }
        public decimal? AnteriorAreaConstr { get; set; }
        public int? AnteriorNumPavimento { get; set; }
        public string? EmprAlvaraEventual { get; set; }
        public int? EmprSituacaoId { get; set; }
        public int? EmprNumEmpregados { get; set; }
        public string? EmprComGas { get; set; }
        public string? EmprComExplosivo { get; set; }
        public string? EmprComDiversoes { get; set; }
        public int? EmprHotelNumQuarto { get; set; }
        public int? EmprHotelNumApto { get; set; }
        public int? EmprHospitalNumLeitos { get; set; }
        public int? EmprJogosNumMesas { get; set; }
        public int? EmprJogosNumEletronicos { get; set; }
        public int? EmprJogosNumPista { get; set; }
        public int? EmprBarbeiroNumLug { get; set; }
        public int? EmprTeatroNumLug { get; set; }
        public int? EmprEnsinoNumSalas { get; set; }
        public string? EmprSubstituto { get; set; }
        public int? EmprTipoId { get; set; }
        public int? EmprConstitId { get; set; }
        public string? EmprCnpjextensao { get; set; }
        public int? EmprCaracId { get; set; }
        public string? EmprCep { get; set; }
        public string EmprDomicilioTributario { get; set; } = null!;
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public short? EmprTipoEntidade { get; set; }
        public DateTime? EmprDtFinCadastro { get; set; }
        public string? EmprAtividadeContratoSocial { get; set; }
        public string? EmprOrigemDuc { get; set; }
        public DateTime? EmprDataInscricao { get; set; }
        public string EmprEnqSimples { get; set; } = null!;
        public string? EmprRestricoes { get; set; }
    }
}
