using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class DadosSanepar
{
    public int Id { get; set; }

    public string? Matricula { get; set; }

    public string? Roteiro { get; set; }

    public short? Ar { get; set; }

    public short? Ac { get; set; }

    public int? QtdeMat { get; set; }

    public int? QtdeInsc { get; set; }

    public string? Inscricao { get; set; }

    public string? Endereco { get; set; }

    public string? Num { get; set; }

    public string? CompEndereco { get; set; }

    public string? Obs1 { get; set; }

    public string? Obs2 { get; set; }

    public string? Obs3 { get; set; }

    public string? Classe { get; set; }

    public string? Inscricaosemeco { get; set; }

    public string? Terreno { get; set; }

    public int? QtdeTribuno { get; set; }
}
