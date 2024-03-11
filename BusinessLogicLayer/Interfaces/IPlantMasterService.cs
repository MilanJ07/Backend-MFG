using DataAccessLayer.DataEntities;

namespace BusinessLogicLayer.Interfaces
{
    public interface IPlantMasterService
    {
        IEnumerable<PlantMaster> RetrieveAllPlantMasters();
        PlantMaster GetPlantMasterByCode(string plantCode);
    }
}
