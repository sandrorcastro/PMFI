using System.Reflection;
using VistoriaInLoco.Utilidades;

namespace VistoriaInLoco
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (!File.Exists(ConexaoDB.GetRotaConexao("ImovelCheckInLoco.db")))
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                using (Stream stream = assembly.GetManifestResourceStream("VistoriaInLoco.Data.ImovelCheckInLoco.db"))
                {
                    using(MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        File.WriteAllBytes(ConexaoDB.GetRotaConexao("ImovelCheckInLoco.db"), ms.ToArray());
                    }
                }
            }






            MainPage = new AppShell();
        }
    }
}