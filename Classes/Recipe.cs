using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriAdvice.Classes
{
    public class Recipe
    {
        private string name;
        private string link;
        private string calories;
        private List<Ingredient> ingredientsList = new List<Ingredient>();

        public Recipe()
        {
            name = "";
            link = "";
            calories = "";
            ingredientsList.Clear();
        }

        public Recipe(string name, string link, string calories)
        {
            this.name = name;
            this.link = link;
            this.calories = calories;
            ingredientsList.Clear();
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getLink()
        {
            return link;
        }

        public void setLink(string link)
        {
            this.link = link;
        }

        public string getCalories()
        {
            return calories;
        }

        public void setCalories(string calories)
        {
            this.calories = calories;
        }

        public Ingredient getIngredient(int indice)
        {
            return ingredientsList[indice];
        }

        public void addIngredient(string name, string quantity, string amount)
        {
            ingredientsList.Add(new Ingredient(name,quantity,amount));
        }

        public List<Ingredient> getIngredientList()
        {
            return ingredientsList;
        }

        public void cleanIngredientList()
        {
            ingredientsList.Clear();
        }
    }
}
