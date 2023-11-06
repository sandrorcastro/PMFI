using FiscalMobile.Context;
using FiscalMobile.Utilidades;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System.Reflection;
namespace FiscalMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           // ConexaoDB.copyDBInDataToApp(ConexaoDB.GetRotaConexao("FiscalMobileDB.db"));
           // ConexaoDB.copyDBInAppToData(ConexaoDB.GetRotaConexao("FiscalMobileDB.db"));




            if (!File.Exists(ConexaoDB.GetRotaConexao("FiscalMobileDB.db")))
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                using (Stream stream = assembly.GetManifestResourceStream("FiscalMobile.Data.FiscalMobileDB.db"))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        File.WriteAllBytes(ConexaoDB.GetRotaConexao("FiscalMobileDB.db"), ms.ToArray());
                    }
                }
            }
            var fc = new FiscalMobileDBContext();
            //   fc.PerfilApp.Add(new Models.PerfilApp { IdPerfilApp = 1, Nome = "Sandro Ronaldo de Castro", Matricula = "2289401", Email = "sandrorcastro@hotmail.com", Telefone = "45999565299" });
            //   fc.SaveChanges();
            var listperfil = fc.PerfilApp.ToList();
            fc.Dispose();
            /* if (File.Exists(ConexaoDB.GetRotaConexao("FiscalMobileDB.db")))
            {
                string internalDBPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "FiscalMobileDB.db");
                //string externalDBPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "FiscalMobileDBOut.db");


                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                using (Stream stream = assembly.GetManifestResourceStream(ConexaoDB.GetRotaConexao("FiscalMobileDB.db")))
                
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        File.WriteAllBytes("FiscalMobile.Data.FiscalMobileDBOut.db", ms.ToArray());
                    }
                }
            }*/


            /* if (File.Exists(ConexaoDB.GetRotaConexao("FiscalMobileDB.db")))
             {
                 var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                 using (Stream stream = assembly.GetManifestResourceStream(ConexaoDB.GetRotaConexao("FiscalMobileDB.db")))
                 {
                     using (MemoryStream ms = new MemoryStream())
                     {
                         stream.CopyTo(ms);
                         File.WriteAllBytes("FiscalMobile.Data.FiscalMobileDBOut.db", ms.ToArray());
                     }
                 }
             }*/

            MainPage = new AppShell();
        }
    }
}