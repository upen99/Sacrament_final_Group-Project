using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sacrament_final.Data;
using Sacrament_final.Models;

namespace Sacrament_final.Pages.Sacraments
{
    public class EditModel : PageModel
    {
        private readonly Sacrament_final.Data.Sacrament_finalContext _context;

        public EditModel(Sacrament_final.Data.Sacrament_finalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sacrament Sacrament { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sacrament = await _context.Sacrament.FirstOrDefaultAsync(m => m.SacramentId == id);

            if (Sacrament == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sacrament).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SacramentExists(Sacrament.SacramentId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SacramentExists(int id)
        {
            return _context.Sacrament.Any(e => e.SacramentId == id);
        }
    }
}
