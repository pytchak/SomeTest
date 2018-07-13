using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services.Contracts
{
    public interface IUserService
    {
        UserEntity GetUserById(string userId);
        IEnumerable<UserEntity> GetAllUsers();
    }
}
