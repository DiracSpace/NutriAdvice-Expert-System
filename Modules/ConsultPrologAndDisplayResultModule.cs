using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void ConsultProlog()
        {
            var prolog = new PrologEngine(persistentCommandHistory: false);

            string filename = @"C:\Users\Roberto de León\Documents\git\NutriAdvice-Expert-System\Prolog\Recipes_List.pl";

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

            // Get each solution list
            //var index = dgvDisplayRecipes.Rows.Add();
            foreach (Solution s in solutions.NextSolution)
            {
                dgvDisplayRecipes.Rows.Add(s[0].Value, s[1].Value, s[2].Value, s[3].Value, s[4].Value, s[5].Value);
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
                */
            }
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
