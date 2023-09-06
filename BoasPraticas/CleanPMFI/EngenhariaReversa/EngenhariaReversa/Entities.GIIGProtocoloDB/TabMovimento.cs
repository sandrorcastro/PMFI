using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabMovimento
    {
        public TabMovimento()
        {
            InverseMoviIdAnteriorNavigation = new HashSet<TabMovimento>();
            TabAnexos = new HashSet<TabAnexo>();
            TabAtributoMovimentos = new HashSet<TabAtributoMovimento>();
            TabProtocolos = new HashSet<TabProtocolo>();
        }

        public long MoviId { get; set; }
        public DateTime? MoviData { get; set; }
        public long? ProcId { get; set; }
        public short? UnidId { get; set; }
        public string? MoviParecer { get; set; }
        /// <summary>
        /// (Público, Privado)
        /// </summary>
        public string? MoviTipoAcesso { get; set; }
        public string MoviRecebido { get; set; } = null!;
        public DateTime? MoviRecebidoData { get; set; }
        public string? MoviDespachado { get; set; }
        public short? FuncRecebeu { get; set; }
        public short? FuncDespachou { get; set; }
        public short? FuncPrivado { get; set; }
        public string? MoviNulo { get; set; }
        public long? MoviIdAnterior { get; set; }
        public int? MoviFuncExcluiu { get; set; }
        public DateTime? MoviDataExcluido { get; set; }
        public string? MoviParecerExcluiu { get; set; }
        public int? NrPaginas { get; set; }
        public DateTime? Dtassinatura { get; set; }

        public virtual TabFuncionario? FuncDespachouNavigation { get; set; }
        public virtual TabFuncionario? FuncRecebeuNavigation { get; set; }
        public virtual TabMovimento? MoviIdAnteriorNavigation { get; set; }
        public virtual TabProcesso? Proc { get; set; }
        public virtual TabUnidade? Unid { get; set; }
        public virtual ICollection<TabMovimento> InverseMoviIdAnteriorNavigation { get; set; }
        public virtual ICollection<TabAnexo> TabAnexos { get; set; }
        public virtual ICollection<TabAtributoMovimento> TabAtributoMovimentos { get; set; }
        public virtual ICollection<TabProtocolo> TabProtocolos { get; set; }
    }
}
