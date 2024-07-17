using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerCargosServidore
    {
        public TbGerCargosServidore()
        {
            TbParCargosServidoresAssinaturas = new HashSet<TbParCargosServidoresAssinatura>();
        }

        public int IdCargoServidor { get; set; }
        public short? NrAno { get; set; }
        public short? IdEmpresa { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? IdServidor { get; set; }
        public int? IdCargo { get; set; }
        public DateTime? DtInicioAtividade { get; set; }
        public DateTime? DtFimAtividade { get; set; }
        public byte[]? ImAssinatura { get; set; }
        public int? IdLeiAtoNomeacao { get; set; }
        public int? IdLeiAtoBaixa { get; set; }
        public string? DsMotivoBaixa { get; set; }
        public string? FlOrdenadorDespesa { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public string? DsLoginAlteracao { get; set; }

        public virtual TbGerCargo? IdCargoNavigation { get; set; }
        public virtual TbGerEmpresasGoverno? IdEmpresaNavigation { get; set; }
        public virtual TbGerServidore? IdServidorNavigation { get; set; }
        public virtual TbOrcOrgao? TbOrcOrgao { get; set; }
        public virtual ICollection<TbParCargosServidoresAssinatura> TbParCargosServidoresAssinaturas { get; set; }
    }
}
