using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Lembrete
{
    public int IdLembrete { get; set; }

    public int IdUsuario { get; set; }

    public int PosicaoX { get; set; }

    public int PosicaoY { get; set; }

    public int Largura { get; set; }

    public int Altura { get; set; }

    public string Cor { get; set; } = null!;

    public string CorTexto { get; set; } = null!;

    public DateTime DthLembrete { get; set; }

    public string Conteudo { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
