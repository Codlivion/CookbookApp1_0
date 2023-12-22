using System.Collections.Generic;

namespace CookbookApp1_0
{
    public partial class MainForm
    {
        public List<Dish> InitialList()
        {
            Dish instructions = new Dish("Instructions", "Not Food", 5);
            instructions.Ingredients = new List<Ingredient>()
            {
                new Ingredient("Test", 1, ""), new Ingredient("The", 2, ""), new Ingredient("Scroll", 3, ""), new Ingredient("Feature", 4, ""),
                new Ingredient("Test", 5, ""), new Ingredient("The", 6, ""), new Ingredient("Scroll", 7, ""), new Ingredient("Feature", 8, ""),
                new Ingredient("Test", 9, ""), new Ingredient("The", 10, ""), new Ingredient("Scroll", 11, ""), new Ingredient("Feature", 12, ""),
                new Ingredient("Test", 13, ""), new Ingredient("The", 14, ""), new Ingredient("Scroll", 15, ""), new Ingredient("Feature", 16, ""),
                new Ingredient("Test", 17, ""), new Ingredient("The", 18, ""), new Ingredient("Scroll", 19, ""), new Ingredient("Feature", 20, "")
            };
            instructions.Steps = new List<string>()
            {
                "Instructions",
                "You can scroll up and down with the mouse wheel",
                "Use '<' and '>' buttons at the bottom of the left panel to scroll through pages",
                "Use the New Recipe button at the bottom to open up a new Entry Form",
                "In the Entry Form, fill the Name, Course and Preperation Time parameters",
                "Add ingredients by filling the Quantity, Unit and Ingredient parameters and pushing Add Ingredient button",
                "Add steps by filling the large text box and pushing Add Step button",
                "When all ingredients and steps are added, push Add Recipe button to add recipe to the database",
                "Push Cancel button to close Entry Form without saving",
                "This text will be repeated so the scrolling feature can be tested",
                "Instructions",
                "You can scroll up and down with the mouse wheel",
                "Use '<' and '>' buttons at the bottom of the left panel to scroll through pages",
                "Use the New Recipe button at the bottom to open up a new Entry Form",
                "In the Entry Form, fill the Name, Course and Preperation Time parameters",
                "Add ingredients by filling the Quantity, Unit and Ingredient parameters and pushing Add Ingredient button",
                "Add steps by filling the large text box and pushing Add Step button",
                "When all ingredients and steps are added, push Add Recipe button to add recipe to the database",
                "Push Cancel button to close Entry Form without saving"
            };
            Dish codlivion = new Dish("Codlivion", "Developer", 5);
            codlivion.Ingredients = new List<Ingredient>()
            {
                new Ingredient("Just", 1, ""), new Ingredient("Some", 2, ""), new Ingredient("Hopeless", 3, ""), new Ingredient("Programmer", 4, ""),
                new Ingredient("Who", 5, ""), new Ingredient("May", 6, ""), new Ingredient("Code", 7, ""), new Ingredient("Some", 8, ""),
                new Ingredient("Weird", 9, ""), new Ingredient("Stuff", 10, ""),
            };
            codlivion.Steps = new List<string>()
            {
                "This is me!",
                "An indie game developer and programmer",
            };
            Dish dish1 = new Dish("Some Dish", "Main", 5);
            dish1.Ingredients = new List<Ingredient>()
            {
                new Ingredient("Vegetables", 4, ""), new Ingredient("Something", 2, ""), new Ingredient("Stuff", 1, "Pint"), new Ingredient("Liquid", 3, "Glasses")
            };
            dish1.Steps = new List<string>()
            {
                "Mix them all in a pot",
                "Boil them or whatever you want",
                "Wait until it's cooked",
                "Eat it!"
            };
            Dish dish2 = new Dish("Another Dish", "Main", 5);
            dish2.Ingredients = new List<Ingredient>()
            {
                new Ingredient("Vegetables", 3, ""), new Ingredient("Stuff", 2, "")
            };
            dish2.Steps = new List<string>()
            {
                "I'm being abstract here to save time writing these",
                "So the page scrolling can be tested"
            };
            Dish dish3 = new Dish("Yet Another Dish", "Main", 5);
            dish3.Ingredients = new List<Ingredient>()
            {
                new Ingredient("Dragon Scale", 1, ""), new Ingredient("Bat Wings", 2, "")
            };
            dish3.Steps = new List<string>()
            {
                "More of the same",
                "I'm not really into cooking"
            };
            Dish dish4 = new Dish("An Appetizer", "Appetizer", 5);
            dish4.Ingredients = new List<Ingredient>()
            {
                new Ingredient("Bread", 1, ""), new Ingredient("Cheese", 1, ""), new Ingredient("Tomato", 1, ""), new Ingredient("Cucumber", 1, "")
            };
            dish4.Steps = new List<string>()
            {
                "Though I may have some nice ideas for sandviches",
            };
            Dish dish5 = new Dish("Some Salad", "Salad", 5);
            dish5.Ingredients = new List<Ingredient>()
            {
                new Ingredient("Tomato", 1, ""), new Ingredient("Cucumber", 2, ""), new Ingredient("Onion", 3, "")
            };
            dish5.Steps = new List<string>()
            {
                "Salads are nice too"
            };
            Dish dish6 = new Dish("Some Dessert", "Dessert", 5);
            dish6.Ingredients = new List<Ingredient>()
            {
                new Ingredient("Milk", 1, ""), new Ingredient("Flour", 2, "")
            };
            dish6.Steps = new List<string>()
            {
                "Mix and Bake",
            };
            return new List<Dish>()
            {
                instructions, codlivion, dish1, dish2, dish3, dish4, dish5, dish6,
                instructions, instructions, instructions, instructions,
                codlivion, codlivion, codlivion, codlivion,
                dish1, dish1, dish1, dish1,
                dish2, dish2, dish2, dish2,
                dish3, dish3, dish3, dish3,
                dish4, dish4, dish4, dish4,
                dish5, dish5, dish5, dish5,
                dish6, dish6, dish6, dish6
            };
        }
    }
}