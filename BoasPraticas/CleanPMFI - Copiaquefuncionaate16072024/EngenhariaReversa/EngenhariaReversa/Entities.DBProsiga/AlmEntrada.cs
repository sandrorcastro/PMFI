using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AlmEntrada
    {
        public AlmEntrada()
        {
            AlmEntradaItens = new HashSet<AlmEntradaIten>();
        }

        public long EntradaId { get; set; }
        public long? AlmoxId { get; set; }
        public long? EntrAlmoxOrigemId { get; set; }
        public long? EntrFornecedorId { get; set; }
        public int? EntrAnoEmpenho { get; set; }
        public int? EntrNumEmpenho { get; set; }
        public DateTime? EntrData { get; set; }
        public long? ServidorId { get; set; }
        public int? EntrModoAquisId { get; set; }
        public int? EntrTipoDoc { get; set; }
        public string? EntrNumDoc { get; set; }
        public DateTime? EntrDataDoc { get; set; }
        public string? EntrObserv { get; set; }

        public virtual Almoxarifado? Almox { get; set; }
        public virtual Almoxarifado? EntrAlmoxOrigem { get; set; }
        public virtual Contribuinte? EntrFornecedor { get; set; }
        public virtual ModoAquisicao? EntrModoAquis { get; set; }
        public virtual Documento? EntrTipoDocNavigation { get; set; }
        public virtual ICollection<AlmEntradaIten> AlmEntradaItens { get; set; }
    }
}
