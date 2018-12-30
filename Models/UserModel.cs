using System;
// using System.Data.
namespace Bookstore.Models
{
    public class UserModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get ; set; }
    }

    // public class UserModelDBContext:DbContext 
    // {
    //     public DbSet<UserModel> Users;
    // }
}