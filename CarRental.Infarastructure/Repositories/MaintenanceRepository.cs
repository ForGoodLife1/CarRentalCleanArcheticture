using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infarastructure.Repositories
{
    public class MaintenanceRepository : GenericRepositoryAsync<Maintenance>, IMaintenanceRepository
    {
        #region Fields
        private DbSet<Maintenance> Maintenances;
        #endregion

        #region Constructors
        public MaintenanceRepository(CarRentalContext dbContext) : base(dbContext)
        {
            Maintenances = dbContext.Set<Maintenance>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
