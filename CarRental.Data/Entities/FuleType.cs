namespace CarRental.Data.Entities;


public partial class FuleType
{
    public int Id { get; set; }

    public string FuleType1 { get; set; } = null!;

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
