using DAL.Data;
using DAL.Repository.Interfaces;
using Models;
using Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {    private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get Methods
        public IEnumerable<User> GetAllUsers()
        {
            return _context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.User.FirstOrDefault(u => u.Id == id);
        }

        public User GetUserByUserName(string userName)
        {
           return _context.User.FirstOrDefault(u => u.UserName.Equals(userName));
        }

        public IEnumerable<User> GetUsersByRole(UserRole role)
        {
            return _context.User.Where(u => u.Role == role).ToList();
        }

        //set Methods
        public void AddUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        // Update Methods
        public void UpdateUser(User user)
        {
            _context.User.Update(user);
            _context.SaveChanges();
        }

        //Delete Methods
        public void DeleteUser(User user)
        {
           _context.User.Remove(user);
            _context.SaveChanges();
        }

        

       
    }
}
