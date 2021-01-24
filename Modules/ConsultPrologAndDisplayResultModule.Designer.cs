
namespace NutriAdvice.Modules
{
    partial class ConsultPrologAndDisplayResultModule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayPrologUserAction = new System.Windows.Forms.Label();
            this.DisplayPrologUserDietIntake = new System.Windows.Forms.Label();
            this.DisplayPrologUserFoodType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayPrologUserAction
            // 
            this.DisplayPrologUserAction.AutoSize = true;
            this.DisplayPrologUserAction.Location = new System.Drawing.Point(46, 47);
            this.DisplayPrologUserAction.Name = "DisplayPrologUserAction";
            this.DisplayPrologUserAction.Size = new System.Drawing.Size(138, 15);
            this.DisplayPrologUserAction.TabIndex = 0;
            this.DisplayPrologUserAction.Text = "DisplayPrologUserAction";
            // 
            // DisplayPrologUserDietIntake
            // 
            this.DisplayPrologUserDietIntake.AutoSize = true;
            this.DisplayPrologUserDietIntake.Location = new System.Drawing.Point(46, 87);
            this.DisplayPrologUserDietIntake.Name = "DisplayPrologUserDietIntake";
            this.DisplayPrologUserDietIntake.Size = new System.Drawing.Size(156, 15);
            this.DisplayPrologUserDietIntake.TabIndex = 1;
            this.DisplayPrologUserDietIntake.Text = "DisplayPrologUserDietIntake";
            // 
            // DisplayPrologUserFoodType
            // 
            this.DisplayPrologUserFoodType.AutoSize = true;
            this.DisplayPrologUserFoodType.Location = new System.Drawing.Point(46, 126);
            this.DisplayPrologUserFoodType.Name = "DisplayPrologUserFoodType";
            this.DisplayPrologUserFoodType.Size = new System.Drawing.Size(154, 15);
            this.DisplayPrologUserFoodType.TabIndex = 2;
            this.DisplayPrologUserFoodType.Text = "DisplayPrologUserFoodType";
            // 
            // ConsultPrologAndDisplayResultModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayPrologUserFoodType);
            this.Controls.Add(this.DisplayPrologUserDietIntake);
            this.Controls.Add(this.DisplayPrologUserAction);
            this.Name = "ConsultPrologAndDisplayResultModule";
            this.Size = new System.Drawing.Size(265, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayPrologUserAction;
        private System.Windows.Forms.Label DisplayPrologUserDietIntake;
        private System.Windows.Forms.Label DisplayPrologUserFoodType;
    }
}
