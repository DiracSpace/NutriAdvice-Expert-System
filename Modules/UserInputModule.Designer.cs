
namespace NutriAdvice.Modules
{
    partial class UserInputModule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Agetxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Weighttxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Heighttxtbx = new System.Windows.Forms.TextBox();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Calculatebtn);
            this.groupBox1.Controls.Add(this.Heighttxtbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Weighttxtbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Agetxtbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad:";
            // 
            // Agetxtbx
            // 
            this.Agetxtbx.Location = new System.Drawing.Point(6, 37);
            this.Agetxtbx.Name = "Agetxtbx";
            this.Agetxtbx.Size = new System.Drawing.Size(100, 23);
            this.Agetxtbx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso:";
            // 
            // Weighttxtbx
            // 
            this.Weighttxtbx.Location = new System.Drawing.Point(123, 37);
            this.Weighttxtbx.Name = "Weighttxtbx";
            this.Weighttxtbx.Size = new System.Drawing.Size(100, 23);
            this.Weighttxtbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Altura (cm):";
            // 
            // Heighttxtbx
            // 
            this.Heighttxtbx.Location = new System.Drawing.Point(241, 37);
            this.Heighttxtbx.Name = "Heighttxtbx";
            this.Heighttxtbx.Size = new System.Drawing.Size(100, 23);
            this.Heighttxtbx.TabIndex = 5;
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.Location = new System.Drawing.Point(266, 66);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(75, 23);
            this.Calculatebtn.TabIndex = 6;
            this.Calculatebtn.Text = "Iniciar";
            this.Calculatebtn.UseVisualStyleBackColor = true;
            // 
            // UserInputModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserInputModule";
            this.Size = new System.Drawing.Size(369, 129);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Agetxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Heighttxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Weighttxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calculatebtn;
    }
}
