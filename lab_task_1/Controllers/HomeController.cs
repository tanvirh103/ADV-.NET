using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            profile p1 = new profile()
            {
                Name = "Tanvir Hasan Tamal",
                Email = "tanvirh103@gmail.com",
                Phone = "01534103985",
                Degree = "B.sc",
                Expertise="Web Programming"
            };
            ViewBag.profile= p1;

            return View();
        }

        public ActionResult Education()
        {
            Education e1 = new Education() { 
            DegreeName="Hsc",
            Year="2020",
            Group="Science",
            Institution="Dhaka Imperial College"
            };
            Education e2 = new Education()
            {
                DegreeName = "SSC",
                Year = "2018",
                Group = "Science",
                Institution = "Faizur Rahman Ideal School"
            };
            ViewBag.education = new Education[] { e1, e2 };
            return View();
        }

        public ActionResult Projects()
        {
            projects p1 = new projects() {
                Title = "ImBD",
                Description = "This is a web based project.For this Project we have use HTML,CSS,PHP,JS",
                Course = "Web Technology"
            };
            projects p2 = new projects()
            {
                Title = "University Management",
                Description = "This is a Desktop Application for University Student.For this project I have used C# language",
                Course = "OOP2"
            };

            projects p3= new projects()
            {
                Title = "Pharmacy Management",
                Description = "This is a Desktop Application for Maintaining phermacy expences.I used JAVA For this Application",
                Course = "OOP1"
            };
            ViewBag.projects=new projects[] { p1, p2, p3 };
            return View();
        }
        public ActionResult Refrence()
        {
            return View();
        }
    }
}