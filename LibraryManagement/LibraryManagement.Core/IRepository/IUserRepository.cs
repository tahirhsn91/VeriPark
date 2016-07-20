using LibraryManagement.Core.Entities;

namespace LibraryManagement.Core.IRepository
{
    public interface IUserRepository
    {
        User GetUser(string UserName);

        void AddUser(User user);

        void DeleteAllUser();
    }
}
