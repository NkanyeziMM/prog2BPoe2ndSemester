using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace.Controllers
{
    public class ClaimController : Controller
    {
        private static List<Claim> claims = new List<Claim>();

        // GET: Claim
        public IActionResult Index()
        {
            return View(claims);
        }

        // GET: Claim/Details/5
        public IActionResult Details(int id)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimID == id);
            if (claim == null)
                return NotFound();
            return View(claim);
        }

        // GET: Claim/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Claim/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Claim claim)
        {
            if (ModelState.IsValid)
            {
                claim.ClaimID = claims.Count + 1; // Generate a new ID
                claims.Add(claim);
                return RedirectToAction(nameof(Index));
            }
            return View(claim);
        }

        // GET: Claim/Edit/5
        public IActionResult Edit(int id)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimID == id);
            if (claim == null)
                return NotFound();
            return View(claim);
        }

        // POST: Claim/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Claim claim)
        {
            var existingClaim = claims.FirstOrDefault(c => c.ClaimID == id);
            if (existingClaim == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                existingClaim.LecturerID = claim.LecturerID;
                existingClaim.HoursWorked = claim.HoursWorked;
                existingClaim.TotalAmount = claim.TotalAmount;
                existingClaim.ClaimStatus = claim.ClaimStatus;
                existingClaim.SubmissionDate = claim.SubmissionDate;
                return RedirectToAction(nameof(Index));
            }
            return View(claim);
        }

        // GET: Claim/Delete/5
        public IActionResult Delete(int id)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimID == id);
            if (claim == null)
                return NotFound();
            return View(claim);
        }

        // POST: Claim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimID == id);
            if (claim != null)
                claims.Remove(claim);
            return RedirectToAction(nameof(Index));
        }
    }

    public class Claim
    {
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }
        public int HoursWorked { get; set; }
        public decimal TotalAmount { get; set; }
        public string? ClaimStatus { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
