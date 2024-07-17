using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AndamentoMarcador
{
    public int IdAndamentoMarcador { get; set; }

    public int? IdMarcador { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public DateTime DthExecucao { get; set; }

    public long IdProcedimento { get; set; }

    public string SinUltimo { get; set; } = null!;

    public string? Texto { get; set; }

    public string StaOperacao { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual Marcador? IdMarcadorNavigation { get; set; }

    public virtual Procedimento IdProcedimentoNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
