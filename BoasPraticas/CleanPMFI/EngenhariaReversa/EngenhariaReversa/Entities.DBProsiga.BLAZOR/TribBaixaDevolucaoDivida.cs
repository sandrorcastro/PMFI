﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribBaixaDevolucaoDivida
    {
        public TribBaixaDevolucaoDivida()
        {
            TribBaixaDevolucaoDividasComps = new HashSet<TribBaixaDevolucaoDividasComp>();
        }

        public long DeDiId { get; set; }
        public long BaDeId { get; set; }
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }
        public decimal? DeDiValor { get; set; }
        /// <summary>
        /// Nome do usuário que incluiu o registro.
        /// </summary>
        public string? DeDiUsuarioInclusao { get; set; }
        /// <summary>
        /// Data da inclusão do registro.
        /// </summary>
        public DateTime? DeDiDataInclusao { get; set; }
        /// <summary>
        /// Marca se a devolução vai gerar nova dívida.
        /// </summary>
        public string DeDiGerarNovaDivida { get; set; } = null!;
        public long? ImoIddividaNova { get; set; }
        public long? DivEmpIdnova { get; set; }
        public long? ConIddividaNova { get; set; }
        public long? BaiId { get; set; }

        public virtual TribBaixaDevolucao BaDe { get; set; } = null!;
        public virtual ICollection<TribBaixaDevolucaoDividasComp> TribBaixaDevolucaoDividasComps { get; set; }
    }
}
