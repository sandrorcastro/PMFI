using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SimAmOcorrenciasTributoDum
{
    public long IdLcto { get; set; }

    public string? Cnpjfilial { get; set; }

    public long? IdPessoa { get; set; }

    public long? CdTributo { get; set; }

    public long? NrContribuinteSaldoAntArrecadar { get; set; }

    public long? NrContribuinteDividaAtiva { get; set; }

    public long? NrContribuinteJurosAtualiza { get; set; }

    public long? NrContribuinteExpontaneoPgtoTotal { get; set; }

    public long? NrContribuinteExpontaneoPgtoParcial { get; set; }

    public long? NrContribuinteAdministrativoPgtoTotal { get; set; }

    public long? NrContribuinteAdministrativoPgtoParcial { get; set; }

    public long? NrContribuinteJudicialPgtoTotal { get; set; }

    public long? NrContribuinteJudicialPgtoParcial { get; set; }

    public long? NrContribuinteCancelamentoTotal { get; set; }

    public long? NrContribuinteCancelamentoParcial { get; set; }

    public long? NrContribuinteSaldoExercSeguinteDividaAtiva { get; set; }

    public long? IdTributo { get; set; }

    public long? Bimestre { get; set; }

    public long? Ano { get; set; }
}
