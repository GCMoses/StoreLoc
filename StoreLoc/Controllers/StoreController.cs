using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    public class StoreController : ControllerBase
    {
        private readonly IGenericRepoRegister _genericRepoRegister;
        private readonly ILogger<StoreController> _logger;
        private readonly IMapper _mapper;

        public StoreController(IGenericRepoRegister genericRepoRegister, ILogger<StoreController> logger,
        IMapper mapper)
        {
            _genericRepoRegister = genericRepoRegister;
            _logger = logger;
            _mapper = mapper;
        } 


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStores()
        {
            try
            {
                var stores = await _genericRepoRegister.Stores.GetAll();
                var allResults = _mapper.Map<IList<StoreDTO>>(stores);
                return Ok(allResults); //allResults reffering to all stores references getting called
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetStores)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStore(int id)
        {
            try
            {
                var store = await _genericRepoRegister.Stores.Get(q => q.Id == id, new List<string> { "Province"});
                var resultId = _mapper.Map<StoreDTO>(store);
                return Ok(resultId);     //here I call one ref to proceed by store ID
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetStore)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }
    }
}