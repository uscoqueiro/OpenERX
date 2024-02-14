using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenERX.Core.SignIns;

namespace OpenERX.Api.Controllers
{
    [Route("v1/sign-in")]
    public class SignInController : Controller
    {
        private readonly ISignInService _signInService;

        public SignInController(ISignInService signInService)
        {
            _signInService = signInService;
        }
 
        [HttpPost("")]
        [AllowAnonymous]
        public async Task<IActionResult> SignInAsync([FromBody] SignInParams @params)
        {
            var result = await _signInService.SignInAsync(@params);
           
            if (_signInService.HasErrors())
            {
                return this.Unauthorized(
                new {
                    Code = _signInService.Errors[0].Code,
                    Text = _signInService.Errors[0].Text
                } );
            }

            return this.Ok(result);
        }
    }
}
