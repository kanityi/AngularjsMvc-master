using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularjsMvc.Models.EF;

namespace AngularjsMvc.Controllers
{
    public class UserController : Controller
    {
        private AngularjsMvcDbContext db = null;
        public UserController()
        {
            db = new AngularjsMvcDbContext();
        }

        /*
         * This method retrieves All the users from the database
        */
        public JsonResult Index()
        {
            var users = db.Users.ToList();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        /*
        * This method retrieves a specific user base on id
        * @param : This method takes one parameter which is a user id (primary key)
       */
        public JsonResult Details(int id)
        {
            var user = db.Users.Find(id);
            return Json(user, JsonRequestBehavior.AllowGet);
        }

        /*
        * This method add a user to the database
        * @param : This method takes one parameter which is a user object(the user to be added on the database)
        */
        [HttpPost]
        public JsonResult Create(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
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
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Json(null);
        }

        /*
        * This method delete a user on the database
        * @param : This method takes one parameter which is a user object(the user to be deleted on the database)
        */
        [HttpPost]
        public JsonResult Delete(int id)
        {
            var user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return Json(null);
        }
    }
}