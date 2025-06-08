using Models;
using Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IUserRepository
    {
        //Get Methods
        User GetUserById(int id);
        User GetUserByUserName(string userName);
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetUsersByRole(UserRole role);

        //Set Methods
        void AddUser(User user);

        // Update Methods
        void UpdateUser(User user);

        //Delete Methods
        void DeleteUser(User user);


    }
}
