using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTiposServico
    {
        public TribTiposServico()
        {
            TribEmpresasServicos = new HashSet<TribEmpresasServico>();
            Atividades = new HashSet<TribAtivAtividade>();
        }

        public string ServId { get; set; } = null!;
        public string ServDescricao { get; set; } = null!;
        public string ServPeriodo { get; set; } = null!;
        public decimal ServAliquota { get; set; }
        /// <summary>
        /// deve ser informado se este serviço deve ou não ser enquadrado como micro empresa
        /// </summary>
        public string ServEnquadraMicroEmpresa { get; set; } = null!;
        /// <summary>
        /// Aliquota para O ISS FIXO
        /// </summary>
        public decimal? ServAliquotaFixa { get; set; }
        public bool? ServFlAtivo { get; set; }

        public virtual ICollection<TribEmpresasServico> TribEmpresasServicos { get; set; }

        public virtual ICollection<TribAtivAtividade> Atividades { get; set; }
    }
}
