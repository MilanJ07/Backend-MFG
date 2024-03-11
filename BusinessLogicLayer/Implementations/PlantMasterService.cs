using BusinessLogicLayer.Interfaces;
using DataAccessLayer.DataEntities;
using DataAccessLayer.Interfaces;

namespace BusinessLogicLayer.Implementations
{
    public class PlantMasterService : IPlantMasterService
    {
        private readonly IPlantMasterRepository _plantMasterRepository;

        public PlantMasterService(IPlantMasterRepository plantMasterRepository)
        {
            _plantMasterRepository = plantMasterRepository;
        }
        public IEnumerable<PlantMaster> RetrieveAllPlantMasters()
        {
            return _plantMasterRepository.GetAllPlantMasters();
        }
        public PlantMaster GetPlantMasterByCode(string plantCode)
        {
            return _plantMasterRepository.GetPlantMasterByCode(plantCode);
        }
    }
}
