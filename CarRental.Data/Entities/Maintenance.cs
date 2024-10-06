namespace CarRental.Data.Entities;

public partial class Maintenance
{
    public int MaintenanceId { get; set; }

    public int VehicleId { get; set; }

    public string Description { get; set; } = null!;

    public DateOnly MaintenanceDate { get; set; }

    public decimal Cost { get; set; }

    public virtual Vehicle Vehicle { get; set; } = null!;
}
