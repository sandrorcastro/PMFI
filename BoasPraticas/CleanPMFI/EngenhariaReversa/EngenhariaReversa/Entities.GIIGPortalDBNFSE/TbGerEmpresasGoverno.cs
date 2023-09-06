using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbGerEmpresasGoverno
    {
        public short Idempresa { get; set; }
        public short IdSistema { get; set; }
        /// <summary>
        /// Se é Prefeitura/Câmara/Autarquia/Previência
        /// </summary>
        public string? DsTipoEmpresa { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public byte[]? ImLogoGrande { get; set; }
        public byte[]? ImLogoPequena { get; set; }
        public string? DsNomeLogo { get; set; }
        public string? DsExtensaoLogo { get; set; }
        public string? DsEndereco { get; set; }
        public string? DsEmail { get; set; }
        public string? DsFone { get; set; }
        public string? DsFax { get; set; }
    }
}
