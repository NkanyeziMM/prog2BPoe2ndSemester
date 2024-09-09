using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace.Controllers
{
    public class SupportingDocumentController : Controller
    {
        private static List<SupportingDocument> documents = new List<SupportingDocument>();

        // GET: SupportingDocument
        public IActionResult Index()
        {
            return View(documents);
        }

        // GET: SupportingDocument/Details/5
        public IActionResult Details(int id)
        {
            var document = documents.FirstOrDefault(d => d.DocumentID == id);
            if (document == null)
                return NotFound();
            return View(document);
        }

        // GET: SupportingDocument/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SupportingDocument/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SupportingDocument document)
        {
            if (ModelState.IsValid)
            {
                document.DocumentID = documents.Count + 1; // Generate a new ID
                documents.Add(document);
                return RedirectToAction(nameof(Index));
            }
            return View(document);
        }

        // GET: SupportingDocument/Edit/5
        public IActionResult Edit(int id)
        {
            var document = documents.FirstOrDefault(d => d.DocumentID == id);
            if (document == null)
                return NotFound();
            return View(document);
        }

        // POST: SupportingDocument/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, SupportingDocument document)
        {
            var existingDocument = documents.FirstOrDefault(d => d.DocumentID == id);
            if (existingDocument == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                existingDocument.DocumentPath = document.DocumentPath;
                return RedirectToAction(nameof(Index));
            }
            return View(document);
        }

        // GET: SupportingDocument/Delete/5
        public IActionResult Delete(int id)
        {
            var document = documents.FirstOrDefault(d => d.DocumentID == id);
            if (document == null)
                return NotFound();
            return View(document);
        }

        // POST: SupportingDocument/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var document = documents.FirstOrDefault(d => d.DocumentID == id);
            if (document != null)
                documents.Remove(document);
            return RedirectToAction(nameof(Index));
        }
    }

    public class SupportingDocument
    {
        public int DocumentID { get; set; }
        public string? DocumentPath { get; set; }
    }
}
