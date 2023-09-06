using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class SysAutoIncrementSequence
    {
        public string SysTableName { get; set; } = null!;
        public short SysYear { get; set; }
        public long? SysTableSequence { get; set; }
    }
}
