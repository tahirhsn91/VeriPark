using LibraryManagement.Core.Entities;
using LibraryManagement.Core.IRepository;
using LibraryManagement.Core.IService;
using LibraryManagement.Repository;

namespace LibraryManagement.Service
{
    public class AccountService : IAccountService
    {
        IUserRepository repository;

        public AccountService()
        {
            repository = new UserRepository();
        }

        public bool ValidateUser(Login loginData)
        {
            User user = repository.GetUser(loginData.UserName);

            if (user != null && Core.Helpers.EncryptionHelper.Decrypt(user.Password).Equals(loginData.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddUser(User user)
        {
            repository.AddUser(user);
        }
    }
}
