using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenERX.Api.Results;
using OpenERX.Commons.Params;
using OpenERX.Core.Customers;

namespace OpenERX.Api.Controllers
{
    [Route("v1/test")]
    public class TestController : Controller
    {
        private readonly IHttpContextAccessor _accessor;

        public TestController( IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        //[HttpGet("")]
        //[AllowAnonymous]
        //public async Task<IActionResult> Search( )
        //{
        //    var x = _accessor;

        //    return this.Ok("Sucesso!");
        //}


        [HttpPost("")]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromForm] FormParams @params)
        {
            var x = _accessor;
            return this.Ok("Sucesso!");
        }

    }
}



public class FormParams
{
    string fname { get; set; }
    string lname { get; set; }
}

