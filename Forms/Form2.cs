using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriAdvice.Classes;
using NutriAdvice.Modules;

namespace NutriAdvice.Forms
{
    public partial class Form2 : Form
    {
        public List<Recipe> LocalRecipeList;
        public Recipe Localreceta;
        public int location;
        public string RecipeWebsiteLink;

        public Form2(List<Recipe> RecipeList, int index)
        {
            InitializeComponent();

            LocalRecipeList = RecipeList;
            location = index;
        }

        public void GetRecipeIngredientData()
        {
            for (int i = 0; i < LocalRecipeList.Count; i++)
            {
                for (int j = 0; j < LocalRecipeList[location].getIngredientList().Count; j++)
                {
                    RecipeWebsiteLink = LocalRecipeList[location].getLink();
                    DisplayRecipeIngredient.Text = LocalRecipeList[location].getIngredientList()[j].getName();
                    DisplayRecipeCalories.Text = LocalRecipeList[location].getIngredientList()[j].getAmount();
                    DisplayRecipeQuantity.Text = LocalRecipeList[location].getIngredientList()[j].getQuantity();
                }
            }
        }

        private void DisplayRecipeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo { FileName = RecipeWebsiteLink, UseShellExecute = true };
            Process.Start(psi);
        }
    }
}
