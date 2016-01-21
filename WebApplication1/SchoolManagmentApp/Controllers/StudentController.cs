using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DLLApp.ViewModels;

namespace SchoolManagmentApp.Controllers
{
    public class StudentController : BaseController
    {
        // GET: Student
        [HttpGet]
        public ActionResult AddStudent(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(StudentInfoViewModels models)
        {
            return View(models);
        }
    }
}