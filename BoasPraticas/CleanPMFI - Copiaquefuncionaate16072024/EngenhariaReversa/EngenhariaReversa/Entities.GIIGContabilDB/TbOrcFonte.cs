using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcFonte
    {
        public TbOrcFonte()
        {
            TbDspDespesaExtraOrcamentaria = new HashSet<TbDspDespesaExtraOrcamentarium>();
            TbFinContrapartidasOpCreditoIdFonteContraPartidaNavigations = new HashSet<TbFinContrapartidasOpCredito>();
            TbFinContrapartidasOpCreditoIdFonteOpCreditoNavigations = new HashSet<TbFinContrapartidasOpCredito>();
            TbLdoLimitesAnuals = new HashSet<TbLdoLimitesAnual>();
            TbOrcDotacos = new HashSet<TbOrcDotaco>();
            TbOrcReceitasFontes = new HashSet<TbOrcReceitasFonte>();
            TbRecMovimentoReceitasDetalheDesmembras = new HashSet<TbRecMovimentoReceitasDetalheDesmembra>();
        }

        public int IdFonte { get; set; }
        public short IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string CdFonte { get; set; } = null!;
        public string? DsFonte { get; set; }
        public string? FlPadraoTce { get; set; }
        public string? DsTipoFonte { get; set; }
        public decimal? VlSaldoInicial { get; set; }
        public int? IdFonteSuperior { get; set; }
        public string? DsFonteRecurso { get; set; }
        public DateTime? DtCadastro { get; set; }

        public virtual ICollection<TbDspDespesaExtraOrcamentarium> TbDspDespesaExtraOrcamentaria { get; set; }
        public virtual ICollection<TbFinContrapartidasOpCredito> TbFinContrapartidasOpCreditoIdFonteContraPartidaNavigations { get; set; }
        public virtual ICollection<TbFinContrapartidasOpCredito> TbFinContrapartidasOpCreditoIdFonteOpCreditoNavigations { get; set; }
        public virtual ICollection<TbLdoLimitesAnual> TbLdoLimitesAnuals { get; set; }
        public virtual ICollection<TbOrcDotaco> TbOrcDotacos { get; set; }
        public virtual ICollection<TbOrcReceitasFonte> TbOrcReceitasFontes { get; set; }
        public virtual ICollection<TbRecMovimentoReceitasDetalheDesmembra> TbRecMovimentoReceitasDetalheDesmembras { get; set; }
    }
}
