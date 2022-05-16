using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreLoc.APIData;
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
        public async Task<IActionResult> GetShoppingCenters([FromQuery] QueryParams queryParams)
        {
            var centers = await _genericRepoRegister.ShoppingCenters.GetPagedList(queryParams);
            var allResults = _mapper.Map<IList<ShoppingCenterDTO>>(centers);
            return Ok(allResults); //allResults reffering to all centers references getting called
        }

        [HttpGet("{id:int}", Name = "GetShoppingCenter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetShoppingCenter(int id)
        {
            var centers = await _genericRepoRegister.ShoppingCenters.Get(q => q.Id == id, new List<string> { "Province" });
            var resultId = _mapper.Map<ShoppingCenterDTO>(centers);
            return Ok(resultId);     //here I call one ref to proceed by center ID
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateShoppingCenter([FromBody] CreateShoppingCenterDTO shopCenterDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateShoppingCenter)}");
                return BadRequest(ModelState);
            }

            var centers = _mapper.Map<ShoppingCenter>(shopCenterDTO);
            await _genericRepoRegister.ShoppingCenters.Insert(centers);
            await _genericRepoRegister.Save();

            return CreatedAtRoute("GetShoppingCenter", new { id = centers.Id }, centers);
        }


        [Authorize(Roles = "Administrator")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateShoppingCenter(int id, [FromBody] UpdateShoppingCenterDTO shopCenterDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateShoppingCenter)}");
                return BadRequest(ModelState);
            }

            var centers = await _genericRepoRegister.ShoppingCenters.Get(q => q.Id == id);
            if (centers == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateShoppingCenter)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(shopCenterDTO, centers);
            _genericRepoRegister.ShoppingCenters.Update(centers);
            await _genericRepoRegister.Save();

            return NoContent();
        }


        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteShoppingCenter(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteShoppingCenter)}");
                return BadRequest();
            }

            var centers = await _genericRepoRegister.ShoppingCenters.Get(q => q.Id == id);
            if (centers == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteShoppingCenter)}");
                return BadRequest("Submitted data is invalid");
            }

            await _genericRepoRegister.ShoppingCenters.Delete(id);
            await _genericRepoRegister.Save();

            return NoContent();
        }
    }
}