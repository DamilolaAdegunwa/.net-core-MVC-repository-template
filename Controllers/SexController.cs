using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GRA.Data;
using GRA.Models;

namespace GRA.Controllers
{
//public EfCoreRepository<Sex, ApplicationDbContext> RepositorySex;
//RepositorySex = new EfCoreRepository<Sex, ApplicationDbContext>(context, accessor, userManager);

    public class SexController : Controller
    {
        private readonly RepositoryContext repository;

        public SexController(RepositoryContext repository)
        {
            this.repository = repository;
        }

        // GET: Sex
        public async Task<IActionResult> Index()
        {
            return View(await repository.RepositorySex.All.ToListAsync());
        }

        // GET: Sex/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sex = await repository.RepositorySex.All 
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sex == null)
            {
                return NotFound();
            }

            return View(sex);
        }

        // GET: Sex/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sex/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id")] Sex sex)
        {
            if (ModelState.IsValid)
            {
                await repository.RepositorySex.Add(sex);
                return RedirectToAction(nameof(Index));
            }
            return View(sex);
        }

        // GET: Sex/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sex = await repository.RepositorySex.Get(id);
            if (sex == null)
            {
                return NotFound();
            }
            return View(sex);
        }

        // POST: Sex/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id")] Sex sex)
        {
            if (id != sex.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await repository.RepositorySex.Update(sex);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SexExists(sex.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sex);
        }

        // GET: Sex/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sex = await repository.RepositorySex.All 
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sex == null)
            {
                return NotFound();
            }

            return View(sex);
        }

        // POST: Sex/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await repository.RepositorySex.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool SexExists(int id)
        {
            return repository.RepositorySex.All.Any(e => e.Id == id);
        }
    }
}
