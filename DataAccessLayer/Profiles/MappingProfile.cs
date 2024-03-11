using AutoMapper;
using DataAccessLayer.DataEntities;
using Models.ResponseModels;

namespace DataAccessLayer.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PlantMaster, PlantMasterResponse>();
        }
    }
}
