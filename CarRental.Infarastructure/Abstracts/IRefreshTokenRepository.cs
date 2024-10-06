using CarRental.Data.Entities.Identity;
using CarRental.Infarastructure.InfrastructureBases;

namespace CarRental.Infrustructure.Abstracts
{
    public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
    {

    }
}
