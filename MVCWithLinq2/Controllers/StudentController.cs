using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithLinq2.Models;

namespace MVCWithLinq2.Controllers
{
    public class StudentController : Controller
    {
        MVCDBDataContext context = new MVCDBDataContext(ConfigurationManager.
            ConnectionStrings["MVCDBConnectionString"].ConnectionString);

        public ViewResult DisplayStudents()
        {
            List<Student_SelectResult> student = context.Student_Select(null,true).ToList();
            return View(student);
        }
        public ViewResult DisplayStudent(int Sid)
        {
            Student_SelectResult student = context.Student_Select(Sid,true).Single();
            return View(student);
        }
    }
}