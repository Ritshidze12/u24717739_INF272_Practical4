using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace u24717739_INF272_Practical4.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult StudentsView()
        {
            List<Models.Student_Model> student = new List<Models.Student_Model>();

            student.Add(new Models.Student_Model { StudentNumber = "u24717739", FirstName = "Ritshidze", surname = "Nedzimauli", email = "u24717739@tuks.co.za", MyLink = "~/Content/HTML/Ritshidze.html" });
            student.Add(new Models.Student_Model { StudentNumber = "u24784606", FirstName = "Msizi", surname = "Gumede", email = "u24784606@tuks.co.za", MyLink = "~/Content/HTML/Msizi.html" });
            student.Add(new Models.Student_Model { StudentNumber = "u24634400", FirstName = "Boitshoko", surname = "Mphahlele", email = "u24634400@tuks.co.za", MyLink = "~/Content/HTML/Boitshoko.html" });
            student.Add(new Models.Student_Model { StudentNumber = "u24724918", FirstName = "Gundo", surname = "Ndou", email = "u24724918@tuks.co.za", MyLink = "~/Content/HTML/Gundo.html" });
            student.Add(new Models.Student_Model { StudentNumber = "u24924142", FirstName = "Walter", surname = "Marimi", email = "u24924142@tuks.co.za", MyLink = "~/Content/HTML/Walter.html" });
           
            return View(student);
        }
    }
}