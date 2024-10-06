using CarRental.Data.Entities;
using CarRental.Infarastructure.Abstracts;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infarastructure.Repositories
{
    public class RentalBookingRepository : GenericRepositoryAsync<RentalBooking>, IRentalBookingRepository
    {
        #region Fields
        private DbSet<RentalBooking> RentalBookings;
        #endregion

        #region Constructors
        public RentalBookingRepository(CarRentalContext dbContext) : base(dbContext)
        {
            RentalBookings = dbContext.Set<RentalBooking>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
