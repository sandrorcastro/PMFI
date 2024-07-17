using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class SysAutoIncrement
    {
        public string SysTableName { get; set; } = null!;
        public long? SysTableKeyValue { get; set; }
    }
}
