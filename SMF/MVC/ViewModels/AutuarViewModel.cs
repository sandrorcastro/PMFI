using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using MVC.Extensions;
using System.ComponentModel;

namespace MVC.ViewModels
{
    public class AutuarViewModel
    {
       /* private IPessoaAppService pessoaAppService;
        public AutuarViewModel(long ImovelId, long EconomiaId, long PessoaId )
        {

            this.pessoaAppService = new PessoaAppService();
            Pessoa = pessoaAppService.GetIQueryable().Filter(PessoaId.ToString()).FirstOrDefault();
        }*/
        public Processo Processo { get; set; }
        public Etapa Etapa { get; set; }

        public Pessoa Pessoa { get; set; }
        //public Imovel Imovel { get; set; }

        public Economia Economia { get; set; }

                
    }

    
}
