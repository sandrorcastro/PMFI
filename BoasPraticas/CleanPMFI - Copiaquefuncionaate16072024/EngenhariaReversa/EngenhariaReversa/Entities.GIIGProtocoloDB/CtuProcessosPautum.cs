using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class CtuProcessosPautum
    {
        public int Id { get; set; }
        public int IdPauta { get; set; }
        public int IdProcesso { get; set; }
        public string Resposta { get; set; } = null!;
        public string? Final { get; set; }
        public int? Unanimidade { get; set; }
        public string? ResponsavelTecnico { get; set; }
        public string? Local { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Zona { get; set; }
        public string? Legislacao { get; set; }
        public string? ConsideracoesGerais { get; set; }
        public int? Homologado { get; set; }
        public string? UsuarioHomologacao { get; set; }
        public string? DataHomologacao { get; set; }
    }
}
