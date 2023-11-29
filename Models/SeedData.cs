using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Recipes.Any())
                {
                    return;
                }
                context.Recipes.AddRange(
                    new Category
                    {
                        Name = "Dinner",
                        Recipes = new List<Recipe>{
                        new Recipe {Title = "Spaghetti", Description = "Cooking instructions: -boil water for the pasta in a big enough pot for it to move around to not stick together -in a good pan (one that can withstand high heat) put your onion in & cook over med-hi heat til you can smell the aroma/it's translucent - add in the meat and cook til no pink's left anywhere, cover, & turn heat very low -put your pasta in the boiling pot & stir -go back to your sauce & pour in just enough sauce to cover the meat; add a bit of pasta water to add starch to the sauce. Add more from the jar if you like a thinner sauce. -drain your pasta & add a bit of regular olive oil to prevent sticking - Serve immediately by placing a serving of pasta in your bowl/plate and adding as much sauce on top as you'd like. If you keep the sauce & pasta separate, your noodles won't break down when you decide to store and reheat your meal."}
                        }
                    },
                    new Category 
                    {
                        Name = "Dinner",
                        Recipes = new List<Recipe>{
                            new Recipe {Title = ""}
                        }
                    },
             

                );
            }
        }
    }
}