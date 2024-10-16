using Contracts.Repositoriesz;
using DbAccess.Context;
using DbAccess.Repositories.Base;
using Entities;

namespace DbAccess.Repositories
{
    public class CargoRepository : RepositoryBase<Cargo>, ICargoRepository
    {
        public CargoRepository(LogisticContext context) : base(context) { }
    }
}
