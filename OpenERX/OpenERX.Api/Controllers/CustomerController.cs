using Microsoft.AspNetCore.Mvc;
using OpenERX.Api.Results;
using OpenERX.Commons.Params;
using OpenERX.Core.Customers;

namespace OpenERX.Api.Controllers
{
    [Route("v1/customers")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Search()
        {
            return this.Ok("Sucesso!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                var result = await customerService.GetAsync(id);

                if (customerService.HasErrors())
                {
                    var msg = new ResponseMessage
                    {
                        Code = customerService.Errors[0].Code,
                        Text = customerService.Errors[0].Text
                    };

                    return this.BadRequest(msg);
                }
     
                return this.Ok(result);
            }
            catch (Exception e)
            {
                var msg = new ResponseMessage
                {
                    Code = "9999",
                    Text = e.Message
                };

                return this.BadRequest(msg);
            }

        }

        [HttpPost("")]
        public async Task<IActionResult> Create([FromBody] CustomerParams createParams)
        {
            var result = await customerService.CreateAsync(createParams);
            return this.Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CustomerParams createParams)
        {
            var result = await customerService.UpdateAsync(id, createParams);
            return this.Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] IdParams deleteParams)
        {
            var result = await customerService.DeleteAsync(deleteParams);
            return this.Ok(result);
        }
    }
}
