using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentTechProtfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentTechProtfolio.Models;
using System.Data;

namespace StudentTechProtfolio.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Display(string sortOrder, string searchString)
        {
            ViewBag.SortName = String.IsNullOrEmpty(sortOrder) ? "DescName" : "";
            ViewBag.SortDate = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            var students = from s in _context.Student
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Skills.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "DescName":
                    students = students.OrderByDescending(s => s.FirstName + s.LastName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.DateEnrolled);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.DateEnrolled);
                    break;
                default:
                    students = students.OrderBy(s => s.FirstName + s.LastName);
                    break;
            }
            return View(await students.AsNoTracking().ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create(Student student)
        {
            try { 
            if (ModelState.IsValid)
            {
                _context.Student.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Display));
            }
            }

             catch (DataException error)
            {
                Console.WriteLine("Error : {}", error);
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(student);

        }

        public async Task<IActionResult> Edit(int? studentId)
        {
            if (studentId == null || studentId <= 0)
            {
                return BadRequest();
            }
            var studentsInDb = await _context.Student.FirstOrDefaultAsync(e => e.ID == studentId);
            if (studentsInDb == null)
            {
                return NotFound();
            }
            return View(studentsInDb);

        }

        [HttpPost,ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);

            }
            _context.Student.Update(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Display));

        }
         
        
        public async Task<IActionResult> Delete(int? studentId)
        {
            if (studentId == null || studentId <= 0)
            {
                return BadRequest();
            }
            var studentsInDb = await _context.Student.FirstOrDefaultAsync(e => e.ID == studentId);
            if (studentsInDb == null)
            {
                return NotFound();
            }
            _context.Student.Remove(studentsInDb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Display));

        }
        public async Task<IActionResult> ViewStudent(int? studentId)
        {
            if (studentId <= 0 || studentId == null)
            {
                return BadRequest();
            }
            var studentsInDb = await _context.Student.FirstOrDefaultAsync(e => e.ID == studentId);
            if (studentsInDb == null)
            {
                return NotFound();
            }
            return View(studentsInDb);

        }

        public IActionResult About()
        {
            return View();
        }

    }
}
