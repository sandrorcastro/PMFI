using AutoMapper;
using Domain.Entities;
using Application.ViewModels;
namespace Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CidadeViewModel, Cidade>();
        }

    }
}
