using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.Models
{
    public class AddRecipeModel : PageModel
    {
        private readonly ILogger<AddRecipeModel> _logger;
        private readonly Context _context;
        [BindProperty]
        public Recipe Recipe {get; set;} = default!;
        public SelectList CategoriesDropDown {get; set;} = default!;

        public AddRecipeModel(Context context, ILogger<AddRecipeModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            CategoriesDropDown = new SelectList(_context.Categories.ToList(), "CategoryId", "Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recipes.Add(Recipe);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
