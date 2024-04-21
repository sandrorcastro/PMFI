using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasParamCalc
    {
        public TribEmpresasParamCalc()
        {
            TribAtivTributosEmpresas = new HashSet<TribAtivTributosEmpresa>();
            TribEmpresasTributos = new HashSet<TribEmpresasTributo>();
        }

        public int ParamCalcId { get; set; }
        public string? ParamCalcNome { get; set; }
        public string? ParamCalcDescricao { get; set; }

        public virtual ICollection<TribAtivTributosEmpresa> TribAtivTributosEmpresas { get; set; }
        public virtual ICollection<TribEmpresasTributo> TribEmpresasTributos { get; set; }
    }
}
