using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tb24SolicitaCadastro
{
    public int IdProjeto { get; set; }

    public string? DsProjeto { get; set; }

    public string? DsFinalidade { get; set; }

    public string? DsObservacao { get; set; }

    public string? DsCreaAutor { get; set; }

    public string? DsEmpProj { get; set; }

    public string? DsArtautorProj { get; set; }

    public string? DsCnpjempProj { get; set; }

    public string? DsCrearesponsavel { get; set; }
}
