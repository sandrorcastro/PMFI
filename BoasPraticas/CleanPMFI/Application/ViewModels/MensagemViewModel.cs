﻿
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public enum TipoMensagem
    {
        Informacao,
        Erro
    }
    public class MensagemViewModel
    {

        public TipoMensagem Tipo { get; set; }
       public string Texto { get; set; }
        public MensagemViewModel(string mensagem,TipoMensagem tipo = TipoMensagem.Informacao)
        {
            this.Tipo = tipo;
            this.Texto= mensagem;
        }
        public static string Serializar(string mensagem, TipoMensagem tipo = TipoMensagem.Informacao)
        {
            var mensagemModel = new MensagemViewModel(mensagem, tipo);
            return JsonConvert.SerializeObject(mensagemModel);
        }

        public static MensagemViewModel Desserializar(string mensagemString)
        {
            return JsonConvert.DeserializeObject<MensagemViewModel>(mensagemString);
        }
    }
}
