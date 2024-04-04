using BMSClone.Models;

namespace BMSClone.services
{
    public interface IUserService
    {
         Task<User> createUser(User user);
    }
}
