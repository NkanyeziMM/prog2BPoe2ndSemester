using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace.Controllers
{
    public class ProgramCoordinatorController : Controller
    {
        private static List<ProgramCoordinator> coordinators = new List<ProgramCoordinator>();

        // GET: ProgramCoordinator
        public IActionResult Index()
        {
            return View(coordinators);
        }

        // GET: ProgramCoordinator/Details/5
        public IActionResult Details(int id)
        {
            var coordinator = coordinators.FirstOrDefault(c => c.CoordinatorID == id);
            if (coordinator == null)
                return NotFound();
            return View(coordinator);
        }

        // GET: ProgramCoordinator/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgramCoordinator/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProgramCoordinator coordinator)
        {
            if (ModelState.IsValid)
            {
                coordinator.CoordinatorID = coordinators.Count + 1; // Generate a new ID
                coordinators.Add(coordinator);
                return RedirectToAction(nameof(Index));
            }
            return View(coordinator);
        }

        // GET: ProgramCoordinator/Edit/5
        public IActionResult Edit(int id)
        {
            var coordinator = coordinators.FirstOrDefault(c => c.CoordinatorID == id);
            if (coordinator == null)
                return NotFound();
            return View(coordinator);
        }

        // POST: ProgramCoordinator/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProgramCoordinator coordinator)
        {
            var existingCoordinator = coordinators.FirstOrDefault(c => c.CoordinatorID == id);
            if (existingCoordinator == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                existingCoordinator.Name = coordinator.Name;
                existingCoordinator.Email = coordinator.Email;
                return RedirectToAction(nameof(Index));
            }
            return View(coordinator);
        }

        // GET: ProgramCoordinator/Delete/5
        public IActionResult Delete(int id)
        {
            var coordinator = coordinators.FirstOrDefault(c => c.CoordinatorID == id);
            if (coordinator == null)
                return NotFound();
            return View(coordinator);
        }

        // POST: ProgramCoordinator/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var coordinator = coordinators.FirstOrDefault(c => c.CoordinatorID == id);
            if (coordinator != null)
                coordinators.Remove(coordinator);
            return RedirectToAction(nameof(Index));
        }
    }

    public class ProgramCoordinator
    {
        public int CoordinatorID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
