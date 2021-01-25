
namespace NutriAdvice.Forms
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayRecipeCalories = new System.Windows.Forms.Label();
            this.DisplayRecipeQuantity = new System.Windows.Forms.Label();
            this.DisplayRecipeLink = new System.Windows.Forms.LinkLabel();
            this.DisplayRecipeIngredient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayRecipeCalories
            // 
            this.DisplayRecipeCalories.AutoSize = true;
            this.DisplayRecipeCalories.Location = new System.Drawing.Point(114, 140);
            this.DisplayRecipeCalories.Name = "DisplayRecipeCalories";
            this.DisplayRecipeCalories.Size = new System.Drawing.Size(47, 15);
            this.DisplayRecipeCalories.TabIndex = 1;
            this.DisplayRecipeCalories.Text = "calorias";
            // 
            // DisplayRecipeQuantity
            // 
            this.DisplayRecipeQuantity.AutoSize = true;
            this.DisplayRecipeQuantity.Location = new System.Drawing.Point(114, 188);
            this.DisplayRecipeQuantity.Name = "DisplayRecipeQuantity";
            this.DisplayRecipeQuantity.Size = new System.Drawing.Size(53, 15);
            this.DisplayRecipeQuantity.TabIndex = 2;
            this.DisplayRecipeQuantity.Text = "cantidad";
            // 
            // DisplayRecipeLink
            // 
            this.DisplayRecipeLink.AutoSize = true;
            this.DisplayRecipeLink.Location = new System.Drawing.Point(114, 65);
            this.DisplayRecipeLink.Name = "DisplayRecipeLink";
            this.DisplayRecipeLink.Size = new System.Drawing.Size(60, 15);
            this.DisplayRecipeLink.TabIndex = 3;
            this.DisplayRecipeLink.TabStop = true;
            this.DisplayRecipeLink.Text = "linkLabel1";
            this.DisplayRecipeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DisplayRecipeLink_LinkClicked);
            // 
            // DisplayRecipeIngredient
            // 
            this.DisplayRecipeIngredient.AutoSize = true;
            this.DisplayRecipeIngredient.Location = new System.Drawing.Point(114, 101);
            this.DisplayRecipeIngredient.Name = "DisplayRecipeIngredient";
            this.DisplayRecipeIngredient.Size = new System.Drawing.Size(67, 15);
            this.DisplayRecipeIngredient.TabIndex = 4;
            this.DisplayRecipeIngredient.Text = "ingrediente";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 251);
            this.Controls.Add(this.DisplayRecipeIngredient);
            this.Controls.Add(this.DisplayRecipeLink);
            this.Controls.Add(this.DisplayRecipeQuantity);
            this.Controls.Add(this.DisplayRecipeCalories);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DisplayRecipeCalories;
        private System.Windows.Forms.Label DisplayRecipeQuantity;
        private System.Windows.Forms.LinkLabel DisplayRecipeLink;
        private System.Windows.Forms.Label DisplayRecipeIngredient;
    }
}