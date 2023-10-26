using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Vistoria.Data
{
    public class ImovelService
    {
       

        public async Task<Imovel> GetImovelAsync(string inscricao)
        {

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };
            using (var reader = new StreamReader("C:\\Mobile\\Vistoria\\Vistoria\\wwwroot\\Imoveis.txt"))
            using (var csv = new CsvReader(reader, config))
            {
                //csv.Context.RegisterClassMap();
                //var imoveis = csv.GetRecordsAsync();
                csv.Context.RegisterClassMap<ImovelMap>();
                var ImovelB = new Imovel();
                ImovelB.inscricao = inscricao;
                Imovel imovelE = (Imovel) csv.GetRecord<Imovel>(ImovelB);
                return imovelE;
                //foreach (var imovel in imoveis)
                  //  Console.WriteLine($"Imovel: {imovel.InscricaoImobiliaria}, Clínica: {imovel.conNome}");
            }


            //return null;
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
            */
        }
    }
}