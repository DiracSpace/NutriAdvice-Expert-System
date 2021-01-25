
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
            this.dgvDisplayRecipes = new System.Windows.Forms.DataGridView();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayRecipes
            // 
            this.dgvDisplayRecipes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDisplayRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.R,
            this.CS});
            this.dgvDisplayRecipes.EnableHeadersVisualStyles = false;
            this.dgvDisplayRecipes.Location = new System.Drawing.Point(10, 13);
            this.dgvDisplayRecipes.Name = "dgvDisplayRecipes";
            this.dgvDisplayRecipes.RowHeadersVisible = false;
            this.dgvDisplayRecipes.RowTemplate.Height = 25;
            this.dgvDisplayRecipes.Size = new System.Drawing.Size(206, 216);
            this.dgvDisplayRecipes.TabIndex = 0;
            // 
            // R
            // 
            this.R.HeaderText = "Receta";
            this.R.Name = "R";
            this.R.ReadOnly = true;
            // 
            // CS
            // 
            this.CS.HeaderText = "Calorías";
            this.CS.Name = "CS";
            this.CS.ReadOnly = true;
            // 
            // ConsultPrologAndDisplayResultModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDisplayRecipes);
            this.Name = "ConsultPrologAndDisplayResultModule";
            this.Size = new System.Drawing.Size(226, 244);
            this.Load += new System.EventHandler(this.ConsultPrologAndDisplayResultModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRecipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayRecipes;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS;
    }
}
