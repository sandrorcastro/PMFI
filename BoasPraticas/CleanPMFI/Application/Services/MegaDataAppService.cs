using Application.Interfaces;
using Application.Services.Base;
using Application.ViewModels.MegaData;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;
using Domain.Services.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

namespace Application.Services
{
    public class MegaDataAppService : AppServiceBase<MegaData_NFSE>, IMegaDataAppService
    {
        private readonly IMegaDataService megaDataService;
        //private long ID;

        public MegaDataAppService(IMegaDataService _megaDataService)
            : base(_megaDataService)
        {
            megaDataService = _megaDataService;
        }
        public Task<MegaData_NFSE> AddAsync(MegaData_NFSE entity, CancellationToken cancellationToken = default)
        {
            entity.DataGeracao = DateTime.Now;
            string dtLimpa = new string(entity.DataGeracao.ToString().Where(char.IsDigit).ToArray());
            entity.IDMegaData_NFSE = long.Parse(dtLimpa);              //Guid.NewGuid();
          //  ID = entity.IDMegaData_NFSE;
            return megaDataService.AddAsync(entity, cancellationToken);
        }
        public String ValidarPeriodo(MegaData_NFSE entity)
        {
            if (entity.DataInicioPeriodo < entity.DataFinalPeriodo && entity.DataInicioPeriodo < DateTime.Now && entity.DataFinalPeriodo < DateTime.Now)
            {
                    return "Valido";
                
            }
            else
            {
                return "Invalido";
            }
        }
        public bool ExportarPeriodoNFSE(IWebHostEnvironment environment, NFSEDBContext _NFSEDBContext, MegaData_NFSE entity)
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
                //string pastaDestino = Path.Combine(Directory.GetCurrentDirectory(), "MegaData");
                string pastaDestino = Path.Combine(environment.WebRootPath, "MegaData");

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
        public bool ExportarPeriodo(IWebHostEnvironment environment, NFSEDBContext _NFSEDBContext, MegaData_NFSE entity)
        {
            if (entity.TipoArquivo == "NFSE")
            {
                ExportarPeriodoNFSE(environment,_NFSEDBContext,entity);
                return true;
            }
            if (entity.TipoArquivo == "Contribuinte")
            {
                ExportarPeriodoNFSE(environment, _NFSEDBContext, entity);
                return true;
            }
            if (entity.TipoArquivo == "CartaoCredito")
            {
                ExportarPeriodoNFSE(environment, _NFSEDBContext, entity);
                return true;
            }
            return false;

        }
        public bool EnviarPeriodo(MegaData_NFSE entity)
        {
           
                return true;
           
        }
    }
}
