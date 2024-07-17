using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.MegaData
{
    public class LayoutContribuinte_MegaData
    {
        //AnoAberturaEmpresa	MesAberturaEmpresa	CodigoTom	CNPJ_Contribuinte	Situacao	RazaoSocial	Inicio	Fim	ContribuinteEstimado	CNAES	VLRESTIMADO	DTEXPORTACAO	ENDERECO	EmailContribuinte
        public int? AnoAberturaEmpresa { get;set; }
        public int? MesAberturaEmpresa { get; set; }
        public string CodigoTom { get; set; }
        public string? CNPJ_Contribuinte { get; set; }
        public int Situacao { get; set; }
        public string? RazaoSocial { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public int ContribuinteEstimado { get; set; }
        public string? CNAES { get; set; }
        public long VLRESTIMADO { get; set; }
        public string? DTEXPORTACAO { get; set; }
        public string? ENDERECO { get; set; }
        public string? EmailContribuinte { get; set; }
    }
}
