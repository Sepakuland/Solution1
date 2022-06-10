using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Data;
using Microsoft.AspNetCore.Mvc;

namespace SchoolProject.Controllers
{
    public class SchoolController : Controller
    {
        MyContext context = new MyContext();
        public IActionResult Index()
        {
            ViewBag.data = context.students.ToList();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            context.students.Add(student);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.item = context.students.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            context.students.Update(student);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            context.students.Remove(new Student() { StudentId = id });
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}