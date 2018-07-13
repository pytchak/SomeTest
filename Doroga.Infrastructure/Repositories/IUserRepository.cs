using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<UserEntity> GetAllUsers();
        UserEntity GetUserById(string id);
    }
}
