using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppITBI.MetaData
{
    public class ImovelMetaData
    {
        [Required(ErrorMessage = "Inscrição Imobiliária é obrigatória")]
        public string? InscricaoImobiliaria { get; set; }
    }
}
