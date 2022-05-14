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

        
        [HttpGet("{id:int}", Name ="GetStore")]
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

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateStore([FromBody] CreateStoreDTO storeDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateStore)}");
                return BadRequest(ModelState);
            }

            try
            {
                var store = _mapper.Map<Store>(storeDTO);
                await _genericRepoRegister.Stores.Insert(store);
                await _genericRepoRegister.Save();

                return CreatedAtRoute("GetStore", new { id = store.Id }, store);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(CreateStore)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStore(int id, [FromBody] UpdateStoreDTO storeDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateStore)}");
                return BadRequest(ModelState);
            }

            try
            {
                var store = await _genericRepoRegister.Stores.Get(q => q.Id == id);
                if (store == null)
                {
                    _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateStore)}");
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(storeDTO, store);
                _genericRepoRegister.Stores.Update(store);
                await _genericRepoRegister.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(UpdateStore)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteStore(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteStore)}");
                return BadRequest();
            }

            try
            {
                var store = await _genericRepoRegister.Stores.Get(q => q.Id == id);
                if (store == null)
                {
                    _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteStore)}");
                    return BadRequest("Submitted data is invalid");
                }

                await _genericRepoRegister.Stores.Delete(id);
                await _genericRepoRegister.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(DeleteStore)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }
    }
}