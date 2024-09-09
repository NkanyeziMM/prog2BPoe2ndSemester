using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace.Controllers
{
    public class AcademicManagerController : Controller
    {
        private static List<AcademicManager> managers = new List<AcademicManager>();

        // GET: AcademicManager
        public IActionResult Index()
        {
            return View(managers);
        }

        // GET: AcademicManager/Details/5
        public IActionResult Details(int id)
        {
            var manager = managers.FirstOrDefault(m => m.ManagerID == id);
            if (manager == null)
                return NotFound();
            return View(manager);
        }

        // GET: AcademicManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AcademicManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AcademicManager manager)
        {
            if (ModelState.IsValid)
            {
                manager.ManagerID = managers.Count + 1; // Generate a new ID
                managers.Add(manager);
                return RedirectToAction(nameof(Index));
            }
            return View(manager);
        }

        // GET: AcademicManager/Edit/5
        public IActionResult Edit(int id)
        {
            var manager = managers.FirstOrDefault(m => m.ManagerID == id);
            if (manager == null)
                return NotFound();
            return View(manager);
        }

        // POST: AcademicManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, AcademicManager manager)
        {
            var existingManager = managers.FirstOrDefault(m => m.ManagerID == id);
            if (existingManager == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                existingManager.Name = manager.Name;
                existingManager.Email = manager.Email;
                return RedirectToAction(nameof(Index));
            }
            return View(manager);
        }

        // GET: AcademicManager/Delete/5
        public IActionResult Delete(int id)
        {
            var manager = managers.FirstOrDefault(m => m.ManagerID == id);
            if (manager == null)
                return NotFound();
            return View(manager);
        }

        // POST: AcademicManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var manager = managers.FirstOrDefault(m => m.ManagerID == id);
            if (manager != null)
                managers.Remove(manager);
            return RedirectToAction(nameof(Index));
        }
    }

    public class AcademicManager
    {
        public int ManagerID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
