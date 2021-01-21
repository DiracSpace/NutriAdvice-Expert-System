using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NutriAdvice.Modules
{    public partial class UserInputModule : UserControl
    {
        public delegate void PassInformation();
        public int? UserAge
        {
            get
            {
                try
                {
                    return Int32.Parse(Agetxtbx.Text);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public double? UserWeight
        {
            get
            {
                try
                {
                    return double.Parse(Weighttxtbx.Text);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public int? UserHeight
        {
            get
            {
                try
                {
                    return Int32.Parse(Heighttxtbx.Text);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public string UserSex
        {
            get
            {
                try
                {
                    return SelectSexCmbbx.Items[SelectSexCmbbx.SelectedIndex].ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        public string UserActiviy
        {
            get
            {
                try
                {
                    return SelectActivityCmbbx.Items[SelectActivityCmbbx.SelectedIndex].ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        public Func<int, int> ReturnUserAge { get; set; }
        public Func<string, string> ReturnUserSex { get; set; }
        public Func<double, double> ReturnUserWeight { get; set; }
        public Func<int, int> ReturnUserHeight { get; set; }
        public Func<double, double> ReturnUserBMI { get; set; }
        public Func<string, string> ReturnBMIStatus { get; set; }
        public Func<double, double> ReturnUserBMR { get; set; }

        static double BMI(double weight, int height)
        {
            return weight / Math.Pow((height * 0.01), 2);
        }

        static string BMIStatus(double imc)
        {
            if (imc < 18.50)
                return "Estás debajo de tu IMC ideal";
            else if (imc > 18.50 && imc < 24.90)
                return "Estás en un IMC ideal";
            else if (imc > 25.00 && imc < 29.90)
                return "Tienes sobrepeso"; // sobrepeso
            else if (imc > 30.00 && imc < 34.90)
                return "Tienes obesidad I"; // obesidad grado 1
            else if (imc > 35.00 && imc < 40.00)
                return "Tienes obesidad II"; // obesidad grado 2
            else
                return "Tienes obesidad III"; // obesidas grado 3
        }

        /*
            Harris-Benedict Equation imperial formula
         */
        static double BMR(double weight, double height, int age, string sex)
        {
            if (sex == "M")
            {
                return ((10 * weight) + (6.25 * height) - (5 * age) + 5);
            }
            else
            {
                return ((10 * weight) + (6.25 * height) - (5 * age) -  161);
            }
        }

        public UserInputModule()
        {
            InitializeComponent();

            Calculatebtn.Click += (sender, ev) =>
            {
                var LocalAge = UserAge ?? 0;
                var LocalWeight = UserWeight ?? 0;
                var LocalHeight = UserHeight ?? 0;
                var LocalSex = UserSex ?? "";
                var LocalActivity = UserActiviy ?? "";

                var LocalBMI = BMI(LocalWeight, LocalHeight);
                var LocalBMIStatus = BMIStatus(LocalBMI);
                var LocalBMR = BMR(LocalWeight, LocalHeight, LocalAge, LocalSex);

                ReturnUserAge(LocalAge);
                ReturnUserSex(LocalSex);
                ReturnUserWeight(LocalWeight);
                ReturnUserHeight(LocalHeight);
                ReturnUserBMI(LocalBMI);
                ReturnBMIStatus(LocalBMIStatus);
                ReturnUserBMR(LocalBMR);
            };
        }
    }
}
