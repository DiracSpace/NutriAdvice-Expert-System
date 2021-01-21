using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NutriAdvice.Modules
{
    public partial class UserInputModule : UserControl
    {
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

        public Func<int, int> ReturnUserAge { get; set; }
        public Func<double, double> ReturnUserWeight { get; set; }
        public Func<int, int> ReturnUserHeight { get; set; }
        public UserInputModule()
        {
            InitializeComponent();

            Calculatebtn.Click += (sender, ev) =>
            {
                var LocalAge = UserAge ?? 0;
                var LocalWeight = UserWeight ?? 0;
                var LocalHeight = UserHeight ?? 0;

                ReturnUserAge(LocalAge);
                ReturnUserWeight(LocalWeight);
                ReturnUserHeight(LocalHeight);
            };
        }
    }
}
