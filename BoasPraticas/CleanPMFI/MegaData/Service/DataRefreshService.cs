using Application.Interfaces;
using Application.Services;
using Application.ViewModels.MegaData;
using AutoMapper;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Domain.Interfaces.Services;
using Domain.Services;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Text;

namespace MegaData.Service
{
    public class DataRefreshService : HostedService
    {
        private readonly IMegaDataAppService megaDataAppService;
        private NFSEDBContext _NFSEDBContext;
        private MegaDataDBContext _MegaDataDBContext;
        //private MegaDataDBContex _MegaDataDBContex;
        private readonly IWebHostEnvironment environment;

 
        
       //public DataRefreshService(IMegaDataAppService _megaDataAppService, NFSEDBContext nFSEDBContext, IWebHostEnvironment _environment)
        public DataRefreshService()
        {
            //megaDataAppService = megaDataAppService;
            megaDataAppService = new MegaDataAppService(new MegaDataService(new MegaDataRepository(new MegaDataDBContext())));
            /*  _NFSEDBContext = nFSEDBContext;
              environment = _environment;*/
            _MegaDataDBContext = new MegaDataDBContext();
            _NFSEDBContext= new NFSEDBContext();
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
                addMegaData_NFSE();
                    await Task.Delay(TimeSpan.FromSeconds(15), cancellationToken);
            }
        }
        public async void addMegaData_NFSE()
        {

             MegaData_NFSE megaData_NFSE= new MegaData_NFSE();
                 megaData_NFSE.DataGeracao = DateTime.Now;
            //megaData_NFSE.DataInicioPeriodo= DateTime.Now.AddDays(-1);
            //megaData_NFSE.DataFinalPeriodo = DateTime.Now.AddMinutes(-1);
            megaData_NFSE.DataInicioPeriodo= DateTime.Now.AddDays(-60);
            megaData_NFSE.DataFinalPeriodo = DateTime.Now.AddDays(-59);
            megaData_NFSE.TipoArquivo = "NFSE";
                 string dtLimpa = new string(megaData_NFSE.DataGeracao.ToString().Where(char.IsDigit).ToArray());
                 megaData_NFSE.IDMegaData_NFSE = long.Parse(dtLimpa);              //Guid.NewGuid();
                 if (this.ExportarPeriodoNFSE(megaData_NFSE))
                 {
                //     await megaDataAppService.AddAsync(megaData_NFSE);
                //  this.MostrarMensagem("Período Do Tipo: " + megaData_NFSE.TipoArquivo.ToString() + " Entre: " + megaData_NFSE.DataInicioPeriodo + " a " + megaData_NFSE.DataFinalPeriodo + " Adicionado!");
                 await  _MegaDataDBContext.AddAsync(megaData_NFSE);
                 _MegaDataDBContext.SaveChangesAsync();
                };

          // await  _MegaDataDBContext.AddAsync(megaData_NFSE);
           // _MegaDataDBContext.SaveChangesAsync();
                
        }
        public bool ExportarPeriodoNFSE(MegaData_NFSE entity)
        {
            var query = (from n in _NFSEDBContext.NfseTblNfses
                         join empresa in _NFSEDBContext.NfseTblEmpresas on n.Idempresa equals empresa.Idempresa
                         join contribuinte in _NFSEDBContext.NfseTblContribuintes on empresa.Idcontribuinte equals contribuinte.Idcontribuinte
                         where n.Dtcompetencia >= entity.DataInicioPeriodo && n.Dtcompetencia < entity.DataFinalPeriodo && n.Stsituacao != "A"
                         //where n.Dtcompetencia >= dti && n.Dtcompetencia < dtf && n.Stsituacao != "A"

                         //select new LayoutNFSE_MegaData { Ano = n.Dtcompetencia.ToString(), Numero = n.Nunumero });
                         select new LayoutNFSE_MegaData
                         {
                             Stcpfcnpj = contribuinte.Idcontribuinte.ToString(),
                             Ano = n.Dtcompetencia.Value.Year.ToString(),
                             Mes = int.Parse(n.Dtcompetencia.Value.Month.ToString()),
                             Numero = n.Nunumero,
                             Situacao = 1,
                             //Localtributacao=n.Idoperacao
                             Servico116 = n.Idservico,
                             Issretido = n.Stissretido == "S" ? 1 : 0,
                             Basecalculo = n.Vlbasecalculo.ToString(),
                             Aliquota = n.Pcaliquota.ToString(),
                             Vlriss = n.Stissretido == "N" ? n.Vltotaliss.ToString() : "0",   ///
                             Vlrissretido = n.Stissretido == "S" ? n.Vlissretido.ToString() : "0",  ////
                             Cmeprestador = n.StpreIm,
                             Cpfcnpjtomador = n.SttomPessoaTipo,
                             Nometomador = n.SttomNome,
                             Tom = 7563,
                             //Exigibilidade=int.Parse(n.Idoperacao),
                             Deducoes = n.Vldeducoes.ToString(),
                             Vlrservico = n.Vlservicos.ToString(),
                             Cdverificacao = n.Stcodigo
                         });
            StringBuilder builder = new StringBuilder();
            //percore os funcionarios e gera o CSV
            foreach (var n in query.ToList())
            {
                //builder.AppendLine($"n.Stcpfcnpj;{n.Dtcompetencia:yyyy};{n.Dtcompetencia:MM};{n.Nunumero};{1};{n.Idoperacao};{n.Idservico};{n.Stissretido};{n.Stissretido};{n.StpreIm};{n.SttomPessoaTipo};{n.SttomNome};{7563};{n.Idoperacao};{n.Vldeducoes};{n.Vlservicos};{n.Stcodigo}");
                builder.AppendLine($"{n.Stcpfcnpj};{n.Ano};{n.Mes};{n.Numero};{1};{n.Localtributacao};{n.Servico116};{n.Issretido};{n.Basecalculo};{n.Aliquota};{n.Vlriss};{n.Vlrissretido};{n.Cmeprestador};{n.Cpfcnpjtomador};{n.Nometomador};{7563};{n.Exigibilidade};{n.Deducoes};{n.Vlrservico};{n.Cdverificacao}");
            }
            // Simulando a criação de um FileContentResult (substitua isso pelo seu próprio FileContentResult)
            byte[] fileBytes = System.Text.Encoding.UTF8.GetBytes(builder.ToString());
            var fileResult = new FileContentResult(fileBytes, "text/csv")
            {
                FileDownloadName = $"{entity.IDMegaData_NFSE}.txt"
            };

            // Caminho para a pasta onde você deseja salvar o arquivo
            string pastaDestino = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/MegaData");
            //string pastaDestino = Path.Combine(environment.WebRootPath, "MegaData");

            // Garanta que a pasta de destino exista, crie-a se necessário
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            // Caminho completo do arquivo de destino
            string caminhoCompleto = Path.Combine(pastaDestino, fileResult.FileDownloadName);

            // Salve os bytes do arquivo no arquivo de destino
            System.IO.File.WriteAllBytes(caminhoCompleto, fileResult.FileContents);
            entity.NomeArquivo = fileResult.FileDownloadName;
            entity.CaminhoArquivo = caminhoCompleto;
            return true;
        }
    }
}
