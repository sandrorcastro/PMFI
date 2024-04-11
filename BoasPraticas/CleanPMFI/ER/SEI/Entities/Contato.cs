using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Contato
{
    public int IdContato { get; set; }

    public int? IdCargo { get; set; }

    public string Nome { get; set; } = null!;

    public string? MatriculaOab { get; set; }

    public long? Cpf { get; set; }

    public string? Matricula { get; set; }

    public string? Email { get; set; }

    public string? SitioInternet { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cep { get; set; }

    public string? Observacao { get; set; }

    public string? IdxContato { get; set; }

    public DateTime? DtaNascimento { get; set; }

    public string SinAtivo { get; set; } = null!;

    public long? Cnpj { get; set; }

    public string? Sigla { get; set; }

    public int? IdUnidadeCadastro { get; set; }

    public int? IdUsuarioCadastro { get; set; }

    public DateTime? DthCadastro { get; set; }

    public long? Rg { get; set; }

    public string? OrgaoExpedidor { get; set; }

    public string? Complemento { get; set; }

    public string StaNatureza { get; set; } = null!;

    public string SinEnderecoAssociado { get; set; } = null!;

    public string? TelefoneCelular { get; set; }

    public int? IdCidade { get; set; }

    public int? IdUf { get; set; }

    public int? IdPais { get; set; }

    public int IdContatoAssociado { get; set; }

    public string? StaGenero { get; set; }

    public int IdTipoContato { get; set; }

    public string? NumeroPassaporte { get; set; }

    public int? IdPaisPassaporte { get; set; }

    public int? IdTitulo { get; set; }

    public string? TelefoneComercial { get; set; }

    public string? TelefoneResidencial { get; set; }

    public string? Conjuge { get; set; }

    public string? Funcao { get; set; }

    public string? NomeRegistroCivil { get; set; }

    public string? NomeSocial { get; set; }

    public int? IdCategoria { get; set; }

    public virtual Cargo? IdCargoNavigation { get; set; }

    public virtual Categorium? IdCategoriaNavigation { get; set; }

    public virtual Cidade? IdCidadeNavigation { get; set; }

    public virtual Pai? IdPaisNavigation { get; set; }

    public virtual Pai? IdPaisPassaporteNavigation { get; set; }

    public virtual TipoContato IdTipoContatoNavigation { get; set; } = null!;

    public virtual Titulo? IdTituloNavigation { get; set; }

    public virtual Uf? IdUfNavigation { get; set; }

    public virtual Unidade? IdUnidadeCadastroNavigation { get; set; }

    public virtual Usuario? IdUsuarioCadastroNavigation { get; set; }

    public virtual ICollection<Orgao> Orgaos { get; set; } = new List<Orgao>();

    public virtual ICollection<Participante> Participantes { get; set; } = new List<Participante>();

    public virtual ICollection<Unidade> Unidades { get; set; } = new List<Unidade>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<GrupoContato> IdGrupoContatos { get; set; } = new List<GrupoContato>();
}
