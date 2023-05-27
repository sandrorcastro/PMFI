
using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;

namespace MVC.Extensions
{
    public static class ControllerExtensions
    {
        public static void MostrarMensagem(this Controller @this, string texto, bool erro = false)
        {
            @this.TempData["mensagem"] = MensagemViewModel.Serializar(
                texto, erro ? TipoMensagem.Erro : TipoMensagem.Informacao);
        }
    }
}