using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ConjuntoEstilo
{
    public int IdConjuntoEstilos { get; set; }

    public string SinUltimo { get; set; } = null!;

    public virtual ICollection<BaseConhecimento> BaseConhecimentos { get; set; } = new List<BaseConhecimento>();

    public virtual ICollection<ConjuntoEstilosItem> ConjuntoEstilosItems { get; set; } = new List<ConjuntoEstilosItem>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<TextoPadraoInterno> TextoPadraoInternos { get; set; } = new List<TextoPadraoInterno>();
}
