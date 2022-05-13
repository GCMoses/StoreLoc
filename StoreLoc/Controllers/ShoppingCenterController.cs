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
    public class ShoppingCenterController : ControllerBase
    {
        private readonly IGenericRepoRegister _genericRepoRegister;
        private readonly ILogger<ShoppingCenterController> _logger;
        private readonly IMapper _mapper;

        public ShoppingCenterController(IGenericRepoRegister genericRepoRegister, ILogger<ShoppingCenterController> logger,
        IMapper mapper)
        {
            _genericRepoRegister = genericRepoRegister;
            _logger = logger;
            _mapper = mapper;
        } 


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetShoppingCenters()
        {
            try
            {
                var centers = await _genericRepoRegister.ShoppingCenters.GetAll();
                var allResults = _mapper.Map<IList<ShoppingCenterDTO>>(centers);
                return Ok(allResults); //allResults reffering to all centers references getting called
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetShoppingCenters)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]        
        public async Task<IActionResult> GetShoppingCenter(int id)
        {
            try
            {
                var shopCenter = await _genericRepoRegister.ShoppingCenters.Get(q => q.Id == id, new List<string> { "Province" });
                var resultId = _mapper.Map<ShoppingCenterDTO>(shopCenter);
                return Ok(resultId);     //here I call one ref to proceed by center ID
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetShoppingCenter)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }
    }
}