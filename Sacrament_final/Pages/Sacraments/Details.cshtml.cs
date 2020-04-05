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
    public class DetailsModel : PageModel
    {
        private readonly Sacrament_final.Data.Sacrament_finalContext _context;

        public DetailsModel(Sacrament_final.Data.Sacrament_finalContext context)
        {
            _context = context;
        }

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
    }
}
