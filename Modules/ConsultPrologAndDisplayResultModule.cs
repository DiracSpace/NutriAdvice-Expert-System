using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutriAdvice.Classes;
using Prolog;

namespace NutriAdvice.Modules
{
    public partial class ConsultPrologAndDisplayResultModule : UserControl
    {
        private string userDietAction;
        public string UserDietAction
        {
            set { userDietAction = value; }
            get { return userDietAction; }
        }

        private double userDietIntake;
        public double UserDietIntake
        {
            set { userDietIntake = value; }
            get { return userDietIntake; }
        }

        private string userFoodType;
        public string UserFoodType
        {
            set { userFoodType = value; }
            get { return userFoodType; }
        }

        public Func<Recipe, string> ReturnRecipe { get; set; }

        public void ConsultProlog()
        {
            var prolog = new PrologEngine(persistentCommandHistory: false);

            string filename = @"C:\Users\Marco\Documents\Proyectos Visual Studio\NutriAdvice-Expert-System\Prolog\Recipes_List.pl";

            //string query = @"contiene('" + userFoodType.ToString() + "', '"+ userDietAction.ToString() + "', R, CS, L, I, C, M).";
            string query = @"contiene(" + '"' + userFoodType.ToString() + '"' + "," + '"' + userDietAction.ToString() + '"' + ", R, CS, L, I, C, M).";

            var solutions = prolog.GetAllSolutions(filename, query);

            // iterating the properties
            /*
            foreach (PrologEngine.ISolution s in prolog.SolutionIterator)
            {
                foreach (PrologEngine.IVarValue varValue in s.VarValuesIterator)
                {
                    MessageBox.Show(varValue.ToString());
                }
            }
            */
            List<Recipe> RecipeList = new List<Recipe>();
            Recipe receta = new Recipe();
            string nombreReceta = "";
            // Get each solution list
            //var index = dgvDisplayRecipes.Rows.Add();
            Console.WriteLine("Llegue aqui antes de la evaluacion");
            for (int i = 0; i < solutions.Count; i++)
            {
                Console.WriteLine("Entre al for: "+i);
                if (i == 0)
                {
                    nombreReceta = solutions[i][0].Value;

                    receta.setName(solutions[i][0].Value);
                    receta.setCalories(solutions[i][1].Value);
                    receta.setLink(solutions[i][2].Value);

                    receta.addIngredient(solutions[i][3].Value, solutions[i][4].Value, solutions[i][5].Value);
                }
                else
                {
                    if(nombreReceta.Equals(solutions[i][0].Value))
                    {
                        receta.addIngredient(solutions[i][3].Value, solutions[i][4].Value, solutions[i][5].Value);
                    }
                    else
                    {
                        RecipeList.Add(receta);
                        receta = new Recipe();
                        nombreReceta = solutions[i][0].Value;
                        receta.setName(solutions[i][0].Value);
                        receta.setCalories(solutions[i][1].Value);
                        receta.setLink(solutions[i][2].Value);

                        receta.addIngredient(solutions[i][3].Value, solutions[i][4].Value, solutions[i][5].Value);
                    }
                }
            }

            for(int i = 0; i < RecipeList.Count; i++)
            {
                Console.WriteLine("NombreReceta: "+RecipeList[i].getName());
                Console.WriteLine("CaloriasReceta: " + RecipeList[i].getCalories());
                Console.WriteLine("LinkReceta: " + RecipeList[i].getLink());
                Console.WriteLine("");
                for (int j = 0; j < RecipeList[i].getIngredientList().Count; j++)
                {
                    Console.WriteLine("NombreIngrediente: " + RecipeList[i].getIngredientList()[j].getName());
                    Console.WriteLine("CantidadIngrediente: " + RecipeList[i].getIngredientList()[j].getQuantity());
                    Console.WriteLine("MedidaIngrediente: " + RecipeList[i].getIngredientList()[j].getAmount());
                    Console.WriteLine("");
                }
            }

            /*
            foreach (Solution s in solutions.NextSolution)
            {
                //dgvDisplayRecipes.Rows.Add(s[0].Value, s[1].Value);
                /*
                 * 
                 * foreach (Variable v in s.NextVariable)
                 * {
                 *      if (dgvDisplayRecipes.Columns.Contains(v.Name))
                 *      {
                 *          dgvDisplayRecipes.Columns.
                 *          MessageBox.Show("Columna: " + v.Name + ", Celda: " + v.Value);
                 *      }
                 * }
                
            }*/
        }

        public ConsultPrologAndDisplayResultModule()
        {
            InitializeComponent();
        }

        private void ConsultPrologAndDisplayResultModule_Load(object sender, EventArgs e)
        {

        }
    }
}
