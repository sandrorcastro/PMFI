using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FztipoCredencial
    {
        /// <summary>
        /// Código de Identificação do Tipo de Credenciamento
        /// </summary>
        public int CredenTipoId { get; set; }
        /// <summary>
        /// Descrição do Nome do Tipo de Credenciamento. Podem ser por Empresa [SocioProprietario-Empregado-Turnante] e por Veículo[Permissionario-Colaborador-Auxiliar].
        /// </summary>
        public string CredenTipoNome { get; set; } = null!;
        /// <summary>
        /// Define se o tipo da Credencial Exige Curso 0-Não Exige Curso para liberacao Credencial. Códigos 1a 5 de Tipo Credencial não utilizados atualmente.
        /// </summary>
        public int? ExigeCursoCodigo { get; set; }
        public int? TmpCredTipoAnterior { get; set; }
        public int CredentialTipoAnterior { get; set; }
        public string CredencialNomeAnterior { get; set; } = null!;
    }
}
