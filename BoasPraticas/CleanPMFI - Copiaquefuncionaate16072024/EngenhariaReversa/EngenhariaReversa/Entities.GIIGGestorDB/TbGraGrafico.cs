using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGGestorDB
{
    public partial class TbGraGrafico
    {
        public int IdGrafico { get; set; }
        public string? NmGrafico { get; set; }
        public int IdVisao { get; set; }
        public string? XvalueMember { get; set; }
        public string? YvalueMembers { get; set; }
        public short? ChartType { get; set; }
        public bool? FlRecursiveChart { get; set; }
        public bool? FlMostrarLegenda { get; set; }
        public string? DsOperador { get; set; }
        public string? NmFieldId { get; set; }
        public string? NmFieldIdFilter { get; set; }
        public bool? FlChart3D { get; set; }

        public virtual TbGraVisaoFonteDado IdVisaoNavigation { get; set; } = null!;
    }
}
