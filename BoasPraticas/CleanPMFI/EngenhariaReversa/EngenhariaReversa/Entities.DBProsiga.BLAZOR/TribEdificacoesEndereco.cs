using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEdificacoesEndereco
    {
        public int EnderecoId { get; set; }
        public long? EdificacaoId { get; set; }
        public int? LogradId { get; set; }
        public int? Idloteamento { get; set; }
        public string? Cep { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        /// <summary>
        /// Responsável ou pessoa do endereço
        /// </summary>
        public long? ConId { get; set; }
        public string? Correspondencia { get; set; }
        public string? LocalizacaoImovel { get; set; }
        public int? CidadeId { get; set; }
        public string? CaixaPostal { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual TribEdificaco? Edificacao { get; set; }
    }
}
