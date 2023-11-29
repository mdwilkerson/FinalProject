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
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Dinner",
                        Recipes = new List<Recipe>{
                        new() {Title = "Spaghetti", Description = "Cooking instructions: -boil water for the pasta in a big enough pot for it to move around to not stick together -in a good pan (one that can withstand high heat) put your onion in & cook over med-hi heat til you can smell the aroma/it's translucent - add in the meat and cook til no pink's left anywhere, cover, & turn heat very low -put your pasta in the boiling pot & stir -go back to your sauce & pour in just enough sauce to cover the meat; add a bit of pasta water to add starch to the sauce. Add more from the jar if you like a thinner sauce. -drain your pasta & add a bit of regular olive oil to prevent sticking - Serve immediately by placing a serving of pasta in your bowl/plate and adding as much sauce on top as you'd like. If you keep the sauce & pasta separate, your noodles won't break down when you decide to store and reheat your meal."},
                        new() {Title = "Roasted Chicken & Vegetables", Description = "Preheat the oven to 375°F. - Add the potatoes, onion, tomatoes, peppers, and olives to a large bowl, and the chicken to another bowl. Add half of each the garlic, oil, vinegar, salt, pepper, and paprika over the veggies, and the other half of these ingredients to the chicken. Toss everything well. - Dump the veggies into a large 9×13 baking dish. Arrange the chicken over the veggies. Roast for 1 hour, or until the chicken is cooked through and the potatoes are fork tender. - Sprinkle the fresh basil all over the chicken and veggies. Serve, and drizzle some of the pan juices over the chicken."},
                        new Recipe {Title = "Ground Turkey Lettuce Wraps", Description = "Heat oil in a large skillet over medium-high. Add onion and cook until just soft, about 5 minutes. Add turkey and season with salt. Cook, breaking up meat with the side of a spoon, until meat is cooked through, 4 minutes. - Stir in tomato paste and chili powder and cook 1 minute. Add broth and simmer, stirring occasionally, until thickened, about 2 minutes more. - Double up lettuce leaves. Divide meat mixture among leaves. Sprinkle with cheese, tomato, onion, avocado, and cilantro and serve."}
                        }
                    },
                    
                    
                    new Category
                    {
                        Name = "Lunch",
                        Recipes = new List<Recipe>{
                            new Recipe {Title = "Sweet & Spicy Turkey Sandwich", Description = "Heat a small skillet over medium heat. Butter one side of each of the bread slices with one teaspoon butter. Place one slice, butter side down, in the skillet. Top with the turkey and cheese slices. Place the second slice of bread on top, butter side up. - When the first side of the sandwich is golden brown, turn and brown the other side, 3 to 5 minutes per side, or until the cheese begins to melt. - Remove sandwich to a plate and top with strawberry preserves, or serve the preserves on the side."},
                            new Recipe {Title = "Simple Green Salad", Description = "Roast the almonds: Preheat the oven to 350°F and line a baking sheet with parchment paper. Place the almonds on the sheet and toss with tamari. Bake for 10 to 14 minutes or until browned. Remove from the oven and let cool for 5 minutes. - Assemble the salad. In a large bowl toss the lettuce with a few spoonfuls of the dressing. Add the cucumber, parmesan, pepitas, avocado, and tamari almonds. Drizzle with more dressing and top with microgreens. Season to taste with flaky sea salt, if desired."},
                        new Recipe {Title = "Club Wraps", Description = "In a small bowl, beat the cream cheese, ranch dressing and salad dressing mix until well blended. In another bowl, combine the bacon, onion, olives, pimientos and jalapenos. - Spread cream cheese mixture over tortillas; layer with ham, turkey and roast beef. Sprinkle with bacon mixture and cheddar cheese; roll up."} 
                        }

                    },
        
            
                    new Category 
                    {
                        Name = "Breakfast",
                        Recipes = new List<Recipe>{
                            new Recipe {Title = "Simple Overnight Oats", Description = "Stir it all together. In a small jar, stir together the oats, milk, yogurt, chia seeds, and maple syrup. - Its soaking time. Place the jar in the fridge to let the oats soak for at least 2 hours, though overnight is best. - Add toppings and serve. The next morning, add your favorite toppings and enjoy! Alternatively, you can scoop the oats out into a bowl and add toppings from there."},
                            new Recipe {Title = "Avocado Toast", Description = "Toast your slice of bread until golden and firm. - Remove the pit from your avocado. Use a big spoon to scoop out the flesh. Put it in a bowl and mash it up with a fork until its as smooth as you like it. Mix in a pinch of salt (about ⅛ teaspoon) and add more to taste, if desired. - Spread avocado on top of your toast. Enjoy as-is or top with any extras offered in this post (I highly recommend a light sprinkle of flaky sea salt, if you have it)."},
                            new Recipe {Title = "Southern Biscuits & Gravy", Description = "Preheat the oven to 350 degrees F (175 degrees C). Arrange biscuits 1 to 2 inches apart on an ungreased cookie sheet. Bake in the preheated oven until golden brown, about 13 to 15 minutes. - Meanwhile, cook sausage in a large skillet over medium heat until thoroughly heated, stirring frequently, about 5 to 6 minutes. - Stir in flour until well combined. Gradually add milk, stirring continuously, until the gravy thickens and comes to a boil. Reduce heat to medium-low; simmer and stir for 2 more minutes. Season to taste with salt and pepper. - Split biscuits in half. Place 2 halves on each of 8 plates; top with about 1/3 cup gravy."}
                        }
                    }                  
                  );
                context.SaveChanges();
            }
        }
    }
}