using CarRental.Data.Entities.Identity;
using CarRental.Infarastructure.Context;
using CarRental.Infarastructure.InfrastructureBases;
using CarRental.Infrustructure.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infrustructure.Repositories
{
    public class RefreshTokenRepository : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenRepository
    {
        #region Fields
        private DbSet<UserRefreshToken> userRefreshToken;
        #endregion

        #region Constructors
        public RefreshTokenRepository(CarRentalContext dbContext) : base(dbContext)
        {
            userRefreshToken=dbContext.Set<UserRefreshToken>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
