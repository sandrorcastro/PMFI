using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class ImageAppService : AppServiceBase<Image>, IImageAppService
    {
        private readonly IImageService service;

        public ImageAppService(IImageService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
