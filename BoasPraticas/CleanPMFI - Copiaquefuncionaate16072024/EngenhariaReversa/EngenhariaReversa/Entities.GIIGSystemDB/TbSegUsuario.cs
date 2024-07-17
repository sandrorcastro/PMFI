using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegUsuario
    {
        public TbSegUsuario()
        {
            TbSegUsuariosEmpresasModulos = new HashSet<TbSegUsuariosEmpresasModulo>();
            IdAplicativos = new HashSet<TbGerAplicativo>();
        }

        public string DsLogin { get; set; } = null!;
        public string? NmUsuario { get; set; }
        public string? FlTipoInativo { get; set; }
        public string? DsEmail { get; set; }
        public string? DsFone { get; set; }
        public DateTime? DtValidadeSenha { get; set; }
        public byte[]? BnSenha { get; set; }
        /// <summary>
        /// Esse campo é utilizado para dar permissão automática para formulários cadastrados no sistema.
        /// </summary>
        public string FlAdministrador { get; set; } = null!;
        public string? DsSituacao { get; set; }
        public short? IdEmpresaPadrao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public DateTime? DtInativacao { get; set; }
        public string? DsChavePublica { get; set; }
        public string? DsLoginInclusao { get; set; }
        public string? NrCpfcnpj { get; set; }

        public virtual TbSegEmpresasGoverno? IdEmpresaPadraoNavigation { get; set; }
        public virtual ICollection<TbSegUsuariosEmpresasModulo> TbSegUsuariosEmpresasModulos { get; set; }

        public virtual ICollection<TbGerAplicativo> IdAplicativos { get; set; }
    }
}
