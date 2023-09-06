using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerConsorciosMunicipio
    {
        public int IdConsorcio { get; set; }
        public short? IdEmpresa { get; set; }
        public short? IdEmpresaConsorcio { get; set; }
        public int? CdOperacao { get; set; }
        public DateTime? DtInicioVinculo { get; set; }
        public int? IdLeiAto { get; set; }
        public short? IdTipoAreaConsorcio { get; set; }
        public short? IdTipoNaturezaJuridica { get; set; }
        public int? IdLeiAtoBaixa { get; set; }
        public DateTime? DtBaixa { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtBaseTce { get; set; }

        public virtual TbGerTiposAreaConsorcio? IdTipoAreaConsorcioNavigation { get; set; }
        public virtual TbGerTiposNaturezaJuridicaConsorcio? IdTipoNaturezaJuridicaNavigation { get; set; }
    }
}
