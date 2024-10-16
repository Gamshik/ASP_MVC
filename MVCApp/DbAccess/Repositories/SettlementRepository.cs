using Contracts.Repositories;
using DbAccess.Context;
using DbAccess.Repositories.Base;
using Entities;

namespace DbAccess.Repositories
{
    public class SettlementRepository : RepositoryBase<Settlement>, ISettlementRepository
    {
        public SettlementRepository(LogisticContext context) : base(context) { }
    }
}
