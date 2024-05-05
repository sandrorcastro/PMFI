using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VwGeomaisImovel
{
    public string NrCadastroImobiliario { get; set; } = null!;

    public string? CdDistrito { get; set; }

    public string? CdSetor { get; set; }

    public string? NrQuadra { get; set; }

    public string? NrLote { get; set; }

    public string NrEdificacao { get; set; } = null!;

    public string? NrUnidade { get; set; }

    public string NrInscricaoAtual { get; set; } = null!;

    public int? NrInscricaoAnterior { get; set; }

    public long? NrEdificacaoEnglobamento { get; set; }

    public int? NrUnidadeEnglobamento { get; set; }

    public int? EnglobaCom { get; set; }

    public long? CdPessoa { get; set; }

    public long? CdPessoaResponsavel { get; set; }

    public int? NrUnidadesConstruidas { get; set; }

    public decimal? MdArea { get; set; }

    public decimal? MdAreaConstruidaUnidade { get; set; }

    public decimal? MdAreaTotalConstruida { get; set; }

    public decimal? MdAreaEscriturada { get; set; }

    public int? MdProfundidade { get; set; }

    public int? CdLoteamento { get; set; }

    public int? NrQuadraLoteamento { get; set; }

    public int? NrLoteLoteamento { get; set; }

    public string? NrMatricula { get; set; }

    public int? NrAgua { get; set; }

    public int? NrEnergia { get; set; }

    public int? CdZoneamento { get; set; }

    public int? CdZona { get; set; }

    public int? DsBloco { get; set; }

    public string? NrAptoSalaLoja { get; set; }

    public int? NrAndar { get; set; }

    public string? NrImovel { get; set; }

    public string? DsComplemento { get; set; }

    public int? CdLogradouro { get; set; }

    public string CdBairro { get; set; } = null!;

    public int? CdEdificio { get; set; }

    public int? DtAnoConstrucao { get; set; }

    public string Desativado { get; set; } = null!;

    public int? Comentarios { get; set; }
}
