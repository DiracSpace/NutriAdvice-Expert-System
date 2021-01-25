
namespace NutriAdvice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetData = new NutriAdvice.Modules.UserInputModule();
            this.DisplayData = new NutriAdvice.Modules.DisplayUserStatusModule();
            this.DisplayResults = new NutriAdvice.Modules.ConsultPrologAndDisplayResultModule();
            this.SuspendLayout();
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(3, 3);
            this.GetData.Name = "GetData";
            this.GetData.ReturnBMIStatus = null;
            this.GetData.ReturnUserAge = null;
            this.GetData.ReturnUserBMI = null;
            this.GetData.ReturnUserBMR = null;
            this.GetData.ReturnUserDailyIntake = null;
            this.GetData.ReturnUserDietAction = null;
            this.GetData.ReturnUserDietCalories = null;
            this.GetData.ReturnUserFoodType = null;
            this.GetData.ReturnUserHeight = null;
            this.GetData.ReturnUserSex = null;
            this.GetData.ReturnUserWeight = null;
            this.GetData.Size = new System.Drawing.Size(367, 207);
            this.GetData.TabIndex = 0;
            // 
            // DisplayData
            // 
            this.DisplayData.Location = new System.Drawing.Point(3, 190);
            this.DisplayData.Name = "DisplayData";
            this.DisplayData.Size = new System.Drawing.Size(304, 214);
            this.DisplayData.TabIndex = 1;
            // 
            // DisplayResults
            // 
            this.DisplayResults.Location = new System.Drawing.Point(376, 3);
            this.DisplayResults.Name = "DisplayResults";
            this.DisplayResults.Size = new System.Drawing.Size(321, 401);
            this.DisplayResults.TabIndex = 2;
            this.DisplayResults.UserDietAction = null;
            this.DisplayResults.UserDietIntake = 0D;
            this.DisplayResults.UserFoodType = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 409);
            this.Controls.Add(this.DisplayResults);
            this.Controls.Add(this.DisplayData);
            this.Controls.Add(this.GetData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Modules.UserInputModule GetData;
        private Modules.DisplayUserStatusModule DisplayData;
        private Modules.ConsultPrologAndDisplayResultModule DisplayResults;
    }
}

