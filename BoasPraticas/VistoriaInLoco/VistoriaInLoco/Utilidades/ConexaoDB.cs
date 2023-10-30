using Android.Database.Sqlite;
using Java.IO;
using VistoriaInLoco.Context;

namespace VistoriaInLoco.Utilidades
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
            return RotaConexaoBD;
        }
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
    }
}
