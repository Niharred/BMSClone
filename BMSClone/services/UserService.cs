using BMSClone.Context;
using BMSClone.Models;
using Microsoft.EntityFrameworkCore;

namespace BMSClone.services
{
    public class UserService : IUserService
    {

        private  DbContext _dbContext;
        public UserService(DataContext dataContext)
        { 
        
            _dbContext = dataContext;
        
        }
        public async Task<User> createUser(User user)
        {
            _dbContext.Set<User>().Add(user);
            _dbContext.SaveChangesAsync();
            return user;

        
        }
    
    }
}
