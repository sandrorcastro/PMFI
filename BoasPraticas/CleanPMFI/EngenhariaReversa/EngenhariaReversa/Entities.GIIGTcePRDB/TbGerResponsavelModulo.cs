using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerResponsavelModulo
    {
        public TbGerResponsavelModulo()
        {
            TbGerBaixaResponsavelModulos = new HashSet<TbGerBaixaResponsavelModulo>();
        }

        public int IdResponsavel { get; set; }
        public short? IdEmpresa { get; set; }
        public int? CdOperacao { get; set; }
        public short? IdTipoDocumento { get; set; }
        public string? NrDocumento { get; set; }
        public string? NmResponsavel { get; set; }
        public short? IdTipoModulo { get; set; }
        public DateTime? DtInicioVinculo { get; set; }
        public short? IdTipoResponsavel { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? NrEnderecoIp { get; set; }

        public virtual ICollection<TbGerBaixaResponsavelModulo> TbGerBaixaResponsavelModulos { get; set; }
    }
}
