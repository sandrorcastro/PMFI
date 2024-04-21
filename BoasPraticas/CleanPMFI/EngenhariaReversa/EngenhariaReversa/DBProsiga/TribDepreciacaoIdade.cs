using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDepreciacaoIdade
    {
        public int DePrecId { get; set; }
        public int? TparamId { get; set; }
        public int? ParamId { get; set; }
        public int DePrecDe { get; set; }
        public int DePrecAte { get; set; }
        public decimal DePrecAliquota { get; set; }

        public virtual TribParamCalculo? TribParamCalculo { get; set; }
    }
}
