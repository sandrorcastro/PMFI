using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbdoctosPermissionarioTaxiAto
    {
        public int PermTaxiAtosId { get; set; }
        public int? TbdoctosReferenciaId { get; set; }
        public int? PessoaId { get; set; }
        /// <summary>
        /// Nome do Permissionario cfe docto Elvis. Por diversas razoes muitos nomes nao são coincidentes. Acentos, Cedilhas, Brancos, erro digitacao, etc.
        /// </summary>
        public string? PessoaNome { get; set; }
        public string? PessoaCpf { get; set; }
        public DateTime? PessoaDtNascto { get; set; }
        public int? TipoPontoId { get; set; }
        public int? NrPontoDecreto { get; set; }
        public int? PontoId { get; set; }
        public int? TermoPermNr { get; set; }
        public DateTime? TermoPermDtDocto { get; set; }
        /// <summary>
        /// Numero do Diario Oficial do Municipio no qual foi publicado do Termo de Permissao
        /// </summary>
        public int? TermoPermDiarioOficial { get; set; }
        public DateTime? TermoPermDtPublicacao { get; set; }
        public string? PermTaxiAtosObs { get; set; }
    }
}
