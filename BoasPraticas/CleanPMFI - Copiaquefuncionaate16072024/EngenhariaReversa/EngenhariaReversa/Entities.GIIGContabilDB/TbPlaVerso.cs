using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaVerso
    {
        public TbPlaVerso()
        {
            TbPlaAcoesMovimentos = new HashSet<TbPlaAcoesMovimento>();
            TbPlaIndicadores = new HashSet<TbPlaIndicadore>();
            TbPlaIndicadoresMovimentos = new HashSet<TbPlaIndicadoresMovimento>();
            TbPlaProgramaIndicadorIdVersaoCancelamentoNavigations = new HashSet<TbPlaProgramaIndicador>();
            TbPlaProgramaIndicadorIdVersaoVinculoNavigations = new HashSet<TbPlaProgramaIndicador>();
            TbPlaProgramas = new HashSet<TbPlaPrograma>();
            TbPlaProgramasMovimentos = new HashSet<TbPlaProgramasMovimento>();
        }

        public int IdVersao { get; set; }
        public short? IdEscopo { get; set; }
        public short? NrVersao { get; set; }
        public int? IdLeiAto { get; set; }
        public int? NrLeiAto { get; set; }
        public short? NrAnoLeiAto { get; set; }
        public DateTime? DtPubLeiAto { get; set; }
        public string? DsStatus { get; set; }
        public string? DsListaOrgaosPermitidos { get; set; }
        public DateTime? DtFinalizacao { get; set; }
        public int? IdAtoAlteracao { get; set; }
        public string? DsLogImportacao { get; set; }

        public virtual TbPlaEscopo? IdEscopoNavigation { get; set; }
        public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; }
        public virtual ICollection<TbPlaIndicadore> TbPlaIndicadores { get; set; }
        public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; }
        public virtual ICollection<TbPlaProgramaIndicador> TbPlaProgramaIndicadorIdVersaoCancelamentoNavigations { get; set; }
        public virtual ICollection<TbPlaProgramaIndicador> TbPlaProgramaIndicadorIdVersaoVinculoNavigations { get; set; }
        public virtual ICollection<TbPlaPrograma> TbPlaProgramas { get; set; }
        public virtual ICollection<TbPlaProgramasMovimento> TbPlaProgramasMovimentos { get; set; }
    }
}
