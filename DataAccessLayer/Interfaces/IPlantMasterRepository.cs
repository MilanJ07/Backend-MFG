using DataAccessLayer.DataEntities;

namespace DataAccessLayer.Interfaces
{
    public interface IPlantMasterRepository
    {
        IEnumerable<PlantMaster> GetAllPlantMasters();
        PlantMaster GetPlantMasterByCode(string plantCode);
    }
}
