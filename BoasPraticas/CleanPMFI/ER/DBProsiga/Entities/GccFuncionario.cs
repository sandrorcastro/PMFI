using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GccFuncionario
{
    public string FuncCnpjmembro { get; set; } = null!;

    public int FuncId { get; set; }

    public string? FuncNome { get; set; }

    public DateTime? FuncDtNasc { get; set; }

    public string? FuncSexo { get; set; }

    public string? FuncRua { get; set; }

    public string? FuncBairro { get; set; }

    public string? FuncComplemento { get; set; }

    public string? FuncCidade { get; set; }

    public string? FuncUf { get; set; }

    public string? FuncTelRes { get; set; }

    public string? FuncTelRec { get; set; }

    public string? FuncCpf { get; set; }

    public string? FuncRg { get; set; }

    public string? FuncCargo { get; set; }

    public virtual ICollection<GccFuncCreche> GccFuncCreches { get; set; } = new List<GccFuncCreche>();
}
