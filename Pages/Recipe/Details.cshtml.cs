using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.Context _context;

        public DetailsModel(FinalProject.Models.Context context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipes
                .Include(r => r.Category).FirstOrDefaultAsync(m => m.RecipeId == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
