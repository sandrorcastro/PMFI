using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabFuncionario
    {
        public TabFuncionario()
        {
            TabArqGerArquivos = new HashSet<TabArqGerArquivo>();
            TabArquivos = new HashSet<TabArquivo>();
            TabMensagemDestinos = new HashSet<TabMensagemDestino>();
            TabMensagems = new HashSet<TabMensagem>();
            TabMovimentoFuncDespachouNavigations = new HashSet<TabMovimento>();
            TabMovimentoFuncRecebeuNavigations = new HashSet<TabMovimento>();
        }

        public short FuncId { get; set; }
        public string? FuncMatricula { get; set; }
        public string? FuncNome { get; set; }
        public short? UnidId { get; set; }
        public string? FuncResponsavel { get; set; }
        public string? FuncUsuario { get; set; }
        public string? FuncSenha { get; set; }
        /// <summary>
        /// (A = Ativo, B = Bloqueado)
        /// </summary>
        public string? FuncUsuarioSituacao { get; set; }
        public string? FuncEmail { get; set; }
        public string? FuncPerfil { get; set; }
        public string? FuncRecebeEmail { get; set; }
        public string? FuncAtivo { get; set; }
        public string? FuncCargo { get; set; }
        public string? FuncFuncao { get; set; }
        public bool? FuncAlowAlter { get; set; }
        public bool? FuncAlowDespachar { get; set; }
        public byte[]? FuncSenhaDespacho { get; set; }
        public int? Idusuario { get; set; }

        public virtual TabUnidade? Unid { get; set; }
        public virtual ICollection<TabArqGerArquivo> TabArqGerArquivos { get; set; }
        public virtual ICollection<TabArquivo> TabArquivos { get; set; }
        public virtual ICollection<TabMensagemDestino> TabMensagemDestinos { get; set; }
        public virtual ICollection<TabMensagem> TabMensagems { get; set; }
        public virtual ICollection<TabMovimento> TabMovimentoFuncDespachouNavigations { get; set; }
        public virtual ICollection<TabMovimento> TabMovimentoFuncRecebeuNavigations { get; set; }
    }
}
