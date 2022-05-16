using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreLoc.APIData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/province")]
    [ApiController]
    public class ProvinceVersion2Controller : ControllerBase
    {
        private DatabaseContext _dbContext;

        public ProvinceVersion2Controller(DatabaseContext dbContext)                                                     //ctor set
        {
            _dbContext = dbContext;                     //initializer set
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProvinces()
        {
            return Ok(_dbContext.Provinces);
        }
    }
}
