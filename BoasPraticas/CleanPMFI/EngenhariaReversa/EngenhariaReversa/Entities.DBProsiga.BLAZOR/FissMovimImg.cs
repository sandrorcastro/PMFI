﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissMovimImg
    {
        public long MovImgId { get; set; }
        public long? MovId { get; set; }
        public byte[]? MovImgImg { get; set; }

        public virtual FissMovim? Mov { get; set; }
    }
}
