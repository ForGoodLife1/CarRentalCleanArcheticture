namespace CarRental.Core.Feautres.VehicleCategory.Queries.ResponseQueries
{
    public class GetVehicleCategoryResponse
    {
        public int CategoryId { get; set; }

        public string CategoryNameAr { get; set; } = null!;
        public string CategoryNameEn { get; set; } = null!;

        public virtual ICollection<CarRental.Data.Entities.Vehicle> Vehicles { get; set; }
    }
}
