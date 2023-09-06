using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribObjeto
    {
        public TribObjeto()
        {
            TbConSolicitacaoInscricaoCmcdocumentos = new HashSet<TbConSolicitacaoInscricaoCmcdocumento>();
            TribAlvaraTermoDispencas = new HashSet<TribAlvaraTermoDispenca>();
            TribEmpresaAnexos = new HashSet<TribEmpresaAnexo>();
            TribFiscAutoInfracoesAnexos = new HashSet<TribFiscAutoInfracoesAnexo>();
            TribItbiexAnexos = new HashSet<TribItbiexAnexo>();
            TribNotificacaoDa = new HashSet<TribNotificacaoDum>();
            TribNotificacaoDivida = new HashSet<TribNotificacaoDivida>();
            TribProcPeticaos = new HashSet<TribProcPeticao>();
        }

        public int ObjetoId { get; set; }
        public byte[]? ObjConteudo { get; set; }
        public string? ObjExtensao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }

        public virtual ICollection<TbConSolicitacaoInscricaoCmcdocumento> TbConSolicitacaoInscricaoCmcdocumentos { get; set; }
        public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; }
        public virtual ICollection<TribEmpresaAnexo> TribEmpresaAnexos { get; set; }
        public virtual ICollection<TribFiscAutoInfracoesAnexo> TribFiscAutoInfracoesAnexos { get; set; }
        public virtual ICollection<TribItbiexAnexo> TribItbiexAnexos { get; set; }
        public virtual ICollection<TribNotificacaoDum> TribNotificacaoDa { get; set; }
        public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; }
        public virtual ICollection<TribProcPeticao> TribProcPeticaos { get; set; }
    }
}
