
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
            this.DisplayRecipeLink = new System.Windows.Forms.LinkLabel();
            this.dgvDisplayRecipeIngredients = new System.Windows.Forms.DataGridView();
            this.dgvIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRecipeIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayRecipeLink
            // 
            this.DisplayRecipeLink.AutoSize = true;
            this.DisplayRecipeLink.Location = new System.Drawing.Point(12, 9);
            this.DisplayRecipeLink.Name = "DisplayRecipeLink";
            this.DisplayRecipeLink.Size = new System.Drawing.Size(60, 15);
            this.DisplayRecipeLink.TabIndex = 3;
            this.DisplayRecipeLink.TabStop = true;
            this.DisplayRecipeLink.Text = "linkLabel1";
            this.DisplayRecipeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DisplayRecipeLink_LinkClicked);
            // 
            // dgvDisplayRecipeIngredients
            // 
            this.dgvDisplayRecipeIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayRecipeIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIngredient,
            this.dgvCalories,
            this.dgvQuantity});
            this.dgvDisplayRecipeIngredients.Location = new System.Drawing.Point(12, 41);
            this.dgvDisplayRecipeIngredients.Name = "dgvDisplayRecipeIngredients";
            this.dgvDisplayRecipeIngredients.RowTemplate.Height = 25;
            this.dgvDisplayRecipeIngredients.Size = new System.Drawing.Size(408, 198);
            this.dgvDisplayRecipeIngredients.TabIndex = 5;
            // 
            // dgvIngredient
            // 
            this.dgvIngredient.HeaderText = "Ingrediente";
            this.dgvIngredient.Name = "dgvIngredient";
            this.dgvIngredient.ReadOnly = true;
            // 
            // dgvCalories
            // 
            this.dgvCalories.HeaderText = "Calorías";
            this.dgvCalories.Name = "dgvCalories";
            this.dgvCalories.ReadOnly = true;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.HeaderText = "Medida";
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 251);
            this.Controls.Add(this.dgvDisplayRecipeIngredients);
            this.Controls.Add(this.DisplayRecipeLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRecipeIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel DisplayRecipeLink;
        private System.Windows.Forms.DataGridView dgvDisplayRecipeIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCalories;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
    }
}