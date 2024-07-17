using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Psiformulario
{
    /// <summary>
    /// Identificação do Formulário
    /// </summary>
    public long FormularioId { get; set; }

    /// <summary>
    /// Referencia do Formulário, indicando a quem o mesmo se refere
    /// </summary>
    public long? RefFormulario { get; set; }

    /// <summary>
    /// Nome do formulário a ser exibido no menu, onde muitas vezes se faz necessário abreviar o nome para que nao se tenha um menu gigantesco 
    /// </summary>
    public string? FormNmMenu { get; set; }

    /// <summary>
    /// Nome do formulário a ser exibido no cabecalho do mesmo
    /// </summary>
    public string? FormNmTitulo { get; set; }

    /// <summary>
    /// Endereço da Página a ser exibida
    /// </summary>
    public string? PageEndereco { get; set; }

    /// <summary>
    /// Tipo do Formulário podendo ser Cadastros, Relatórios, Parametros, Movimento
    /// </summary>
    public string? TipoForm { get; set; }

    /// <summary>
    /// Função do formulário ou descritivo do menu
    /// </summary>
    public string? FormFuncao { get; set; }

    /// <summary>
    /// Chave Estrangeira que representara 
    /// </summary>
    public long? TemaId { get; set; }

    /// <summary>
    /// Identificação do Módulo do Formulario
    /// </summary>
    public long? ModuloId { get; set; }

    /// <summary>
    /// Chave Estrangeira( ObjetoId )  que representa a Imagem do objeto a ser colocado no cabeçalho do formulário
    /// </summary>
    public long? FormCabecObjId { get; set; }

    /// <summary>
    /// Chave Estrangeira( ObjetoId )  que representa a Imagem do objeto a ser colocado como help do formulário no cabeçalho deste
    /// </summary>
    public long? FormHelpObjId { get; set; }

    public virtual Psiobjeto? FormCabecObj { get; set; }

    public virtual Psiobjeto? FormHelpObj { get; set; }

    public virtual ICollection<Psiformulario> InverseRefFormularioNavigation { get; set; } = new List<Psiformulario>();

    public virtual Psimodulo? Modulo { get; set; }

    public virtual Psiformulario? RefFormularioNavigation { get; set; }

    public virtual Psitema? Tema { get; set; }

    public virtual ICollection<PsitipoPerfil> TipoPerfils { get; set; } = new List<PsitipoPerfil>();
}
