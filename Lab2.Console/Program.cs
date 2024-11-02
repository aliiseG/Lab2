using Lab2.DataAccess;
using System;
namespace Lab2.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new RecipeDbContext();

            db.Database.EnsureCreated();

            var results = db.Recipes
                .Where(r => r.PrepTime <= 30);
            System.Console.WriteLine("Prep time under 30 minutes:");
            foreach (var recipe in results)
            {
                System.Console.WriteLine(recipe.DishName);
            }
            var record = db.Recipes.FirstOrDefault(r => r.Category == "Dinner");
            System.Console.WriteLine("Dinner: " + record.DishName);


            //var rcp = new Recipe
            //{
            //    Category = "Breakfast",
            //    DishName = "Cheese omelette",
            //    PrepTime = 10,
            //    Ingredients = new List<Ingredient>
            //    {
            //        new Ingredient
            //        {
            //            Name = "Egg",
            //            Amount = 2
            //        },
            //        new Ingredient
            //        {
            //            Name = "Olive oil",
            //            Amount = 0.5,
            //            Units = "tbsp"
            //        },
            //        new Ingredient
            //        {
            //            Name = "Butter",
            //            Amount = 1,
            //            Units = "tbsp"
            //        },
            //        new Ingredient
            //        {
            //            Name = "cheddar",
            //            Amount = 15,
            //            Units = "g"
            //        }
            //    }

            //};
            //var rcp2 = new Recipe
            //{
            //    Category = "Breakfast",
            //    DishName = "Fried bread",
            //    PrepTime = 7,
            //    Ingredients = new List<Ingredient>
            //    {
            //        new Ingredient
            //        {
            //            Name = "White bread",
            //            Amount = 2,
            //            Units = "slices"
            //        },
            //        new Ingredient
            //        {
            //            Name = "Sunflower oil",
            //            Amount = 2,
            //            Units = "tbsp"
            //        }

            //    }

            //};
            //var rcp3 = new Recipe
            //{
            //    Category = "Dinner",
            //    DishName = "Cheese omelette",
            //    PrepTime = 60,
            //    Ingredients = new List<Ingredient>
            //    {
            //        new Ingredient
            //        {
            //            Name = "Coconut oil",
            //            Amount = 1,
            //            Units = "tbsp"
            //        },
            //        new Ingredient
            //        {
            //            Name = "Garlic cloves",
            //            Amount = 2
            //        },
            //        new Ingredient
            //        {
            //            Name = "Ginger",
            //            Amount = 1
            //        },
            //        new Ingredient
            //        {
            //            Name = "Thai red curry paste",
            //            Amount = 3,
            //            Units = "tbsp"
            //        },
            //        new Ingredient
            //        {
            //            Name = "Smooth peanut butter",
            //            Amount = 1,
            //            Units = "tbsp"
            //        },
            //        new Ingredient
            //        {
            //            Name = "Sweet potato",
            //            Amount = 500,
            //            Units = "g"
            //        },
            //        new Ingredient
            //        {
            //            Name = "Coconut milk",
            //            Amount = 400,
            //            Units = "ml"
            //        },
            //        new Ingredient
            //        {
            //            Name = "Spinach",
            //            Amount = 200,
            //            Units = "g"
            //        },
            //        new Ingredient
            //        {
            //            Name = "Lime",
            //            Amount = 1
            //        }
            //    }

            //};

            //db.Recipes.Add(rcp2);
            //db.Recipes.Add(rcp3);
            db.SaveChanges();
        }
    }
}  
