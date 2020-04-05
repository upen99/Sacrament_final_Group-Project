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
    public class IndexModel : PageModel
    {
        private readonly Sacrament_final.Data.Sacrament_finalContext _context;

        public IndexModel(Sacrament_final.Data.Sacrament_finalContext context)
        {
            _context = context;
        }

        public IList<Sacrament> Sacrament { get;set; }

        public async Task OnGetAsync()
        {
            Sacrament = await _context.Sacrament.ToListAsync();
        }
    }
}
