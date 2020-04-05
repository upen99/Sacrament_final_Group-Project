using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sacrament_final.Data;
using Sacrament_final.Models;

namespace Sacrament_final.Pages.Sacraments
{
    public class DeleteModel : PageModel
    {
        private readonly Sacrament_final.Data.Sacrament_finalContext _context;

        public DeleteModel(Sacrament_final.Data.Sacrament_finalContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sacrament = await _context.Sacrament.FindAsync(id);

            if (Sacrament != null)
            {
                _context.Sacrament.Remove(Sacrament);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
