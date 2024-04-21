using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class DbDefragComplete
    {
        public string? TableOwner { get; set; }
        public string? TableName { get; set; }
        public string? TableIndexName { get; set; }
        public double? AvgFragmentationInPercent { get; set; }
        public long Rows { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
