
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
            this.label6 = new System.Windows.Forms.Label();
            this.SelectTypeCmbbx = new System.Windows.Forms.ComboBox();
            this.SelectActivityCmbbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectSexCmbbx = new System.Windows.Forms.ComboBox();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.Heighttxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Weighttxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Agetxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SelectTypeCmbbx);
            this.groupBox1.Controls.Add(this.SelectActivityCmbbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SelectSexCmbbx);
            this.groupBox1.Controls.Add(this.Calculatebtn);
            this.groupBox1.Controls.Add(this.Heighttxtbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Weighttxtbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Agetxtbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de comida:";
            // 
            // SelectTypeCmbbx
            // 
            this.SelectTypeCmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTypeCmbbx.FormattingEnabled = true;
            this.SelectTypeCmbbx.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Cena",
            "Ensalada"});
            this.SelectTypeCmbbx.Location = new System.Drawing.Point(241, 86);
            this.SelectTypeCmbbx.Name = "SelectTypeCmbbx";
            this.SelectTypeCmbbx.Size = new System.Drawing.Size(100, 23);
            this.SelectTypeCmbbx.TabIndex = 11;
            // 
            // SelectActivityCmbbx
            // 
            this.SelectActivityCmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectActivityCmbbx.FormattingEnabled = true;
            this.SelectActivityCmbbx.Items.AddRange(new object[] {
            "Sedentario",
            "Ligero",
            "Moderado",
            "Alto",
            "Intenso"});
            this.SelectActivityCmbbx.Location = new System.Drawing.Point(123, 86);
            this.SelectActivityCmbbx.Name = "SelectActivityCmbbx";
            this.SelectActivityCmbbx.Size = new System.Drawing.Size(100, 23);
            this.SelectActivityCmbbx.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Actividad física:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexo:";
            // 
            // SelectSexCmbbx
            // 
            this.SelectSexCmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSexCmbbx.FormattingEnabled = true;
            this.SelectSexCmbbx.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SelectSexCmbbx.Location = new System.Drawing.Point(6, 86);
            this.SelectSexCmbbx.Name = "SelectSexCmbbx";
            this.SelectSexCmbbx.Size = new System.Drawing.Size(100, 23);
            this.SelectSexCmbbx.TabIndex = 7;
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.Location = new System.Drawing.Point(266, 124);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(75, 23);
            this.Calculatebtn.TabIndex = 6;
            this.Calculatebtn.Text = "Iniciar";
            this.Calculatebtn.UseVisualStyleBackColor = true;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // Heighttxtbx
            // 
            this.Heighttxtbx.Location = new System.Drawing.Point(241, 37);
            this.Heighttxtbx.Name = "Heighttxtbx";
            this.Heighttxtbx.Size = new System.Drawing.Size(100, 23);
            this.Heighttxtbx.TabIndex = 5;
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
            // Weighttxtbx
            // 
            this.Weighttxtbx.Location = new System.Drawing.Point(123, 37);
            this.Weighttxtbx.Name = "Weighttxtbx";
            this.Weighttxtbx.Size = new System.Drawing.Size(100, 23);
            this.Weighttxtbx.TabIndex = 3;
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
            // Agetxtbx
            // 
            this.Agetxtbx.Location = new System.Drawing.Point(6, 37);
            this.Agetxtbx.Name = "Agetxtbx";
            this.Agetxtbx.Size = new System.Drawing.Size(100, 23);
            this.Agetxtbx.TabIndex = 1;
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
            // UserInputModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserInputModule";
            this.Size = new System.Drawing.Size(370, 174);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelectSexCmbbx;
        private System.Windows.Forms.ComboBox SelectActivityCmbbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SelectTypeCmbbx;
    }
}
