using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VwGeomais02Unidade
    {
        public long NrCadastroImobiliario { get; set; }
        public long IdLote { get; set; }
        public string? CdDistrito { get; set; }
        public string? CdSetor { get; set; }
        public string? NrQuadra { get; set; }
        public string? NrLote { get; set; }
        public string? NrUnidade { get; set; }
        public string NrInscricaoAtual { get; set; } = null!;
        public string NrInscricaoAnterior { get; set; } = null!;
        public long? NrEdificacaoEnglobamento { get; set; }
        public long? CdPessoa { get; set; }
        public long? CdPessoaResponsavel { get; set; }
        public decimal? MdAreaConstruidaUnidade { get; set; }
        public string? NrMatricula { get; set; }
        public int? NrAgua { get; set; }
        public int? NrEnergia { get; set; }
        public int? DsBloco { get; set; }
        public string? NrAptoSalaLoja { get; set; }
        public int? NrAndar { get; set; }
        public string? NrImovel { get; set; }
        public string? DsComplemento { get; set; }
        public long? CdEdificio { get; set; }
        public int? DtAnoConstrucao { get; set; }
        public string Desativado { get; set; } = null!;
        public int? Comentarios { get; set; }
    }
}
