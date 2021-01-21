using NutriAdvice.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriAdvice
{
    public partial class Form1 : Form
    {
        public UserInputModule UserInputModule { get; set; }
        public DisplayUserStatusModule DisplayUserStatusModule { get; set; }

        public Form1()
        {
            InitializeComponent();

            UserInputModule = GetData;
            DisplayUserStatusModule = DisplayData;

            UserInputModule.ReturnUserAge += (age) =>
            {
                DisplayUserStatusModule.UserAge = age;
                return age;
            };

            UserInputModule.ReturnUserWeight += (weight) => 
            {
                DisplayUserStatusModule.UserWeight = weight;
                return weight;
            };

            UserInputModule.ReturnUserHeight += (height) =>
            {
                DisplayUserStatusModule.UserHeight = height;
                return height;
            };

            UserInputModule.ReturnUserBMI += (bmi) =>
            {
                DisplayUserStatusModule.UserBMI = bmi;
                return bmi;
            };

            UserInputModule.ReturnBMIStatus += (bmistatus) => 
            {
                DisplayUserStatusModule.UserBMIStatus = bmistatus;
                return bmistatus;
            };
        }
    }
}
