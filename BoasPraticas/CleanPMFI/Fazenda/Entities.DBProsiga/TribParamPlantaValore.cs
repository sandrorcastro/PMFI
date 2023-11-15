using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fazenda.Entities.DBProsiga;

public partial class TribParamPlantaValore
{
    [Key]
    public int Idplanta { get; set; }
    [Key]
    public int TparamId { get; set; }
    [Key]
    public int ParamId { get; set; }

}
