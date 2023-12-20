using DbConnect.Entities;

namespace LoginForChat.Services.Interfaces
{
    public interface IUserService
    {
        public Task<User> RegisterUser(string username, string password);
        public Task<User?> DetailUser(int id);
        
    }
}