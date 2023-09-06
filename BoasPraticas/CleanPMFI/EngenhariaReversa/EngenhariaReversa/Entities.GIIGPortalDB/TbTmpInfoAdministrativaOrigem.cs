using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpInfoAdministrativaOrigem
    {
        public int Id { get; set; }
        public short? Ano { get; set; }
        public short? Mes { get; set; }
        public int? NumCargosComissaoCriados { get; set; }
        public int? NumCargosComissaoPreenchidos { get; set; }
        public int? NumCargosEfetivosCriados { get; set; }
        public int? NumCargosEfetivosPreenchidos { get; set; }
        public int? NumEmpregosPublicosCriados { get; set; }
        public int? NumEmpregosPublicosPreenchidos { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DataInclusao { get; set; }
    }
}
