using CarRental.Api.Base;
using CarRental.Core.Feautres.CustomerCQRS.Commands.ModelsCommands;
using CarRental.Core.Feautres.CustomerCQRS.Queries.ModelsQueries;
using CarRental.Core.Feautres.PatientCQRS.Queries.ModelsQueries;
using CarRental.Data.AppMetaData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : AppControllerBase
    {

        [HttpGet(Router.CustomerRouting.List)]
        public async Task<IActionResult> GetCustomersAync()
        {
            var response = Mediator.Send(new GetListCustomerQuery());
            return Ok(response);
        }
        [AllowAnonymous]
        [HttpGet(Router.CustomerRouting.Paginated)]
        public async Task<IActionResult> Paginated([FromQuery] GetListCustomerPaginatedQuery query)
        {
            var response = await Mediator.Send(query);
            return Ok(response);
        }
        [HttpGet(Router.CustomerRouting.GetByID)]
        public async Task<IActionResult> GetCustomerByID([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new GetCustomerByIDQuery(id)));
        }
        //[Authorize(Policy = "CreateCustomer")]
        [HttpPost(Router.CustomerRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddCustomerCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [Authorize(Policy = "EditCustomer")]
        [HttpPut(Router.CustomerRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditCustomerCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [Authorize(Policy = "DeleteCustomer")]
        [HttpDelete(Router.CustomerRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteCustomerCommand(id)));
        }
    }
}
