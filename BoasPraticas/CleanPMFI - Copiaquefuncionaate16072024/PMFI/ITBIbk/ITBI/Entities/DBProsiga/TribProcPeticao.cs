using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribProcPeticao
{
    public long ProcPetId { get; set; }

    public int ProcPetNumero { get; set; }

    public short ProcPetAno { get; set; }

    public string? CertidaoDavaraCivel { get; set; }

    public int? ObjetoId { get; set; }

    public long? ProcId { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? ProcPetvisivel { get; set; }

    public virtual TribObjeto? Objeto { get; set; }

    public virtual TribProcProcesso? Proc { get; set; }

    public virtual ICollection<TribProcPeticaoCertidao> TribProcPeticaoCertidaos { get; set; } = new List<TribProcPeticaoCertidao>();

    public virtual ICollection<Contribuinte> Cons { get; set; } = new List<Contribuinte>();
}
