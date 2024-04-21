using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Loteamento
    {
        public Loteamento()
        {
            Fzpontos = new HashSet<Fzponto>();
            ImobensImoveis = new HashSet<ImobensImovei>();
            Imoveis = new HashSet<Imovei>();
            TribAmostraMercados = new HashSet<TribAmostraMercado>();
            TribEdificacos = new HashSet<TribEdificaco>();
            TribQuadraLograds = new HashSet<TribQuadraLograd>();
        }

        public int Idloteamento { get; set; }
        public string? Descricao { get; set; }
        public int? Idregiao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? Host { get; set; }
        public DateTime? Data { get; set; }

        public virtual Regio? IdregiaoNavigation { get; set; }
        public virtual ICollection<Fzponto> Fzpontos { get; set; }
        public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; }
        public virtual ICollection<Imovei> Imoveis { get; set; }
        public virtual ICollection<TribAmostraMercado> TribAmostraMercados { get; set; }
        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
        public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; }
    }
}
