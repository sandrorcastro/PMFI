using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFpgGrupoPessoalNatureza
    {
        public int IdGrupoNaturezas { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? CdNatDespesa { get; set; }
        public short? IdGrupo { get; set; }
        public bool? FlComputa13 { get; set; }

        public virtual TbFpgGruposPessoal? IdGrupoNavigation { get; set; }
    }
}
