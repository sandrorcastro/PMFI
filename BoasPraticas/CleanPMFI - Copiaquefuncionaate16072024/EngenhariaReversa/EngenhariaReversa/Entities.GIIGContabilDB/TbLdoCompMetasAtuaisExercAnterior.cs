using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLdoCompMetasAtuaisExercAnterior
    {
        public int IdCompMetasAtuais { get; set; }
        public int? IdEmpresa { get; set; }
        public short? NrAnoLdo { get; set; }
        public short? NrAnoReferencia { get; set; }
        public decimal? VlRecTotalCorrente { get; set; }
        public decimal? VlRecTotalConstante { get; set; }
        public decimal? VlRecPrimCorrente { get; set; }
        public decimal? VlRecPrimConstante { get; set; }
        public decimal? VlDespTotalCorrente { get; set; }
        public decimal? VlDespTotalConstante { get; set; }
        public decimal? VlDespPrimCorrente { get; set; }
        public decimal? VlDespPrimConstante { get; set; }
        public decimal? VlResNomCorrente { get; set; }
        public decimal? VlResNomConstante { get; set; }
        public decimal? VlDivPublicaCorrente { get; set; }
        public decimal? VlDivPublicaConstante { get; set; }
        public decimal? VlDivConsLiqCorrente { get; set; }
        public decimal? VlDivConsLiqConstante { get; set; }
    }
}
