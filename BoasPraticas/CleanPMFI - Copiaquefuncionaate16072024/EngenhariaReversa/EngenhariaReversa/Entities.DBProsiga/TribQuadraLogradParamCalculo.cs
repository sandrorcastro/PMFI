﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribQuadraLogradParamCalculo
    {
        public int QuadraId { get; set; }
        public int LogradId { get; set; }
        public int TparamId { get; set; }
        public int ParamId { get; set; }
        public int? Valor { get; set; }
    }
}
