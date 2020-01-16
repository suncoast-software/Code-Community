using Code_Community.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Community.Services
{
    public interface IUserService
    {
        public IEnumerable<ForumUser> GetAll();
        public ForumUser Get(int id);
        public void CreateUser(ForumUser user);
        public void EditUser(int id);
        public void DeleteUser(int id);
    }
}
