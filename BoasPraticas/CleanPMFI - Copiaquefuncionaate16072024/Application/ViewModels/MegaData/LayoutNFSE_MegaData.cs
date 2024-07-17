using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.MegaData
{
    public class LayoutNFSE_MegaData
    {
        //STCPFCNPJ ANO MES NUMERO  SITUACAO LOCALTRIBUTACAO SERVICO116 ISSRETIDO   BASECALCULO ALIQUOTA    VLRISS VLRISSRETIDO    CMEPRESTADOR CPFCNPJTOMADOR  NOMETOMADOR TOM EXIGIBILIDADE DEDUCOES    VLRSERVICO CDVERIFICACAO
        public string? Stcpfcnpj { get; set; }
        public string? Ano { get; set; }
        public int? Mes { get; set; }
        public int? Numero { get; set; }
        public int Situacao { get; set; }
        public int Localtributacao { get; set; }
        public string? Servico116 { get; set; }
        public int Issretido { get; set; }
        public string? Basecalculo { get; set; }
        public string? Aliquota { get; set; }
        public string? Vlriss { get; set; }
        public string? Vlrissretido { get; set; }
        public string? Cmeprestador { get; set; }
        public string? Cpfcnpjtomador { get; set; }
        public string? Nometomador { get; set; }
        public int Tom { get; set; }
        public int Exigibilidade { get; set; }
        public string? Deducoes { get; set; }
        public string? Vlrservico { get; set; }
        public string? Cdverificacao { get; set; }
    }
}
