using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class OuvidoriaProcesso
    {
        public OuvidoriaProcesso()
        {
            OuvidoriaProcessosAcos = new HashSet<OuvidoriaProcessosAco>();
        }

        public long IdouvProcesso { get; set; }
        public long? ConId { get; set; }
        public string? OrigemSolicitacao { get; set; }
        public string? Controle { get; set; }
        public int IdouvOrgao { get; set; }
        public int IdouvServico { get; set; }
        public DateTime? DtRegistro { get; set; }
        public long? ProcId { get; set; }
        public string? TpIdentContrib { get; set; }
        public string? NmContrib { get; set; }
        public string? EnderecoContrib { get; set; }
        public string? NumeroContrib { get; set; }
        public string? Cepcontrib { get; set; }
        public string? EmailContrib { get; set; }
        public string? FoneContrib { get; set; }
        public string? BairroContrib { get; set; }
        public string? CidadeContrib { get; set; }
        public string? Ufcontrib { get; set; }
        public string? TipoSolicitacao { get; set; }
        public string? ComplSolicitacao { get; set; }
        public string? InformarAndamento { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual OuvidoriaOrgao IdouvOrgaoNavigation { get; set; } = null!;
        public virtual OuvidoriaServico IdouvServicoNavigation { get; set; } = null!;
        public virtual Processo? Proc { get; set; }
        public virtual ICollection<OuvidoriaProcessosAco> OuvidoriaProcessosAcos { get; set; }
    }
}
