using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class LrfOcorrenciasTributosExercicio2008
    {
        public long? IdPessoa { get; set; }
        public string? CdTributo { get; set; }
        public long? NrContribuinteSaldoAntArrecadar { get; set; }
        public long? NrContribuinteLancadoExercicio { get; set; }
        public long? NrContribuinteArrecPgtoTotal { get; set; }
        public long? NrContribuinteArrecPgtoParcial { get; set; }
        public long? NrContribuinteDeducoesTotal { get; set; }
        public long? NrContribuinteDeducoesParcial { get; set; }
        public long? NrContribuinteInscricaoDividaAtiva { get; set; }
    }
}
