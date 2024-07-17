using BlazorWebAppITBI.Models;
using Microsoft.FluentUI.AspNetCore.Components;

namespace BlazorWebAppITBI.Uteis
{
    public class GerenciadorDeAnexos
    {
        private Dictionary<string, Dictionary<string, bool>> estadoDosAnexos { get; set; } = new Dictionary<string, Dictionary<string, bool>>();

        public void AdicionarAnexo(string dono, string anexo, bool estado)
        {
            if (!estadoDosAnexos.ContainsKey(dono))
            {
                estadoDosAnexos[dono] = new Dictionary<string, bool>();
            }
            estadoDosAnexos[dono][anexo] = estado;
        }

        public bool PesquisarAnexo(string dono, string anexo)
        {
            if (estadoDosAnexos.TryGetValue(dono, out var anexos))
            {
                if (anexos.TryGetValue(anexo, out var estado))
                {
                    return estado;
                }
            }
            return false; // Retorna null se o transmissor ou o anexo não for encontrado
        }
        public bool RemoverAnexo(string dono, string anexo)
        {
            if (estadoDosAnexos.TryGetValue(dono, out var anexos))
            {
                if (anexos.ContainsKey(anexo))
                {
                    estadoDosAnexos[dono].Remove(anexo);
                }
                if (estadoDosAnexos[dono].Count == 0)
                {
                    estadoDosAnexos.Remove(dono);
                }
                return true;

                /*if (anexos.Remove(anexo))
                {
                    // Se a lista de anexos ficar vazia, remova o dono também
                    if (anexos.Count == 0)
                    {
                        estadoDosAnexos.Remove(dono);
                    }
                    return true;
                }*/
            }
            return false; // Retorna false se o transmissor ou o anexo não for encontrado
        }
        public Icon GetIcon(Anexo anexoSelecionado)
        {
            //return estadoDosAnexos.TryGetValue(anexoSelecionado, out bool isAdded) && isAdded
            //return estadoDosAnexos.TryGetValue(anexoSelecionado., out bool isAdded) && isAdded

            bool result = PesquisarAnexo(anexoSelecionado.pertenceA, anexoSelecionado.Doc.ItbidsDocumento);
            return result ? new Icons.Regular.Size24.SubtractSquare().WithColor(Color.Accent)
              : new Icons.Regular.Size24.AddSquare().WithColor(Color.Accent);
        }
    }
}
