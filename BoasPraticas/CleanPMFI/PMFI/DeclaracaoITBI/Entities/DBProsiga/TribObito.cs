using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribObito
{
    public int ObitoId { get; set; }

    public long? ObitoNum { get; set; }

    public string? ObitoFalecido { get; set; }

    public string? ObitoFalecidoCpf { get; set; }

    public string? ObitoIdadeFalecido { get; set; }

    public DateTime? ObitoData { get; set; }

    public byte? CausaMorteId { get; set; }

    public string? ObitoFalecidoFiliacao { get; set; }

    public string? ObitoFalecidoProfissao { get; set; }

    public string? ObitoLocalFalecimento { get; set; }

    public string? ObitoLocalVelorio { get; set; }

    public string? ObitoLocalSepultamento { get; set; }

    public DateTime? ObitoDataSepultamento { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public virtual TribCausasMorte? CausaMorte { get; set; }
}
