using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NutriAdvice.Modules
{
    public partial class DisplayUserStatusModule : UserControl
    {
        public int UserAge
        {
            set
            {
                DisplayAge2.Text = value.ToString();
            }
        }

        public double UserWeight
        {
            set
            {
                DisplayWeight2.Text = value.ToString();
            }
        }

        public int UserHeight
        {
            set
            {
                DisplayHeight.Text = value.ToString();
            }
        }

        public double UserBMI
        {
            set
            {
                DisplayBmi.Text = Math.Round(value, 2).ToString("N2");
            }
        }

        public string UserBMIStatus
        {
            set
            {
                DisplayBMIStatus.Text = value.ToString();
            }
        }

        public DisplayUserStatusModule()
        {
            InitializeComponent();
        }
    }
}
