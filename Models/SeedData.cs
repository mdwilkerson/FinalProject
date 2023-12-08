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
                        new() {Title = "Roasted Chicken & Vegetables", Description = "Preheat the oven to 375°F. - Add the potatoes, onion, tomatoes, peppers, and olives to a large bowl, and the chicken to another bowl. Add half of each the garlic, oil, vinegar, salt, pepper, and paprika over the veggies, and the other half of these ingredients to the chicken. Toss everything well. - Dump the veggies into a large 913 baking dish. Arrange the chicken over the veggies. Roast for 1 hour, or until the chicken is cooked through and the potatoes are fork tender. - Sprinkle the fresh basil all over the chicken and veggies. Serve, and drizzle some of the pan juices over the chicken."},
                        new Recipe {Title = "Ground Turkey Lettuce Wraps", Description = "Heat oil in a large skillet over medium-high. Add onion and cook until just soft, about 5 minutes. Add turkey and season with salt. Cook, breaking up meat with the side of a spoon, until meat is cooked through, 4 minutes. - Stir in tomato paste and chili powder and cook 1 minute. Add broth and simmer, stirring occasionally, until thickened, about 2 minutes more. - Double up lettuce leaves. Divide meat mixture among leaves. Sprinkle with cheese, tomato, onion, avocado, and cilantro and serve."},
                        new Recipe {Title = "Chicken & Dumplings", Description = "Soup Mixture In a large bowl combine water and better than bouillon to make chicken broth. Place in the microwave for 3 minutes. Remove and stir well. Set aside. In a large stock pot over medium heat, add carrots, celery, onion, and 4 tbsp butter. Stir well to combine. Let cook for 10 minutes, stirring often to ensure that the onions dont burn . Add ½ cup flour and stir to combine. Add chicken broth and bring to a boil. Add the shredded chicken, Italian seasoning, garlic powder, onion powder, salt, and milk. Stir well. Turn temperature to low and let simmer while making the dumplings mixture. For the Dumplings: in a separate bowl, add the seasonings to the Bisquick and gently toss to incorporate. Drizzle the milk into the bisquick flour and gently stir to incorporate the liquid. DO NOT OVERMIX. Let the batter rest for 1-2 minutes.  Using a 1 ½ tablespoon (1.5 inch) cookie scoop, gently drop the Bisquick batter *leaving space between each dumpling because they will expand in size as they cook* into the simmering chicken and vegetables. Cover the pot with a lid and allow the dumplings to simmer on low heat for 15 minutes. Very carefully turn over each dumpling in the pot (being careful not to break them apart) and continue to cook, uncovered, for an additional 2-3 minutes. Serve and enjoy. Optional to garnish with a little chopped parsley. This yields 12 dumplings."},
                        new Recipe {Title = "Low Carb Taco Casserole", Description = "Preheat oven to 350ºF Pan fry the cauliflower rice in oil over medium/high heat until browned. Transfer to greased 2qt casserole dish and spread in an even layer.  Brown ground beef with red pepper and onion over medium/high heat. Drain excess fat if necessary then add taco seasoning, tomato paste and water. Stir and cook until liquid absorbs. Transfer to casserole dish in an even layer on top of cauliflower rice. Top with shredded cheese and bake for 10-15 minutes. Spread sour cream over the top. Sprinkle with extra shredded cheese and preferred toppings."},
                        new Recipe {Title = "Chicken Enchiladas", Description = "Preheat the oven to 350 degrees. In a large bowl mix together chicken, beans, corn, tomatoes, and spices.     Divide cheese evenly into 2 separate bowls. Set one bowl of cheese to the side, you will use it for topping once all the enchiladas are assembled. Pour 1/2 cup enchilada sauce into the bottom of a 913 pan and spread evenly. Pour 1 can of enchilada sauce into a shallow bowl. Dip a tortilla in the enchilada sauce, covering both sides with sauce. Let the excess drip off. Place about 1/3 cup chicken mixture in the middle of the tortilla and top with cheese. Roll tortilla around the chicken mixture and place seam side up in the baking dish. Assemble remaining enchiladas and place them all in the 9×13 pan. Top enchiladas with remaining enchilada sauce and sprinkle on the remaining cheese. Bake for 20 minutes. Remove from the oven and top with chopped cilantro. Serve warm! Enjoy with more cilantro, sour cream, salsa, tomato and avocado."},
                        new Recipe {Title = "Creamy Tortellini Soup", Description = "Bring a large pot of salted water to a boil. Cook the tortellini according to package directions, then drain and set aside. Heat 1-2 tablespoons of olive oil in a large pot or Dutch oven set over medium heat. Add the chopped onion and sauté for about 5 minutes. As the onion softens, chop the carrots and celery, then add them to the pot with onions. Mix well and cook for an additional 5 minutes.      Add the minced garlic and butter. Mix well. Once the butter is melted, sprinkle the veggies with ¼ of all-purpose flour. Mix, stirring continuously, for approximately one minute to cook out the flour. Slowly add the chicken broth, whisking continuously. Add the dried thyme, dried oregano, Italian seasoning, salt, and pepper. Add the milk and heavy cream. Increase heat to high. Once the soup almost reaches a boil, immediately reduce heat to medium-low. Add the cooked, shredded chicken and frozen corn. Cook until heated and the soup has returned to a simmer. Add the precooked tortellini to the simmering pot or add the cooked tortellini to individual soup bowls. Serve garnished with freshly chopped parsley, thyme, or grated parmesan cheese, if desired."},
                        new Recipe {Title = "Chicken Pot Pie with Biscuits", Description = "Preheat oven to 375°F.  a-inch baking dish with nonstick spray. In large bowl, combine. Mix until combined. Pour the mixture into the baking dish.Now grab the can of biscuits. Cut each biscuit into quarters, in a large bowl. Drizzle with the melted butter, and toss.Bake the biscuits for about 5-7 minutes on a lightly grease baking sheet. Top the chicken mixture with the biscuits. Bake, uncovered, for 20 to 25 minutes.Let cool until its safe to eat. Serve & enjoy!"},
                        new Recipe {Title = "Simple Butter Chicken", Description = "Marinate chicken in the marinade, 30 min or overnight. Remove chicken from marinade allowing excess to drip off. Brown chicken in 1 tablespoon olive oil or vegetable oil until browned on both sides, about 6 minutes. Remove from pan and set aside.  Melt butter over medium heat, cook onions until tender. Add spices and cook 1 minute or until fragrant. Add chicken broth, browned chicken, crushed tomatoes and sugar. Simmer 10 minutes or until slightly thickened. Add cream and cook an additional 5-10 minutes. Discard cinnamon stick. Top with cilantro and serve over rice."},
                          
                        }
                    },
                    
                    new Category
                    {
                        Name = "Lunch",
                        Recipes = new List<Recipe>{
                        new Recipe {Title = "Sweet & Spicy Turkey Sandwich", Description = "Heat a small skillet over medium heat. Butter one side of each of the bread slices with one teaspoon butter. Place one slice, butter side down, in the skillet. Top with the turkey and cheese slices. Place the second slice of bread on top, butter side up. - When the first side of the sandwich is golden brown, turn and brown the other side, 3 to 5 minutes per side, or until the cheese begins to melt. - Remove sandwich to a plate and top with strawberry preserves, or serve the preserves on the side."},
                        new Recipe {Title = "Simple Green Salad", Description = "Roast the almonds: Preheat the oven to 350°F and line a baking sheet with parchment paper. Place the almonds on the sheet and toss with tamari. Bake for 10 to 14 minutes or until browned. Remove from the oven and let cool for 5 minutes. - Assemble the salad. In a large bowl toss the lettuce with a few spoonfuls of the dressing. Add the cucumber, parmesan, pepitas, avocado, and tamari almonds. Drizzle with more dressing and top with microgreens. Season to taste with flaky sea salt, if desired."},
                        new Recipe {Title = "Club Wraps", Description = "In a small bowl, beat the cream cheese, ranch dressing and salad dressing mix until well blended. In another bowl, combine the bacon, onion, olives, pimientos and jalapenos. - Spread cream cheese mixture over tortillas; layer with ham, turkey and roast beef. Sprinkle with bacon mixture and cheddar cheese; roll up."},
                        new Recipe {Title = "Tuna Rice Bowl", Description = "Combine tuna and rice, toss with coconut aminos. Add more as needed. Drizzle sriracha mayo on top and top with avocado and sesame seeds. Serve with kimchi and edamame on the side. Enjoy!"},
                          new Recipe {Title = "Toasted Italian Sandwich", Description = "Cut the ciabatta roll in half and toast each half for a few minutes until the edges start to brown a bit.Spread the pesto sauce on the top slice of roll and spread the sun-dried tomatoes on the bottom slice of roll.  Pile on your smoked ham, salami, black pepper salami, pepperoni and turkey pepperoni and top with the mozzarella slices. Toast the bottom half of the sandwich for a few minutes until the mozzarella melts and the meats warm up. You do not need to toast the pesto side again. Slice in half and serve warm."},
                          new Recipe {Title = "Jalapeno Popper Chicken Salad", Description = "Place chicken breasts in a medium sized sauce pan and cover with cold water until both breasts are covered with at least 1″ of water Place pot on the stove uncovered and bring water to a boil Reduce the water to a simmer and cover with a lid Simmer the chicken for 14 minutes then remove from heat While the chicken cookes prepare the bacon on the stovetop  fry at medium-low heat until crispy Also, prepare the jalapeños by deseeding and slicing into small strips. **If you want a spicier chicken salad, leave some of the seeds attached to the pepper. Place 1 tbsp of avocado oil in a frying pan over medium heat Saute jalapeños until soft, about 10 minutes. Then, add 1/2 tsp salt and saute for an additional minute Place cooked bacon on a towel to drain some grease and then chop into bite sized pieces In a small bowl combine mayonnaise, green onion, onion powder, and garlic powder Once cooked, remove the chicken from the water and shredd on a plate or cutting board with 2 forks In a large bowl combine shredded chicken, mayo mixture, sauteed jalapeños, and chopped baconMix all ingredients until evenly combinedEnjoy immediately or store in the refrigerator in an airtight container for up to 4 days"},
                          new Recipe {Title = "Air fried - Chicken Sausage and Veggies", Description = "Chop the veggies and add them to a large bowl.  Drizzle them with olive oil and toss to coat them all.  In a smaller bowl, mix the spices together with the salt and pepper and add the spice blend to the veggies.  Toss them in the spices to get them all nice and coated. Slice the sausage into ¾ inch rounds and add it to the bowl with the veggies and toss everything together. Preheat the air fryer, if needed to 390 degrees F and spray the air fryer basket with cooking spray.  Add the veggies and sausage to the air fryer basket in an even layer and close and cook them for 10 minutes, flipping them in the basket halfway through the cooking time.  You may need to do this in batches depending on the size of your air fryer. Once the chicken sausage and veggies are done cooking, remove them from the air fryer and serve as is or with cooked cauliflower rice or brown rice. "},
                          new Recipe {Title = "Air fried - Bagel Pizzas", Description = "Preheat the Air Fryer, if needed, to 370 degrees F. Brush the bagel halves with olive oil and then sprinkle with garlic powder and oregano.   Toast for 3 minutes. Remove the bagel halves and then spread with pizza sauce and sprinkle with mozzarella and parmesan cheese. Add any additional toppings if desired. Return the bagel pizzas to the oven and toast for 4 minutes at 370 degrees F, or until the cheese is melted and golden. Note: If you just want your cheese melted, not golden, cook for only 3 minutes at 370 degrees F. Remove the bagel pizzas and allow to cool for 1-2 minute before enjoying."}
                        }

                    },

        
            
                    new Category 
                    {
                        Name = "Breakfast",
                        Recipes = new List<Recipe>{
                            new Recipe {Title = "Simple Overnight Oats", Description = "Stir it all together. In a small jar, stir together the oats, milk, yogurt, chia seeds, and maple syrup. - Its soaking time. Place the jar in the fridge to let the oats soak for at least 2 hours, though overnight is best. - Add toppings and serve. The next morning, add your favorite toppings and enjoy! Alternatively, you can scoop the oats out into a bowl and add toppings from there."},
                            new Recipe {Title = "Avocado Toast", Description = "Toast your slice of bread until golden and firm. - Remove the pit from your avocado. Use a big spoon to scoop out the flesh. Put it in a bowl and mash it up with a fork until its as smooth as you like it. Mix in a pinch of salt (about ⅛ teaspoon) and add more to taste, if desired. - Spread avocado on top of your toast. Enjoy as-is or top with any extras offered in this post (I highly recommend a light sprinkle of flaky sea salt, if you have it)."},
                            new Recipe {Title = "Southern Biscuits & Gravy", Description = "Preheat the oven to 350 degrees F (175 degrees C). Arrange biscuits 1 to 2 inches apart on an ungreased cookie sheet. Bake in the preheated oven until golden brown, about 13 to 15 minutes. - Meanwhile, cook sausage in a large skillet over medium heat until thoroughly heated, stirring frequently, about 5 to 6 minutes. - Stir in flour until well combined. Gradually add milk, stirring continuously, until the gravy thickens and comes to a boil. Reduce heat to medium-low; simmer and stir for 2 more minutes. Season to taste with salt and pepper. - Split biscuits in half. Place 2 halves on each of 8 plates; top with about 1/3 cup gravy."},
                            new Recipe {Title = "Breakfast Quesadillas", Description = "Whisk together eggs a medium bowl. 2 eggs Melt 1 tablespoon butter in a skillet over medium heat. Add the eggs and cook, undisturbed, until a thin layer of cooked egg appears around the edge of the skillet. Using a rubber spatula gently move the eggs around the skillet until they are nice and fluffy. They will still be glossy in color.1 tbsp butter Once your eggs are done, remove them from the heat and get ready to add them to your flour tortillas.2 flour tortillas Add 1/2 tablespoon of butter to a skillet over medium heat  swirling around the pan until melted.    Next, add 1 tortilla to the pan ( I use the burrito size) and top with a sprinkle of melted cheese.  1/3 cup shredded cheese Then, add your eggs to the tortilla evenly and top with the remaining cheese. Cook the bottom tortilla until lightly brown, then flipping over and browning the other side evenly. Add 1/2 tbsp of butter if needed. Once it’s brown, remove the quesadilla to a cutting board and allow to rest for 1-2 minutes. Cut into triangles and serve with salsa if desired"},
                          new Recipe {Title = "Hawaiian Roll French Toast", Description = "Whisk together eggs, milk, vanilla, cinnamon, salt, and nutmeg in a wide, deep bowl. Heat a griddle or large skillet over medium heat and brush with 1 Tbsp of the butter. Working in batches, dip Hawaiian roll halves into egg/milk mixture until saturated and shake off excess liquid before placing rolls on heated griddle. Cook until golden brown, about 2-3 minutes. Flip and cook for another 2-3 minutes on other side.  Remove to a plate and keep warm while you continue cooking the remaining rolls. Add more butter to griddle as needed until all rolls have been dipped and toasted. Sprinkle powdered sugar over Hawaiian roll french toast and drizzle on maple syrup, if desired, before serving."},
                          new Recipe {Title = "Apple Pie Cinnamon Roll Bake", Description = "Preheat oven to 350 degrees F. Coat a 9x13 baking dish with non-stick spray and set aside. Unwrap the cinnamon rolls from the tube and set the included frosting aside for later use. Cut each of the cinnamon rolls into fourths and place in a large bowl.  Spoon the apple pie filling into the bowl and gently stir to combine. Pour the cinnamon roll mixture into the prepared baking dish and spread into an even layer. Bake for 45 to 50 minutes, or until the center is cooked through and no longer doughy. Remove from oven and drizzle the top of the cinnamon roll bake with the icing. Serve warm and enjoy!"},
                          new Recipe {Title = "Monkey Bread", Description = "Preheat oven to 350 degrees. Liberally grease a 9 cup bundt pan. Remove the biscuits from the can and cut each biscuit into 4 pieces.    Place biscuit pieces into a large zip top bag and add the granulated sugar and cinnamon. Seal the bag and shake to coat the biscuit pieces in the cinnamon and sugar. Add the biscuit pieces to the prepared bundt pan. Melt the butter and brown sugar in a small sauce pan over medium heat, stirring often. Once smooth and combined, pour the mixture over the biscuits. Bake for 35 minutes or until no longer doughy in the center.Let cool for 5 minutes and then carefully flip onto a serving dish. Let cool for 10 minutes before serving."},
                          new Recipe {Title = "Bacon and Cheese Quiche", Description = "Preheat the oven to 350°F. Using a shallow-sided 9 inch glass pie plate, place the softened pie crust inside and crimp the edges. We double-folded the edges of the crust and then crimped. Add the bacon and cheese to the bottom of the pie crust. In a medium bowl mix the milk, eggs, salt, and pepper, then pour over the bacon and cheese. Bake for 45-50 minutes or until a knife, inserted in the center, comes out clean. Let set for 5-10 minutes before cutting."}
                        }
                    }                                    
                  );
                context.SaveChanges();
            }
        }
    }
}