using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabArqGerArquivo
    {
        public int ArquivoId { get; set; }
        public short? Ano { get; set; }
        public string? Numero { get; set; }
        public string? Especie { get; set; }
        public string? Orgao { get; set; }
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string? Razaosocial { get; set; }
        public string? Cpfcnpj { get; set; }
        public string? Cmc { get; set; }
        public DateTime? InicioAtividades { get; set; }
        public string? Alvara { get; set; }
        public string? Sala { get; set; }
        public string? Bloco { get; set; }
        public string? Corredor { get; set; }
        public string? Caixa { get; set; }
        public string? InformacaoAdicional { get; set; }
        public DateTime DataEntrada { get; set; }
        public int DocumentoId { get; set; }
        public string? TipoArquivo { get; set; }
        public DateTime? PrazoGuarda { get; set; }
        public string? FormatoDocumentoAnexo { get; set; }
        public byte[]? DocumentoAnexo { get; set; }
        public string? DocumentoAnexoData { get; set; }
        public short? FuncId { get; set; }

        public virtual TabArqGerDocumento Documento { get; set; } = null!;
        public virtual TabFuncionario? Func { get; set; }
    }
}
