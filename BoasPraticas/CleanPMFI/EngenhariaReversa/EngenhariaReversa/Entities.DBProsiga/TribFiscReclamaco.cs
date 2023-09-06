using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscReclamaco
    {
        public long ReclId { get; set; }
        public int TipoFiscId { get; set; }
        public long ConId { get; set; }
        public long? IdLogradouro { get; set; }
        public string? ReclNumero { get; set; }
        public string? ReclComplemento { get; set; }
        public string? ReclTelefoneContato { get; set; }
        public long? IdBairro { get; set; }
        public string? ReclDados { get; set; }
        public string? ReclRetorno { get; set; }
        public string ReclStatus { get; set; } = null!;
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? Finalizado { get; set; }
        public long? IdLogradTransversal1 { get; set; }
        public long? IdLogradTransversal2 { get; set; }
        public long? IdCidade { get; set; }
        public long? IdFiscal { get; set; }
        public string? DsNotificacao { get; set; }
        public string? NrCep { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public int? ReclSequencia { get; set; }
        public int? ReclAno { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
        public virtual TribFiscTipoFiscal TipoFisc { get; set; } = null!;
    }
}
