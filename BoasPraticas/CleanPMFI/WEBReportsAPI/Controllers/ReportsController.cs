using Microsoft.AspNetCore.Mvc;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace WEBReportsAPI.Controllers
{
    public class ReportsController : Controller
    {
        [HttpGet("RenderReport")]
        public IActionResult RenderReport(string reportName)
        {
            var reportDocument = new ReportDocument();
            reportDocument.Load(Path.Combine("Reports", $"{reportName}.rpt"));

            // Aqui você pode configurar os parâmetros do relatório, a conexão com o banco de dados, etc.

            using var stream = new MemoryStream();
            reportDocument.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat).CopyTo(stream);
            return File(stream.ToArray(), "application/pdf", $"{reportName}.pdf");
        }
    }
}
