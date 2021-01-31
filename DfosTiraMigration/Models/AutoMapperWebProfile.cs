using AutoMapper;
using DfosTiraMigration.Models.AwsModels.PriceListsModels;
using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;

namespace DfosTira.Infrastructer
{
    public class AutoMapperWebProfile : Profile
    {
        private IMapper _instance = null;

        public AutoMapperWebProfile()
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<DfosTiraMigration.Models.AwsModels.PriceListsModels.Order, DfosTiraMigration.Models.GoMakeModels.PriceListsModels.Order>();
           

            });

            _instance = config.CreateMapper();
        }

        public IMapper GetMapper() => _instance;
    }
}