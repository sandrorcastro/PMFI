using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class GccCreche
{
    public string CreCnpjmembro { get; set; } = null!;

    public int CreId { get; set; }

    public string? CreNome { get; set; }

    public string? CreRespNome { get; set; }

    public string? CreRespCargo { get; set; }

    public string? CreRua { get; set; }

    public string? CreBairro { get; set; }

    public string? CreComplemento { get; set; }

    public string? CreCidade { get; set; }

    public string? CreUf { get; set; }

    public string? CreTel { get; set; }

    public int? CreCapacidade { get; set; }

    public int? CreTcreId { get; set; }

    public virtual GccTipoCreche? Cre { get; set; }

    public virtual ICollection<GccCreFase> GccCreFases { get; set; } = new List<GccCreFase>();

    public virtual ICollection<GccFuncCreche> GccFuncCreches { get; set; } = new List<GccFuncCreche>();
}
