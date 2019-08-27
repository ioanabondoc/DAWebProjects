using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolWebApplication2.Models;

namespace SchoolWebApplication2.Controllers
{
    public class AdoptionCenterController : Controller
    {
        private readonly SchoolWebApplication2Context _context;

        public AdoptionCenterController(SchoolWebApplication2Context context)
        {
            _context = context;
        }

        // GET: AdoptionCenter
        public async Task<IActionResult> Index()
        {
            return View(await _context.Animal.ToListAsync());
        }

        //POST:A searchString
        [HttpPost]
        public async Task<IActionResult> Index(string searchGender,string searchString)
        {
            var animals = from m in _context.Animal
                         select m;
            if (!String.IsNullOrEmpty(searchGender))
            {
                animals = animals.Where(x => x.Gender == searchGender);
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                animals = animals.Where(s => s.Breed.Contains(searchString));
            }

            return View(await animals.ToListAsync());
        }

        // GET: AdoptionCenter/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // GET: AdoptionCenter/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdoptionCenter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Type,Gender,Breed,DateArrived,Age,PhotoLink")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                animal.Id = Guid.NewGuid();
                _context.Add(animal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }

        // GET: AdoptionCenter/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animal.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        // POST: AdoptionCenter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Type,Gender,Breed,DateArrived,Age,PhotoLink")] Animal animal)
        {
            if (id != animal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(animal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimalExists(animal.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
            return View(animal);
        }

        // GET: AdoptionCenter/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // POST: AdoptionCenter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var animal = await _context.Animal.FindAsync(id);
            _context.Animal.Remove(animal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalExists(Guid id)
        {
            return _context.Animal.Any(e => e.Id == id);
        }

        public IActionResult About()
        {
            return View("~/Views/AdoptionCenter/About.cshtml");
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
    }
}
