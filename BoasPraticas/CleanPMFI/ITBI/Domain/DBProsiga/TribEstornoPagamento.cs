using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEstornoPagamento
    {
        public long EstPagId { get; set; }
        /// <summary>
        /// Código de identificação da dívida.
        /// </summary>
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public DateTime? EstPagDataEstorno { get; set; }
        public string? EstPagMotivo { get; set; }
        public int? ConvenioId { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        /// <summary>
        /// ID da nova Divida gerada
        /// </summary>
        public long? ImoIddividaGerada { get; set; }
        /// <summary>
        /// ID da nova Divida gerada
        /// </summary>
        public long? ConIddividaGerada { get; set; }
        /// <summary>
        /// ID da nova Divida gerada
        /// </summary>
        public long? DivEmpIdgerada { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual ConvenioBanco? Convenio { get; set; }
        public virtual TribDividasEmpresa? DivEmp { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
    }
}
