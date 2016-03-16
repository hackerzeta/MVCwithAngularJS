using MVCwithAngularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithAngularJS.Controllers
{
    public class DataController : Controller
    {
        //
        // GET: /Data/

        public JsonResult GetLastContact()
        {
            Contact c = null;

            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                c = dc.Contact.OrderByDescending(a => a.ContactId).Take(1).FirstOrDefault();
            }

            return new JsonResult { Data = c, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult UserLogin(LoginData d)
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var user = dc.Users.Where(a => a.Username.Equals(d.Username) && a.Password.Equals(d.Password)).FirstOrDefault();
                return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
    }
}
