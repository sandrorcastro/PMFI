using Microsoft.EntityFrameworkCore.ChangeTracking;
using PMFI.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PMFI.Infra.Entities
{
    public class AuditEntry
    {
        public AuditEntry(EntityEntry entry) => Entry = entry;

        public EntityEntry Entry { get; }
        public string UserId { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, object> KeyValues { get; } = new();
        public Dictionary<string, object> OldValues { get; } = new();
        public Dictionary<string, object> NewValues { get; } = new();
        public AuditType AuditType { get; set; }
        public List<string> ChangedColumns { get; } = new();

        public Auditoria ToAudit()
        {
            var audit = new Auditoria
            {
                Id = Guid.NewGuid(),
                UserId = UserId,
                Type = AuditType.ToString(),
                TableName = TableName,
                DateTime = DateTime.Now,
                PrimaryKey = JsonSerializer.Serialize(KeyValues),
                OldValues = OldValues.Count == 0 ? null : JsonSerializer.Serialize(OldValues),
                NewValues = NewValues.Count == 0 ? null : JsonSerializer.Serialize(NewValues),
                AffectedColumns = ChangedColumns.Count == 0 ? null : JsonSerializer.Serialize(ChangedColumns)
            };

            return audit;
        }
    }
}
