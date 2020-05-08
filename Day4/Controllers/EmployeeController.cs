using Day1.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();


        [HttpGet]
        public ViewResult Index()
        {
            return View(context.Employees.ToList());
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            if(ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee employee = context.Employees.Find(id);
            if(employee != null)
            {
                return View(employee);
            }
            return HttpNotFound("Employee not found!");
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if(ModelState.IsValid)
            {
                context.Employees.Attach(employee);
                context.Entry(employee).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                return Json(true);
            }
            return HttpNotFound("Employee not found!");
        }
    }
}