using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ModoAquisicao
    {
        public ModoAquisicao()
        {
            Acessorios = new HashSet<Acessorio>();
            AlmEntrada = new HashSet<AlmEntrada>();
            ImobensImoveis = new HashSet<ImobensImovei>();
        }

        public int ModAid { get; set; }
        public string? ModAnome { get; set; }
        public int? MacodTribunal { get; set; }

        public virtual ICollection<Acessorio> Acessorios { get; set; }
        public virtual ICollection<AlmEntrada> AlmEntrada { get; set; }
        public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; }
    }
}
