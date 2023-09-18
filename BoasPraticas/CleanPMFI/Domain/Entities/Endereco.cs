using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Endereco
    {
        public Endereco() { }
        public long IdEndereco { get; set; }
        public int IdLogradouro { get; set; }
        public virtual Logradouro Logradouro { get; set; }
        public int? IdCidade { get; set; }
        public virtual Cidade Cidade { get; set; }
        public int? IdPais { get; set; }
        public virtual Pais Pais { get; set; }
        public int? IdUf { get; set; }
        public virtual Uf Uf { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }
        public bool? Ativo { get; set; }
        public string? CEP { get; set; }
        public bool?  Correspondencia { get; set; }


    }
}
