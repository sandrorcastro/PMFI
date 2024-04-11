using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class AmmConvenioAuxilio2003
{
    public decimal IdPessoa { get; set; }

    public int CdConvenioAuxilio { get; set; }

    public decimal NrAnoInclusao { get; set; }

    public decimal NrBimestreInclusao { get; set; }

    public decimal? CdBanco { get; set; }

    public string? CdAgencia { get; set; }

    public string? CdConta { get; set; }

    public string TpRecurso { get; set; } = null!;

    public string? TpConvenioAuxilio { get; set; }

    public decimal? NrTermo { get; set; }

    public DateTime? DtCelebracao { get; set; }

    public string? TpEsfera { get; set; }

    public DateTime? DtPrazoVigencia { get; set; }

    public string NmOrgaoRepassador { get; set; } = null!;

    public int? NrDoe { get; set; }

    public decimal? NrAnoDoe { get; set; }

    public DateTime? DtPublicacaoDoe { get; set; }

    public decimal VlPrevisto { get; set; }

    public decimal VlRecursoProprio { get; set; }

    public decimal? NrMetaPrevista { get; set; }

    public string? DsUnidadeMedida { get; set; }

    public string StConvenio { get; set; } = null!;

    public DateTime? DtCancelamento { get; set; }

    public decimal? NrBimRecadastramento { get; set; }

    public decimal? NrTransferencia { get; set; }

    public string DsObjetoConvenio { get; set; } = null!;

    public decimal? IdRepassador { get; set; }

    public string? TpRecursoRepassador { get; set; }

    public DateTime? DtInicioVigencia { get; set; }
}
