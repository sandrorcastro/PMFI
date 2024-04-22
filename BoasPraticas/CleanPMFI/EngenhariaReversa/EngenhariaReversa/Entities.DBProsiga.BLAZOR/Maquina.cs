﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Maquina
    {
        public Maquina()
        {
            MaquinasUsuarios = new HashSet<MaquinasUsuario>();
        }

        public string Ip { get; set; } = null!;
        public string? Departamento { get; set; }
        public string? Ramal { get; set; }
        public string? Andar { get; set; }
        public string? Host { get; set; }
        public string? Local { get; set; }
        public DateTime? Data { get; set; }
        public string? HostCad { get; set; }

        public virtual ICollection<MaquinasUsuario> MaquinasUsuarios { get; set; }
    }
}
