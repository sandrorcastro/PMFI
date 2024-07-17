﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicNaturezasCargosServidore
    {
        public TbLicNaturezasCargosServidore()
        {
            TbLicAtosNomeacaoComissaoPessoas = new HashSet<TbLicAtosNomeacaoComissaoPessoa>();
            TbLicComposicoesComissaos = new HashSet<TbLicComposicoesComissao>();
        }

        public short IdNaturezaCargoServidor { get; set; }
        public string? NmNaturezaCargoServidor { get; set; }

        public virtual ICollection<TbLicAtosNomeacaoComissaoPessoa> TbLicAtosNomeacaoComissaoPessoas { get; set; }
        public virtual ICollection<TbLicComposicoesComissao> TbLicComposicoesComissaos { get; set; }
    }
}
