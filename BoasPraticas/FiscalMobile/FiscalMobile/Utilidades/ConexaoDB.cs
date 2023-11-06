//using Android.Database.Sqlite;
//using Java.IO;
using FiscalMobile.Context;
using System.Reflection;

namespace FiscalMobile.Utilidades
{
    public class ConexaoDB
    {
        public static string GetRotaConexao(string NomeBaseDados)
        {
            string RotaConexaoBD = string.Empty;
            if(DeviceInfo.Platform == DevicePlatform.Android)
            {
                RotaConexaoBD = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                RotaConexaoBD = Path.Combine(RotaConexaoBD, NomeBaseDados);
               // return RotaConexaoBD;
            }
            else if(DeviceInfo.Platform == DevicePlatform.iOS)
            {
                RotaConexaoBD = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                RotaConexaoBD = Path.Combine(RotaConexaoBD,"..","Library",NomeBaseDados);
                //return RotaConexaoBD;
            }
            else if (DeviceInfo.Platform == DevicePlatform.WinUI)
            {
                RotaConexaoBD = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                RotaConexaoBD = Path.Combine(RotaConexaoBD, "..", "Library", NomeBaseDados);
                //return RotaConexaoBD;
            }
        //    ConexaoDB.copyDBInDataToApp(RotaConexaoBD);
            return RotaConexaoBD;
        }
        public static void copyDBInDataToApp(String rotaConexaoDB)
        {
            if (!File.Exists(rotaConexaoDB))
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                using (Stream stream = assembly.GetManifestResourceStream("FiscalMobile.Data.FiscalMobileDB.db"))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        File.WriteAllBytes(rotaConexaoDB, ms.ToArray());
                    }
                }
            }

        }
        public static void copyDBInAppToData(String rotaConexaoDB)
        {
            if (File.Exists(rotaConexaoDB))
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                // using (Stream stream = assembly.GetManifestResourceStream("FiscalMobile.Data.FiscalMobileDB.db"))
                using (Stream stream = assembly.GetManifestResourceStream(rotaConexaoDB))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        //ms.CopyTo(stream);
                        File.WriteAllBytes("FiscalMobile.Data.FiscalMobileDB-Out.db", ms.ToArray());
                    }
                }
            }

        }

    }
}

/*
if (!File.Exists(ConexaoDB.GetRotaConexao("ImovelCheckInLoco.db")))
{
    var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
    using (Stream stream = assembly.GetManifestResourceStream("FiscalMobile.Data.ImovelCheckInLoco.db"))
    {
        using (MemoryStream ms = new MemoryStream())
        {
            stream.CopyTo(ms);
            File.WriteAllBytes(ConexaoDB.GetRotaConexao("ImovelCheckInLoco.db"), ms.ToArray());
        }
    }
}*/




      /*  public static void copiaBanco(ImovelCheckDBContext ctx, String nomeDB)
        {

            // Cria o banco vazio
            SQLiteDatabase db = ctx.openOrCreateDatabase(
              nomeDB, Context.MODE_WORLD_WRITEABLE, null);

            db.close();

            try
            {
                // Abre o arquivo que deve estar na pasta assets
                InputStream is = ctx.getAssets().open(nomeDB);
                // Abre o arquivo do banco vazio ele fica em:
                // /data/data/nome.do.pacote.da.app/databases
                FileOutputStream fos = new FileOutputStream(
                  ctx.getDatabasePath(nomeDB));

                // Copia byte a byte o arquivo do assets para
                // o aparelho/emulador
                byte[] buffer = new byte[1024];
                int read;
                while ((read = is.read(buffer)) > 0)
                {
                    fos.write(buffer, 0, read);
                }
            }
            catch (IOException e)
            {
                e.printStackTrace();
            }
        }*/
