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
    }
}
