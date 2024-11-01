﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Chat
{
    public int ChatNumLanc { get; set; }

    public string? ChatUsuId { get; set; }

    public DateTime? ChatData { get; set; }

    public string? ChatMensagem { get; set; }

    public string? ChatHorario { get; set; }

    public string? ChatRemetente { get; set; }

    public virtual Usuario? ChatUsu { get; set; }
}
