using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commons;
using DataAccessLayer;

namespace AngularjsMvc.Controllers
{
    public class UserController : Controller
    {

        private IRepository userRepository;
        public UserController()
        {
            this.userRepository = new UserRepostory(new AngularjsMvcDbContext());
        }

        

        /*
         * This method retrieves All the users from the database
        */
        public JsonResult Index()
        {
            
            var users = this.userRepository.GetUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
           
        }

        /*
        * This method retrieves a specific user base on id
        * @param : This method takes one parameter which is a user id (primary key)
       */
        public JsonResult Details(int id)
        {
            var user = this.userRepository.GetUserByID(id);
            return Json(user, JsonRequestBehavior.AllowGet);
        }

        /*
        * This method add a user to the database
        * @param : This method takes one parameter which is a user object(the user to be added on the database)
        */
        [HttpPost]
        public JsonResult Create(User user)
        {
            this.userRepository.InsertUser(user);
            this.userRepository.Save();
            return Json(null);
        }
        /*
        * This method retrieves a specific user base on user object that is passed.
        * --It used to update user details
        * @param : This method takes one parameter which is a user object
       */
        [HttpPost]
        public JsonResult Edit(User user)
        {
           this.userRepository.UpdateUser(user);
           this.userRepository.Save();
           return Json(null);
        }

        /*
        * This method delete a user on the database
        * @param : This method takes one parameter which is a user object(the user to be deleted on the database)
        */
        [HttpPost]
        public JsonResult Delete(int id)
        {
           
            this.userRepository.DeleteUser(id);
            this.userRepository.Save();
            return Json(null);
        }
    }
}