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

            string query = @"contiene(" + userFoodType.ToString() + ", "+ userDietAction.ToString() + ", R, CS, L, I, C, M).";

            var solutions = prolog.GetAllSolutions(filename, query);

            foreach (PrologEngine.ISolution s in prolog.SolutionIterator)
            {
                foreach (PrologEngine.IVarValue varValue in s.VarValuesIterator)
                {
                    MessageBox.Show(varValue.ToString());
                }
            }
        }

        public ConsultPrologAndDisplayResultModule()
        {
            InitializeComponent();
        }
    }
}
