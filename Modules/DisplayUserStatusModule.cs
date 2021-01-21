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
                DisplayAge.Text = value.ToString();
            }
        }

        public double UserWeight
        {
            set
            {
                DisplayWeight.Text = value.ToString();
            }
        }

        public int UserHeight
        {
            set
            {
                DisplayHeight.Text = value.ToString();
            }
        }

        public DisplayUserStatusModule()
        {
            InitializeComponent();
        }
    }
}
