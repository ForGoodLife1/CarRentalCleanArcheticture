using CarRental.Api.Base;
using CarRental.Core.Feautres.Vehicle.Commands.ModelsCommands;
using CarRental.Core.Feautres.Vehicle.Queries.ModelsQueries;
using CarRental.Data.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers
{

    [ApiController]
    public class VehicleController : AppControllerBase
    {
        [HttpGet(Router.VehicleRouting.List)]
        public async Task<IActionResult> GetVehicleList()
        {
            var response = await Mediator.Send(new GetListVehicleQuery());
            return Ok(response);
        }


        [HttpGet(Router.VehicleRouting.GetByID)]
        public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new GetVehicleByIdQuery(id)));
        }



        [HttpPost(Router.VehicleRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddVehicleModel command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }



        [HttpPut(Router.VehicleRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditVehicleModel command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }



        [HttpDelete(Router.VehicleRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteVehicleModel(id)));
        }
    }
}
