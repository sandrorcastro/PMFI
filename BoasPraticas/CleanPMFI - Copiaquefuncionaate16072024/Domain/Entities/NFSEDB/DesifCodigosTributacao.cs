﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DesifCodigosTributacao
    {
        public string Stcodtribdesif { get; set; } = null!;
        public string Stdesctrib { get; set; } = null!;
        public int? Stsubitemlista { get; set; }
    }
}
