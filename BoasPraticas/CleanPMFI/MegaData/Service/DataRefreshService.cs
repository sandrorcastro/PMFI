using Application.Interfaces;
using Application.Services;
using AutoMapper;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Domain.Interfaces.Services;
using Domain.Services;
using Infrastructure.Context;
using Infrastructure.Repositories;
using System;
using System.Data;

namespace MegaData.Service
{
    public class DataRefreshService : HostedService
    {
        private readonly IMegaDataAppService megaDataAppService;
        private NFSEDBContext _NFSEDBContext;
        //private MegaDataDBContex _MegaDataDBContex;
        private readonly IWebHostEnvironment environment;

 
        
       //public DataRefreshService(IMegaDataAppService _megaDataAppService, NFSEDBContext nFSEDBContext, IWebHostEnvironment _environment)
        public DataRefreshService()
        {
            //megaDataAppService = megaDataAppService;
            megaDataAppService = new MegaDataAppService(new MegaDataService(new MegaDataRepository(new MegaDataDBContext())));
            /*  _NFSEDBContext = nFSEDBContext;
              environment = _environment;*/
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {

            while (!cancellationToken.IsCancellationRequested)
            {
                /* MegaData_NFSE megaData_NFSE= new MegaData_NFSE();
                 megaData_NFSE.DataGeracao = DateTime.Now;
                 string dtLimpa = new string(megaData_NFSE.DataGeracao.ToString().Where(char.IsDigit).ToArray());
                 megaData_NFSE.IDMegaData_NFSE = long.Parse(dtLimpa);              //Guid.NewGuid();
                 if (megaDataAppService.ExportarPeriodo(environment, _NFSEDBContext, megaData_NFSE))
                 {
                     await megaDataAppService.AddAsync(megaData_NFSE);
                   //  this.MostrarMensagem("Período Do Tipo: " + megaData_NFSE.TipoArquivo.ToString() + " Entre: " + megaData_NFSE.DataInicioPeriodo + " a " + megaData_NFSE.DataFinalPeriodo + " Adicionado!");
                 };*/
               // addMegaData_NFSE();
                    await Task.Delay(TimeSpan.FromSeconds(15), cancellationToken);
            }
        }
        public async void addMegaData_NFSE()
        {

             MegaData_NFSE megaData_NFSE= new MegaData_NFSE();
                 megaData_NFSE.DataGeracao = DateTime.Now;
                 megaData_NFSE.DataInicioPeriodo= DateTime.Now.AddDays(-1);
                 megaData_NFSE.DataFinalPeriodo = DateTime.Now.AddMinutes(-1);
                 megaData_NFSE.TipoArquivo = "NFSE";
                 string dtLimpa = new string(megaData_NFSE.DataGeracao.ToString().Where(char.IsDigit).ToArray());
                 megaData_NFSE.IDMegaData_NFSE = long.Parse(dtLimpa);              //Guid.NewGuid();
                 if (megaDataAppService.ExportarPeriodo(this.environment, new NFSEDBContext(), megaData_NFSE))
                 {
                     await megaDataAppService.AddAsync(megaData_NFSE);
                   //  this.MostrarMensagem("Período Do Tipo: " + megaData_NFSE.TipoArquivo.ToString() + " Entre: " + megaData_NFSE.DataInicioPeriodo + " a " + megaData_NFSE.DataFinalPeriodo + " Adicionado!");
                 };



            
                
        }
    }
}
