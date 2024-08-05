using Application.Interfaces.DBProsiga;
using Application.Services.DBProsiga;
using BlazorWebAppITBI.Model;
using Domain.Entities.DBProsiga;
using FastReport;
using FastReport.Export.PdfSimple;// .Pdf;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Options;
using System.Data;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
namespace BlazorWebAppITBI.Uteis
{
    public class ReportService
    {
       // IOptions<AppSettings> AppSettings;
        //ReportService(IOptions<AppSettings> _AppSettings) { AppSettings = _AppSettings; }
//        ReportService() {  }

        public async Task<byte[]> GenerateReportAsync()
        {
            using (var report = new Report())
            {
                // Carregar o arquivo de relatório (.frx)
                report.Load("path/to/your/report.frx");

                // Configurar dados para o relatório, se necessário
                // Exemplo: report.RegisterData(dataSet, "Data");

                // Preparar o relatório
                report.Prepare();

                // Exportar o relatório para PDF
                using (var export = new PDFSimpleExport()) // PDFExport())
                using (var ms = new MemoryStream())
                {
                    report.Export(export, ms);
                    return ms.ToArray();
                }
            }
        }
        public async Task<byte[]> GenerateReportAsync(string reportPath)
        {

            using (var report = new Report())
            {
                // Carregar o arquivo de relatório (.frx)
                report.Load(reportPath);

                // Configurar dados para o relatório, se necessário
                // Exemplo: report.RegisterData(dataSet, "Data");

                // Preparar o relatório
                report.Prepare();

                // Exportar o relatório para PDF
                using (var export = new PDFSimpleExport()) // PDFExport())
                using (var ms = new MemoryStream())
                {
                    report.Export(export, ms);
                    return ms.ToArray();
                }
            }
        }
        public async Task  CreateReportAsync(string reportPath, TribItbiedif itbiedif)
        {
            using (var report = new Report())
            {
                //report.Dictionary.RegisterBusinessObject(itbiedif, "itbiedif", 10, true);
                DataTable dataTable = new DataTable("TribItbiedif");
                // Adicione colunas ao DataTable
                foreach (PropertyInfo prop in typeof(TribItbiedif).GetProperties())
                {
                    dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                // Adicione uma linha ao DataTable
                DataRow row = dataTable.NewRow();
                foreach (PropertyInfo prop in typeof(TribItbiedif).GetProperties())
                {
                    row[prop.Name] = prop.GetValue(itbiedif) ?? DBNull.Value;
                }
                dataTable.Rows.Add(row);
                //report.Dictionary.RegisterBusinessObject((dataTable, "itbiedif", 10, true);

                report.Dictionary.RegisterData(dataTable, "TribItbiEdif", true);


           
                //ds.AddChild(itbiedif);
                //report.RegisterData(ds);
                //report.Dictionary.DataSources.Add(dataTable);
                //ds.Tables.Add(itbiedif)
                //report.RegisterData(itbiedif, "Data");
                report.Save(reportPath);
                //return true;
            }
            //return false;
        }
        public async Task<byte[]> GenerateReportAsync(string reportPath, TribItbiedif itbiedif,TribItbi itbi,TribDividasImo dividaimo,TribBoleto boleto, TribBoletosBarra boletoBarra)
        //public async Task<byte[]> GenerateReportAsync(string reportPath, TribItbiedif itbiedif)
        {
            using (var report = new Report())
            {
                report.Load(reportPath);
                ////////////////////
                DataTable dataTableItbi = new DataTable("TribItbi");
                // Adicione colunas ao DataTable TribItbi
                foreach (PropertyInfo prop in typeof(TribItbi).GetProperties())
                {
                    dataTableItbi.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                // Adicione uma linha ao DataTable TribItbi
                DataRow rowItbi = dataTableItbi.NewRow();
                foreach (PropertyInfo prop in typeof(TribItbi).GetProperties())
                {
                    rowItbi[prop.Name] = prop.GetValue(itbi) ?? DBNull.Value;
                }
                dataTableItbi.Rows.Add(rowItbi);
                ////////////////////

                DataTable dataTableItbiEdif = new DataTable("TribItbiedif");
                // Adicione colunas ao DataTable TribItbiEdif
                foreach (PropertyInfo prop in typeof(TribItbiedif).GetProperties())
                {
                    dataTableItbiEdif.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                // Adicione uma linha ao DataTable TribItbiEdif
                DataRow rowItbiEdif = dataTableItbiEdif.NewRow();
                foreach (PropertyInfo prop in typeof(TribItbiedif).GetProperties())
                {
                    rowItbiEdif[prop.Name] = prop.GetValue(itbiedif) ?? DBNull.Value;
                }
                dataTableItbiEdif.Rows.Add(rowItbiEdif);


                ////////////////////

                DataTable dataTableDividaImo = new DataTable("TribDividaImo");
                TribDividasImo tribDividaImo = itbiedif.ImoIddividaNavigation;
                // Adicione colunas ao DataTable TribDividaImo
                foreach (PropertyInfo prop in typeof(TribDividasImo).GetProperties())
                {
                    dataTableDividaImo.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                // Adicione uma linha ao DataTable TribDividaImo
                DataRow rowDividaImo = dataTableDividaImo.NewRow();
                foreach (PropertyInfo prop in typeof(TribDividasImo).GetProperties())
                {
                    //rowDividaImo[prop.Name] = prop.GetValue(dividaimo) ?? DBNull.Value;
                    //ou
                    rowDividaImo[prop.Name] = prop.GetValue(tribDividaImo) ?? DBNull.Value;
                }
                dataTableDividaImo.Rows.Add(rowDividaImo);


                //////////////////////
                DataTable dataTableBoletosDivida = new DataTable("TribBoletosDivida");
                // Adicione colunas ao DataTable TribBoletosDivida
                TribBoletosDivida tribBoletosDivida = itbiedif.ImoIddividaNavigation.TribBoletosDivida.FirstOrDefault();
                foreach (PropertyInfo prop in typeof(TribBoletosDivida).GetProperties())
                {
                    dataTableBoletosDivida.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                // Adicione uma linha ao DataTable TribItbiEdif
                DataRow rowTribBoletosDivida = dataTableBoletosDivida.NewRow();
                foreach (PropertyInfo prop in typeof(TribBoletosDivida).GetProperties())
                {
                    rowTribBoletosDivida[prop.Name] = prop.GetValue(tribBoletosDivida) ?? DBNull.Value;
                }
                dataTableBoletosDivida.Rows.Add(rowTribBoletosDivida);

                //////////////////////
                DataTable dataTableBoleto = new DataTable("TribBoleto");
                // Adicione colunas ao DataTable TribBoleto
                //TribBoleto tribBoleto = itbiedif.ImoIddividaNavigation.TribBoletosDivida.
                //TribBoleto tribBoleto = dividaimo.TribBoletosDivida.
                                                         //.Where(b => b.BoleNossoNumero == b.BoleNossoNumeroNavigation.BoleNossoNumero).Any();
                foreach (PropertyInfo prop in typeof(TribBoleto).GetProperties())
                {
                    dataTableBoleto.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                // Adicione uma linha ao DataTable TribBoleto
                DataRow rowTribBoleto = dataTableBoleto.NewRow();
                foreach (PropertyInfo prop in typeof(TribBoleto).GetProperties())
                {
                    rowTribBoleto[prop.Name] = prop.GetValue(boleto) ?? DBNull.Value;
                }
                dataTableBoleto.Rows.Add(rowTribBoleto);


                //////////////////////
                DataTable dataTableBoletoBarra = new DataTable("TribBoletoBarra");
                // Adicione colunas ao DataTable TribBoletoBarra
                //TribBoleto tribBoleto = itbiedif.ImoIddividaNavigation.TribBoletosDivida.
                //TribBoleto tribBoleto = dividaimo.TribBoletosDivida.
                //.Where(b => b.BoleNossoNumero == b.BoleNossoNumeroNavigation.BoleNossoNumero).Any();
                foreach (PropertyInfo prop in typeof(TribBoletosBarra).GetProperties())
                {
                    dataTableBoletoBarra.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                // Adicione uma linha ao DataTable TribBoletoBarra
                DataRow rowTribBoletoBarra = dataTableBoletoBarra.NewRow();
                foreach (PropertyInfo prop in typeof(TribBoletosBarra).GetProperties())
                {
                    rowTribBoletoBarra[prop.Name] = prop.GetValue(boletoBarra) ?? DBNull.Value;
                }
                dataTableBoletoBarra.Rows.Add(rowTribBoletoBarra);



                report.Dictionary.RegisterData(dataTableItbi, "TribItbi", true);
                report.Dictionary.RegisterData(dataTableItbiEdif, "TribItbiEdif", true);
                report.Dictionary.RegisterData(dataTableDividaImo, "TribDividaImo", true);
                report.Dictionary.RegisterData(dataTableBoletosDivida, "TribBoletosDivida", true);
                report.Dictionary.RegisterData(dataTableBoleto, "TribBoleto", true);
                report.Dictionary.RegisterData(dataTableBoletoBarra, "TribBoletoBarra", true);
                // report.Save(reportPath);
                report.Prepare();

                // Exportar o relatório para PDF
                using (var export = new PDFSimpleExport()) // PDFExport())
                using (var ms = new MemoryStream())
                {
                    report.Export(export, ms);
                    return ms.ToArray();
                }
            }
            //return false;
        }
        public async Task<byte[]> GenerateReportAsync2(string reportPath,TribItbiedif itbiedif)
        {

            using (var report = new Report())
            {
                // Carregar o arquivo de relatório (.frx)
                report.Load(reportPath);

                // Configurar dados para o relatório, se necessário
                //report.RegisterData(itbiedif, "Data");
                report.Dictionary.RegisterBusinessObject((System.Collections.IEnumerable)itbiedif, "itbiedif", 10, true);
              //  report.Save(reportPath);
                // Preparar o relatório
                report.Prepare();

                // Exportar o relatório para PDF
                using (var export = new PDFSimpleExport()) // PDFExport())
                using (var ms = new MemoryStream())
                {
                    report.Export(export, ms);
                    return ms.ToArray();
                }
            }
        }
        public async Task<byte[]> GetDadosGUIAbyImoIdDivida(string reportPath, TribItbiedif itbiedif)
        {

            using (var report = new Report())
            {

                //string connectionString = AppSettings.Value.ConnectionString;
                string connectionString = "Data Source=172.27.1.98;Initial Catalog=DBProsiga;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=usergiigteste;Password=PMFI@dien";

                // Defina o nome da stored procedure
                string storedProcedureName = "dbo.ITBIGetDadosGUIAbyImoIdDivida";

                // Defina os parâmetros da stored procedure, se houver
                SqlParameter[] parameters = {
                new SqlParameter("@ImoIdDivida", SqlDbType.BigInt) { Value = itbiedif.ImoIddivida }};
                DataTable dataTableGuiaITBI = new DataTable("GuiaITBI");
                // Carregar o arquivo de relatório (.frx)
                report.Load(reportPath);
                dataTableGuiaITBI = GetDataFromStoredProcedure(connectionString, storedProcedureName, parameters);
            /*    foreach (DataRow row in dataTableGuiaITBI.Rows)
                {
                    foreach (DataColumn column in dataTableGuiaITBI.Columns)
                    {
                        Console.Write(row[column] + "\t");
                    }
                   // Console.WriteLine();
                }*/
                report.Dictionary.RegisterData(dataTableGuiaITBI, "GuiaITBI", true);
              //  report.Save(reportPath);
                report.Prepare();


               

                // Exportar o relatório para PDF
                using (var export = new PDFSimpleExport()) // PDFExport())
                using (var ms = new MemoryStream())
                {
                    report.Export(export, ms);
                    return ms.ToArray();
                }
            }
        }
        public async Task<byte[]> ImprimirCertidaoPgto(string reportPath, TribItbiedif itbiedif)
        {
            var ReportName = reportPath;
            using (var report = new Report())
            {









                using (var export = new PDFSimpleExport()) // PDFExport())
                using (var ms = new MemoryStream())
                {
                    report.Export(export, ms);
                    return ms.ToArray();
                }

            }

        }
        /// <summary>
        /// //Não usado, apenas para melhorar futuramente
        /// </summary>
        /// <param name="tribItbiedif"></param>
        /// <returns></returns>
        public static DataTable ConvertToDataTable(TribItbiedif tribItbiedif)
        {
            DataTable dataTable = new DataTable("TribItbiedif");

            // Adicione colunas ao DataTable
            foreach (PropertyInfo prop in typeof(TribItbiedif).GetProperties())
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // Adicione uma linha ao DataTable
            DataRow row = dataTable.NewRow();
            foreach (PropertyInfo prop in typeof(TribItbiedif).GetProperties())
            {
                row[prop.Name] = prop.GetValue(tribItbiedif) ?? DBNull.Value;
            }
            dataTable.Rows.Add(row);

            return dataTable;
        }
        public static DataTable GetDataFromStoredProcedure(string connectionString, string storedProcedureName, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
