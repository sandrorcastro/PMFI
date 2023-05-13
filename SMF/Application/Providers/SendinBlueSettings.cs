﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Providers
{
    public class SendinBlueSettings
    {
        public string NomeRemetente { get; set; }
        public string EmailRemetente { get; set; }
        public string Senha { get; set; }
        public string EnderecoServidor { get; set; }
        public int PortaServidor { get; set; }
        public bool UsarSsl { get; set; }
    }
}
