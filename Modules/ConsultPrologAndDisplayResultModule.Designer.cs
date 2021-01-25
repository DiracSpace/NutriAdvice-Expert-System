
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
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayRecipes
            // 
            this.dgvDisplayRecipes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDisplayRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.R,
            this.CS,
            this.L,
            this.I,
            this.C,
            this.M});
            this.dgvDisplayRecipes.EnableHeadersVisualStyles = false;
            this.dgvDisplayRecipes.Location = new System.Drawing.Point(10, 13);
            this.dgvDisplayRecipes.Name = "dgvDisplayRecipes";
            this.dgvDisplayRecipes.RowHeadersVisible = false;
            this.dgvDisplayRecipes.RowTemplate.Height = 25;
            this.dgvDisplayRecipes.Size = new System.Drawing.Size(660, 216);
            this.dgvDisplayRecipes.TabIndex = 0;
            // 
            // R
            // 
            this.R.HeaderText = "Rp";
            this.R.Name = "R";
            this.R.ReadOnly = true;
            // 
            // CS
            // 
            this.CS.HeaderText = "CSp";
            this.CS.Name = "CS";
            this.CS.ReadOnly = true;
            // 
            // L
            // 
            this.L.HeaderText = "Lp";
            this.L.Name = "L";
            this.L.ReadOnly = true;
            // 
            // I
            // 
            this.I.HeaderText = "Ip";
            this.I.Name = "I";
            this.I.ReadOnly = true;
            // 
            // C
            // 
            this.C.HeaderText = "Cp";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // M
            // 
            this.M.HeaderText = "Mp";
            this.M.Name = "M";
            this.M.ReadOnly = true;
            // 
            // ConsultPrologAndDisplayResultModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDisplayRecipes);
            this.Name = "ConsultPrologAndDisplayResultModule";
            this.Size = new System.Drawing.Size(681, 244);
            this.Load += new System.EventHandler(this.ConsultPrologAndDisplayResultModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRecipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayRecipes;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS;
        private System.Windows.Forms.DataGridViewTextBoxColumn L;
        private System.Windows.Forms.DataGridViewTextBoxColumn I;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
    }
}
