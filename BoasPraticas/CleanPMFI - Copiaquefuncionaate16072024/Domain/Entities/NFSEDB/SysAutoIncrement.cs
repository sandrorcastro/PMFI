using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class SysAutoIncrement
    {
        public string SysTableName { get; set; } = null!;
        public long? SysTableKeyValue { get; set; }
    }
}
