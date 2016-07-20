using System.Linq;
using LibraryManagement.Core.Entities;
using LibraryManagement.Core.IRepository;
using System;
using System.Data.Entity;

namespace LibraryManagement.Repository
{
    public class UserRepository : IUserRepository
    {
        DBContext dbContext;

        public UserRepository()
        {
            dbContext = new DBContext();
        }

        public User GetUser(string UserName)
        {
            return dbContext.User.FirstOrDefault(x => x.UserName == UserName);
        }

        public void AddUser(User user)
        {
            user.UserId = Guid.NewGuid().ToString();
            user.Password = Core.Helpers.EncryptionHelper.Encrypt(user.Password);
            dbContext.User.Add(user);
            dbContext.SaveChanges();
        }

        public void DeleteAllUser()
        {
            string sql = @"IF (EXISTS (SELECT * 
                                             FROM INFORMATION_SCHEMA.TABLES 
                                             WHERE TABLE_NAME = 'Users'))
                            BEGIN
                                TRUNCATE TABLE [Users]
                            END";
            dbContext.Database.ExecuteSqlCommand(sql);
        }
    }
}
