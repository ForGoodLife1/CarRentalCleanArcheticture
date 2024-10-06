namespace CarRental.Data.Entities;

public partial class VehicleCategory
{
    public int CategoryId { get; set; }

    public string CategoryNameAr { get; set; } = null!;
    public string CategoryNameEn { get; set; } = null!;

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
