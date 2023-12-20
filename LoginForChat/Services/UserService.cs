using DbConnect;
using DbConnect.Entities;
using LoginForChat.Services.Interfaces;

namespace LoginForChat.Services
{
    public class UserService : IUserService
    {
        private readonly ChatContext _dbContext;

        public UserService(ChatContext dbContext)
        {
            _dbContext=dbContext;
        }

        public async Task<User?> DetailUser(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);

            return user;
        }

        public async Task<User> RegisterUser(string username, string password)
        {
            var user = new User() { Username = username, Password = password };

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
    }
}
