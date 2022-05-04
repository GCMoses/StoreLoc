using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreLoc.DTO_s;
using StoreLoc.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IGenericRepoRegister _genericRepoRegister;         //prop set
        private readonly ILogger<ProvinceController> _logger;
        private readonly IMapper _mapper;

        public ProvinceController(IGenericRepoRegister genericRepoRegister, ILogger<ProvinceController> logger,
        IMapper mapper)                                                     //ctor set
        {
            _genericRepoRegister = genericRepoRegister;                     //initializer set
            _logger = logger;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProvinces()
        {
            try
            {
                var provinces = await _genericRepoRegister.Provinces.GetAll();
                var allResulst = _mapper.Map<IList<ProvinceDTO>>(provinces);
                return Ok(allResulst); //allResult reffering to all references getting called
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetProvinces)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProvince(int id)
        {
            try
            {
                var province = await _genericRepoRegister.Provinces.Get(q => q.Id == id, new List<string> { "ShoppingCenters", "Stores" });
                //var prov = await _genericRepoRegister.Provinces.Get(q => q.Id == id, new List<string> { "Stores" });
                var resultId = _mapper.Map<ProvinceDTO>(province);
                //var resultId1 = _mapper.Map<ProvinceDTO>(prov);
                return Ok(resultId);     //here I call one ref to proceed by ID             neeed help with second return method

                 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetProvince)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        private IActionResult Ok(ProvinceDTO resultId, ProvinceDTO resultId1)
        {
            throw new NotImplementedException();
        }
    }
}