using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    { 
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        private bool EmployeeExists(string id)
{
    return _context.Employee.Any();
}
        public async Task<IActionResult> Index()
        {
            var model = await _context.Employee.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId, Age")]EmployeeController employee)
        {
            if(ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();;
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
         public async Task<IActionResult> Edit (string id)
         {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }
            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
         }
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Edit (string id, [Bind("EmployeeId, Age")]Employee employee)
         {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                try 
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
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
            return View(employee);
         }
         public async Task<IActionResult> Delete (string id)
         {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }
            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
         }
         [HttpPost, ActionName("Delete")]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> DeleteConfirmed(string id)
         {
            if (_context.Employee == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Employee' is null.");
            }
            var employee = await _context.Employee.FindAsync(id);
            if (employee != null)
            {
                _context.Employee.Remove(employee);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
         }
         private bool PersonExists(string id)
         {
            return (_context.Employee?.Any(e => e.EmployeeId == id)).GetValueOrDefault();
         }
    }}
        