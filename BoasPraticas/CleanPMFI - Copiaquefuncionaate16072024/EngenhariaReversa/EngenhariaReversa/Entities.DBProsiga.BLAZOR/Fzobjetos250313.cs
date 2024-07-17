using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    /// <summary>
    /// Backup de FZObjetos com Conversao para Credencial
    /// </summary>
    public partial class Fzobjetos250313
    {
        public int ObjetoId { get; set; }
        public long? ObjOrigemId { get; set; }
        public string? ObjOrigemTipo { get; set; }
        public string? ObjNome { get; set; }
        public string? ObjLegenda { get; set; }
        public string? ObjTipoImagem { get; set; }
        public byte[]? ObjImagem { get; set; }
        public string? ObjObservacoes { get; set; }
        public DateTime? ObjDtGravacao { get; set; }
        public string? ObjUsuario { get; set; }
        public long? ObjOrigemIdAnterior { get; set; }
    }
}
