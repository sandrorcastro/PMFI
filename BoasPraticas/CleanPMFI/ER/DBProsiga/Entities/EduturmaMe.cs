﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class EduturmaMe
{
    public long TurmaId { get; set; }

    public long TurmaMes { get; set; }

    public long FxEtId { get; set; }

    public int? TurmaMqtdeMasculino { get; set; }

    public int? TurmaMqtdeFeminino { get; set; }

    public virtual EdufaixaEtarium FxEt { get; set; } = null!;

    public virtual Eduturma Turma { get; set; } = null!;
}
