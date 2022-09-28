using AspBetSample.DataBase.Entities;
using AspNetSample.Data.Abstractions.Repositories;

namespace AspNetSample.Data.Abstractions;

public interface IUnitOfWork
{
    IAdditionalArticleRepository Articles { get; }
    IRepository<Source> Sources { get; }
    IRepository<User> Users { get; }
    IRepository<Role> Roles { get; }

    Task<int> Commit();
}