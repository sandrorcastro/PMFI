using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribEmpresasfEmpresa
    {
        public int? IdCmcempresa { get; set; }
        public string? DsCnpjcpf { get; set; }
        public string? DsRazaoSocial { get; set; }
        public string? DsNomeFantasia { get; set; }
        public int? IdLogradouro { get; set; }
        public string? DsNumeroEndereco { get; set; }
        public int? IdBairro { get; set; }
        public int? IdCidade { get; set; }
        public int? IdTipoEmpresa { get; set; }
        public int? IdConstituicao { get; set; }
        public int? IdSituacao { get; set; }
        public int? IdCaracteristica { get; set; }
        public string? DsDomicilioTributario { get; set; }
        public string? DsEnquadraSimples { get; set; }
        public int? IdRegime { get; set; }
        public string? DsTipoPrestacao { get; set; }
    }
}
