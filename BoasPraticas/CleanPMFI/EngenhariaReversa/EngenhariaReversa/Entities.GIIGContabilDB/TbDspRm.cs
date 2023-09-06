﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspRm
    {
        public TbDspRm()
        {
            TbDspRmsItens = new HashSet<TbDspRmsIten>();
            TbDspRmsMovimentos = new HashSet<TbDspRmsMovimento>();
            TbDspSolicitacoesEmpenhos = new HashSet<TbDspSolicitacoesEmpenho>();
        }

        public int IdRms { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public int? NrSequencial { get; set; }
        public int? IdDotacao { get; set; }
        public int? IdNatDespesa { get; set; }
        public DateTime? DtRms { get; set; }
        public int? IdRecurso { get; set; }
        public short? IdSetorCompra { get; set; }
        public decimal? VlRms { get; set; }
        public string? DsSituacao { get; set; }
        public string? DsJustificativa { get; set; }
        public string? DsParecer { get; set; }
        public DateTime? DtAnalise { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? IdSubAcaoTarefa { get; set; }
        public short? IdTipoProcesso { get; set; }
        public int? IdProcAdm { get; set; }

        public virtual TbOrcDotaco? IdDotacaoNavigation { get; set; }
        public virtual TbDspSetoresCompra? IdSetorCompraNavigation { get; set; }
        public virtual TbWflTiposProcesso? IdTipoProcessoNavigation { get; set; }
        public virtual ICollection<TbDspRmsIten> TbDspRmsItens { get; set; }
        public virtual ICollection<TbDspRmsMovimento> TbDspRmsMovimentos { get; set; }
        public virtual ICollection<TbDspSolicitacoesEmpenho> TbDspSolicitacoesEmpenhos { get; set; }
    }
}
