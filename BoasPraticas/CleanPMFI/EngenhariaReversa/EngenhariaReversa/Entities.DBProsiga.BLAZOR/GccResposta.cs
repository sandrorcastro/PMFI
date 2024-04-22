using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class GccResposta
    {
        public GccResposta()
        {
            GccMovtoQuests = new HashSet<GccMovtoQuest>();
        }

        public string RespCnpjmembro { get; set; } = null!;
        public int RespQuestId { get; set; }
        public int RespPergId { get; set; }
        public int RespId { get; set; }
        public string? RespDescrResp { get; set; }

        public virtual GccPergunta Resp { get; set; } = null!;
        public virtual ICollection<GccMovtoQuest> GccMovtoQuests { get; set; }
    }
}
