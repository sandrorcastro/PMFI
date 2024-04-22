﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TempTribEdificacoesEndereco
    {
        public int EnderecoId { get; set; }
        public long? EdificacaoId { get; set; }
        public int? LogradId { get; set; }
        public int? Idloteamento { get; set; }
        public string? Cep { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public long? ConId { get; set; }
        public string? Correspondencia { get; set; }
        public string? LocalizacaoImovel { get; set; }
        public int? CidadeId { get; set; }
        public string? CaixaPostal { get; set; }
    }
}
