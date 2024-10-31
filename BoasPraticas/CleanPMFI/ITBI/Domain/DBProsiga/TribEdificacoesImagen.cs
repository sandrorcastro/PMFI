using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEdificacoesImagen
    {
        public long EdifImgId { get; set; }
        public long EdificacaoId { get; set; }
        public string? EdifImgPadrao { get; set; }
        public DateTime? EdifImgData { get; set; }
        public byte[]? EdifImgImagem { get; set; }
        public string? EdifImgObservacao { get; set; }
        public string? InscricaoSmtr { get; set; }
        public short? EdifImgTipoId { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
    }
}
