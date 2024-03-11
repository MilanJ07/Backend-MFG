using AutoMapper;
using BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.RequestModels;
using Models.ResponseModels;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantMasterController : ControllerBase
    {
        private readonly IPlantMasterService _plantMasterBusinessLogic;
        private readonly IMapper _mapper;
        public PlantMasterController(IPlantMasterService plantMasterBusinessLogic, IMapper mapper)
        {
            _plantMasterBusinessLogic = plantMasterBusinessLogic;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PlantMasterResponse>> GetAllPlantMasters()
        {
            var plantMasters = _plantMasterBusinessLogic.RetrieveAllPlantMasters();
            var plantMasterResponses = _mapper.Map<IEnumerable<PlantMasterResponse>>(plantMasters);
            return Ok(plantMasterResponses);
        }
        [HttpPost("search")]
        public ActionResult<PlantMasterResponse> GetPlantMasterByCode([FromBody] PlantCodeRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.PlantCode))
                return BadRequest("Plant code is required");

            var plantMaster = _plantMasterBusinessLogic.GetPlantMasterByCode(request.PlantCode);
            if (plantMaster == null)
                return NotFound();

            var plantMasterResponse = _mapper.Map<PlantMasterResponse>(plantMaster);
            return Ok(plantMasterResponse);
        }
    }
}
