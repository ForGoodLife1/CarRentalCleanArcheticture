using CarRental.Api.Base;
using CarRental.Core.Feautres.VehicleCategory.Queries.ModelsQueries;
using CarRental.Data.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers
{

    [ApiController]
    public class VehicleCategoryController : AppControllerBase
    {




        [HttpGet(Router.VehicleCategoryRuting.GetByID)]
        public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new GetVehicleCategoryModel(id)));
        }




    }
}
