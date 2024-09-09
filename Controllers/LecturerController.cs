using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace.Controllers
{
    public class LecturerController : Controller
    {
        private static List<Lecturer> lecturers = new List<Lecturer>();

        // GET: Lecturer
        public IActionResult Index()
        {
            return View(lecturers);
        }

        // GET: Lecturer/Details/5
        public IActionResult Details(int id)
        {
            var lecturer = lecturers.FirstOrDefault(l => l.LecturerID == id);
            if (lecturer == null)
                return NotFound();
            return View(lecturer);
        }

        // GET: Lecturer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lecturer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Lecturer lecturer)
        {
            if (ModelState.IsValid)
            {
                lecturer.LecturerID = lecturers.Count + 1; // Generate a new ID
                lecturers.Add(lecturer);
                return RedirectToAction(nameof(Index));
            }
            return View(lecturer);
        }

        // GET: Lecturer/Edit/5
        public IActionResult Edit(int id)
        {
            var lecturer = lecturers.FirstOrDefault(l => l.LecturerID == id);
            if (lecturer == null)
                return NotFound();
            return View(lecturer);
        }

        // POST: Lecturer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Lecturer lecturer)
        {
            var existingLecturer = lecturers.FirstOrDefault(l => l.LecturerID == id);
            if (existingLecturer == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                existingLecturer.Name = lecturer.Name;
                existingLecturer.Email = lecturer.Email;
                existingLecturer.HourlyRate = lecturer.HourlyRate;
                return RedirectToAction(nameof(Index));
            }
            return View(lecturer);
        }

        // GET: Lecturer/Delete/5
        public IActionResult Delete(int id)
        {
            var lecturer = lecturers.FirstOrDefault(l => l.LecturerID == id);
            if (lecturer == null)
                return NotFound();
            return View(lecturer);
        }

        // POST: Lecturer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var lecturer = lecturers.FirstOrDefault(l => l.LecturerID == id);
            if (lecturer != null)
                lecturers.Remove(lecturer);
            return RedirectToAction(nameof(Index));
        }
    }

    public class Lecturer
    {
        public int LecturerID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
