using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class CampoOutrasInfSemMsgTributacaoFora
    {
        public string? PrestadorCmc { get; set; }
        public string? PrestadorCnpj { get; set; }
        public string? PrestadorRazaoSocial { get; set; }
        public int? Totalnotas { get; set; }
    }
}
