using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerOrgaoOficialPublicacao
    {
        public TbGerOrgaoOficialPublicacao()
        {
            TbCapConvAuxProgramas = new HashSet<TbCapConvAuxPrograma>();
            TbCntAtosContratuaisPublicacos = new HashSet<TbCntAtosContratuaisPublicaco>();
            TbCntContratosPublicacaos = new HashSet<TbCntContratosPublicacao>();
        }

        public int IdOrgaoOficial { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdPessoa { get; set; }
        public short? IdTipoOrgaoOficial { get; set; }
        public short? IdVeiculoPublicacao { get; set; }
        public int? IdLicitacao { get; set; }
        public int? IdLeiAto { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFinal { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsMotivoBaixa { get; set; }
        public DateTime? DtReferenciaTce { get; set; }

        public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }
        public virtual TbGerPessoa? IdPessoaNavigation { get; set; }
        public virtual TbLicVeiculosPublicaco? IdVeiculoPublicacaoNavigation { get; set; }
        public virtual ICollection<TbCapConvAuxPrograma> TbCapConvAuxProgramas { get; set; }
        public virtual ICollection<TbCntAtosContratuaisPublicaco> TbCntAtosContratuaisPublicacos { get; set; }
        public virtual ICollection<TbCntContratosPublicacao> TbCntContratosPublicacaos { get; set; }
    }
}
