using CarRental.Core.Bases;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Core.Feautres.CustomerCQRS.Commands.ModelsCommands
{
    public class AddCustomerCommand : IRequest<Response<String>>
    {
        [Required]
        public string NameAr { get; set; }
        [Required]
        public string NameEn { get; set; }



        public string ContactInformation { get; set; } = null!;

        public string DriverLicenseNumber { get; set; }

    }
}
