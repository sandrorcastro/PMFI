using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GccFuncCreche
{
    public string Cnpjmembro { get; set; } = null!;

    public int CrecheId { get; set; }

    public int FuncId { get; set; }

    public DateTime? DtAdmissao { get; set; }

    public DateTime? DtRecisao { get; set; }

    public virtual GccCreche C { get; set; } = null!;

    public virtual GccFuncionario GccFuncionario { get; set; } = null!;
}
