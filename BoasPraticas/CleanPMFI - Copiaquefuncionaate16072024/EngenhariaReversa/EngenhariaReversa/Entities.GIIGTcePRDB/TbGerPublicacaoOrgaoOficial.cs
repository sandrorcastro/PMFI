using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerPublicacaoOrgaoOficial
    {
        public int IdPublicacao { get; set; }
        public short? IdEmpresa { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmPessoa { get; set; }
        public int? IdLeiAto { get; set; }
        public DateTime? DtPublicacao { get; set; }
        public string? NrPagina { get; set; }
        public string? NrOrgaoOficial { get; set; }
        public DateTime? DtBaseTce { get; set; }

        public virtual TbGerLeiAto? IdLeiAtoNavigation { get; set; }
    }
}
