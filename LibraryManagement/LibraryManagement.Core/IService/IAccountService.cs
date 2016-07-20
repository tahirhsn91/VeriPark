using LibraryManagement.Core.Entities;

namespace LibraryManagement.Core.IService
{
    public interface IAccountService
    {
        bool ValidateUser(Login loginData);
    }
}
