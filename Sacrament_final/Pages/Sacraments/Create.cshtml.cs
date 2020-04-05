using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sacrament_final.Data;
using Sacrament_final.Models;

namespace Sacrament_final.Pages.Sacraments
{
    public class CreateModel : PageModel
    {
        private readonly Sacrament_final.Data.Sacrament_finalContext _context;

        public CreateModel(Sacrament_final.Data.Sacrament_finalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sacrament Sacrament { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sacrament.Add(Sacrament);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}