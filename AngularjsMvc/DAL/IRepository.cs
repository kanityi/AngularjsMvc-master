using AngularjsMvc.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularjsMvc.DAL
{
    public interface IRepository : IDisposable
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(int userID);
        void InsertUser(User user);
        void DeleteUser(int userID);
        void UpdateUser(User user);
        void Save();
    }


}