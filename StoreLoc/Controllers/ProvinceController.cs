﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreLoc.APIData;
using StoreLoc.DTO_s;
using StoreLoc.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalStoreLocator.Controllers
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
                var allResults = _mapper.Map<IList<ProvinceDTO>>(provinces);
                return Ok(allResults); //allResults reffering to all references getting called
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetProvinces)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        
        [HttpGet("{id:int}", Name = "GetProvince")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProvince(int id)
        {
            try
            {
                var province = await _genericRepoRegister.Provinces.Get(q => q.Id == id, new List<string> { "ShoppingCenters", "Stores" });
                var idResult = _mapper.Map<ProvinceDTO>(province);
                return Ok(idResult);     //here I call one ref to proceed by ID
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(GetProvince)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateProvince([FromBody] CreateProvinceDTO provinceDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateProvince)}");
                return BadRequest(ModelState);
            }

            try
            {
                var province = _mapper.Map<Province>(provinceDTO);
                await _genericRepoRegister.Provinces.Insert(province);
                await _genericRepoRegister.Save();

                return CreatedAtRoute("GetProvince", new { id = province.Id }, province);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(CreateProvince)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateProvince(int id, [FromBody] UpdateProvinceDTO provinceDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateProvince)}");
                return BadRequest(ModelState);
            }

            try
            {
                var province = await _genericRepoRegister.Provinces.Get(q => q.Id == id);
                if (province == null)
                {
                    _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateProvince)}");
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(provinceDTO, province);
                _genericRepoRegister.Provinces.Update(province);
                await _genericRepoRegister.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(UpdateProvince)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProvince(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteProvince)}");
                return BadRequest();
            }

            try
            {
                var province = await _genericRepoRegister.Provinces.Get(q => q.Id == id);
                if (province == null)
                {
                    _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteProvince)}");
                    return BadRequest("Submitted data is invalid");
                }

                await _genericRepoRegister.Provinces.Delete(id);
                await _genericRepoRegister.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(DeleteProvince)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }
    }
}