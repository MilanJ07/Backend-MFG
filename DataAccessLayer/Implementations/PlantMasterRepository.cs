using DataAccessLayer.DataEntities;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Implementations
{
    public class PlantMasterRepository : IPlantMasterRepository
    {
        private readonly ModelContext _context;

        public PlantMasterRepository(ModelContext context)
        {
            _context = context;
        }
        public IEnumerable<PlantMaster> GetAllPlantMasters()
        {
            return _context.PlantMasters.ToList();
        }
        public PlantMaster GetPlantMasterByCode(string plantCode)
        {
            return _context.PlantMasters.FirstOrDefault(p => p.PlantCode == plantCode);
        }
    }
}
