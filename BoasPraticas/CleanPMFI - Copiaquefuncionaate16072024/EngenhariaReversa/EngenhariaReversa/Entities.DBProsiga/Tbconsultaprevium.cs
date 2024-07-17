using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Tbconsultaprevium
    {
        public Tbconsultaprevium()
        {
            Tbconsultapreviadocumentoresposta = new HashSet<Tbconsultapreviadocumentoresposta>();
            Tbconsultapreviadocumentos = new HashSet<Tbconsultapreviadocumento>();
            Tbconsultapreviagrauriscoresposta = new HashSet<Tbconsultapreviagrauriscoresposta>();
            Tbconsultapreviagrauriscos = new HashSet<Tbconsultapreviagraurisco>();
            Tbconsultapreviazoneamentoresposta = new HashSet<Tbconsultapreviazoneamentoresposta>();
        }

        public int Idconsulta { get; set; }
        public string? Nrinscricaoimobiliaria { get; set; }
        public DateTime? Dtconsulta { get; set; }
        public string? Nrprotocolo { get; set; }
        public short? Zozoid { get; set; }
        public short? Idtipoempresa { get; set; }
        public bool? Fldomiciliotributario { get; set; }
        public string? Nrcpfcnpj { get; set; }
        public string? Nmempresa { get; set; }
        public string? Dstelefonecontato { get; set; }
        public decimal? Vlareacoberta { get; set; }
        public string? Dsendereco { get; set; }
        public string? Nrcep { get; set; }
        public int? Idusuarioinclusao { get; set; }
        /// <summary>
        /// Situação da Consulta: Deferida, Indeferida, Aguardando Análise, Constituida
        /// </summary>
        public string? Flsituacao { get; set; }
        /// <summary>
        /// Indica se a consulta está sendo realizada por um contador.
        /// </summary>
        public bool? Flcontador { get; set; }
        public string? Nrcpfcnpjsolicitante { get; set; }
        public string? Nmsolicitante { get; set; }

        public virtual ICollection<Tbconsultapreviadocumentoresposta> Tbconsultapreviadocumentoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviadocumento> Tbconsultapreviadocumentos { get; set; }
        public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviagraurisco> Tbconsultapreviagrauriscos { get; set; }
        public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; }
    }
}
