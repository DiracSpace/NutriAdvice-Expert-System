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
using NutriAdvice.Forms;
using System.IO;
using System.Net;

namespace NutriAdvice.Modules
{
    public partial class ConsultPrologAndDisplayResultModule : UserControl
    {
        public List<Recipe> RecipeList = new List<Recipe>();
        public Recipe receta = new Recipe();

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

        public void ConsultProlog()
        {
            dgvDisplayRecipes.Rows.Clear();
            RecipeList.Clear();
            receta = new Recipe();

            var prolog = new PrologEngine(persistentCommandHistory: false);

            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NutriAdvice-Expert-System\Prolog\Recipes_List.pl";

            if (!File.Exists(filename))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NutriAdvice-Expert-System\Prolog\";
                System.IO.FileInfo file = new System.IO.FileInfo(path);
                file.Directory.Create();
                MessageBox.Show("No se encontró archivo, descargando .. ");
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileAsync(
                        new System.Uri("https://raw.githubusercontent.com/DiracSpace/NutriAdvice-Expert-System/main/Prolog/Recipes_List.pl"),
                        filename
                    );
                }
                MessageBox.Show("Listo, vuelva a dar click");
            }

            string query = @"contiene(" + '"' + userFoodType.ToString() + '"' + "," + '"' + userDietAction.ToString() + '"' + ", R, CS, L, I, C, M).";

            var solutions = prolog.GetAllSolutions(filename, query);

            string nombreReceta = "";
            
            // Get each solution list
            for (int i = 0; i < solutions.Count; i++)
            {
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

            for (int i = 0; i < RecipeList.Count; i++)
            {
                if (RecipeList[i].getName() != "" && RecipeList[i].getCalories() != "")
                {
                    dgvDisplayRecipes.Rows.Add(RecipeList[i].getName(), RecipeList[i].getCalories());
                }
            }
        }

        public ConsultPrologAndDisplayResultModule()
        {
            InitializeComponent();
        }

        private void dgvDisplayRecipes_CellClick(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvDisplayRecipes.CurrentCell.RowIndex.ToString());
            
            Form2 showData = new Form2(RecipeList, dgvDisplayRecipes.CurrentCell.RowIndex);
            showData.GetRecipeIngredientData();
            showData.Show();
        }
    }
}
