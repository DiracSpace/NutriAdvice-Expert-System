
namespace NutriAdvice.Modules
{
    partial class DisplayUserStatusModule
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
            this.DisplayAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayWeight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayHeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DisplayBmi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisplayBmi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DisplayHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DisplayWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DisplayAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad:";
            // 
            // DisplayAge
            // 
            this.DisplayAge.AutoSize = true;
            this.DisplayAge.Location = new System.Drawing.Point(48, 29);
            this.DisplayAge.Name = "DisplayAge";
            this.DisplayAge.Size = new System.Drawing.Size(0, 15);
            this.DisplayAge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso:";
            // 
            // DisplayWeight
            // 
            this.DisplayWeight.AutoSize = true;
            this.DisplayWeight.Location = new System.Drawing.Point(48, 57);
            this.DisplayWeight.Name = "DisplayWeight";
            this.DisplayWeight.Size = new System.Drawing.Size(0, 15);
            this.DisplayWeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Altura:";
            // 
            // DisplayHeight
            // 
            this.DisplayHeight.AutoSize = true;
            this.DisplayHeight.Location = new System.Drawing.Point(54, 84);
            this.DisplayHeight.Name = "DisplayHeight";
            this.DisplayHeight.Size = new System.Drawing.Size(0, 15);
            this.DisplayHeight.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "IMC:";
            // 
            // DisplayBmi
            // 
            this.DisplayBmi.AutoSize = true;
            this.DisplayBmi.Location = new System.Drawing.Point(54, 113);
            this.DisplayBmi.Name = "DisplayBmi";
            this.DisplayBmi.Size = new System.Drawing.Size(0, 15);
            this.DisplayBmi.TabIndex = 7;
            // 
            // DisplayUserStatusModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "DisplayUserStatusModule";
            this.Size = new System.Drawing.Size(269, 264);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DisplayAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DisplayBmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DisplayHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DisplayWeight;
    }
}
