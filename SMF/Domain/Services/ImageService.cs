using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ImageService : ServiceBase<Image>, IImageService
    {
        private readonly IImageRepository _Repository;

        public ImageService(IImageRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
