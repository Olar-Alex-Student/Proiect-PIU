using Cont_Utilizator;
using System;

namespace InterfataUtilizator_WindowsForms
{
    partial class Form1
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
            this.Venit = new System.Windows.Forms.RadioButton();
            this.Cheltuieli = new System.Windows.Forms.RadioButton();
            this.Suma = new System.Windows.Forms.Label();
            this.textSuma = new System.Windows.Forms.TextBox();
            this.checkMancare = new System.Windows.Forms.CheckBox();
            this.Nume = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.Chirie = new System.Windows.Forms.CheckBox();
            this.Salar = new System.Windows.Forms.CheckBox();
            this.Tips = new System.Windows.Forms.CheckBox();
            this.Adauga = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.TipCont = new System.Windows.Forms.Label();
            this.Pentru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Venit
            // 
            this.Venit.AutoSize = true;
            this.Venit.Location = new System.Drawing.Point(15, 115);
            this.Venit.Name = "Venit";
            this.Venit.Size = new System.Drawing.Size(58, 20);
            this.Venit.TabIndex = 0;
            this.Venit.TabStop = true;
            this.Venit.Text = "Venit";
            this.Venit.UseVisualStyleBackColor = true;
            // 
            // Cheltuieli
            // 
            this.Cheltuieli.AutoSize = true;
            this.Cheltuieli.Location = new System.Drawing.Point(79, 115);
            this.Cheltuieli.Name = "Cheltuieli";
            this.Cheltuieli.Size = new System.Drawing.Size(82, 20);
            this.Cheltuieli.TabIndex = 1;
            this.Cheltuieli.TabStop = true;
            this.Cheltuieli.Text = "Cheltuieli";
            this.Cheltuieli.UseVisualStyleBackColor = true;
            // 
            // Suma
            // 
            this.Suma.AutoSize = true;
            this.Suma.Location = new System.Drawing.Point(12, 9);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(42, 16);
            this.Suma.TabIndex = 2;
            this.Suma.Text = "Suma";
            // 
            // textSuma
            // 
            this.textSuma.Location = new System.Drawing.Point(61, 9);
            this.textSuma.Name = "textSuma";
            this.textSuma.Size = new System.Drawing.Size(100, 22);
            this.textSuma.TabIndex = 3;
            // 
            // checkMancare
            // 
            this.checkMancare.AutoSize = true;
            this.checkMancare.Location = new System.Drawing.Point(79, 203);
            this.checkMancare.Name = "checkMancare";
            this.checkMancare.Size = new System.Drawing.Size(82, 20);
            this.checkMancare.TabIndex = 4;
            this.checkMancare.Text = "Mancare";
            this.checkMancare.UseVisualStyleBackColor = true;
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(12, 40);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(43, 16);
            this.Nume.TabIndex = 5;
            this.Nume.Text = "Nume";
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(61, 40);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 22);
            this.textNume.TabIndex = 6;
            // 
            // Chirie
            // 
            this.Chirie.AutoSize = true;
            this.Chirie.Location = new System.Drawing.Point(15, 203);
            this.Chirie.Name = "Chirie";
            this.Chirie.Size = new System.Drawing.Size(63, 20);
            this.Chirie.TabIndex = 7;
            this.Chirie.Text = "Chirie";
            this.Chirie.UseVisualStyleBackColor = true;
            // 
            // Salar
            // 
            this.Salar.AutoSize = true;
            this.Salar.Location = new System.Drawing.Point(15, 177);
            this.Salar.Name = "Salar";
            this.Salar.Size = new System.Drawing.Size(61, 20);
            this.Salar.TabIndex = 8;
            this.Salar.Text = "Salar";
            this.Salar.UseVisualStyleBackColor = true;
            // 
            // Tips
            // 
            this.Tips.AutoSize = true;
            this.Tips.Location = new System.Drawing.Point(79, 177);
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(56, 20);
            this.Tips.TabIndex = 9;
            this.Tips.Text = "Tips";
            this.Tips.UseVisualStyleBackColor = true;
            // 
            // Adauga
            // 
            this.Adauga.Location = new System.Drawing.Point(15, 244);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(75, 23);
            this.Adauga.TabIndex = 10;
            this.Adauga.Text = "Adauga";
            this.Adauga.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(15, 273);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 11;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // TipCont
            // 
            this.TipCont.AutoSize = true;
            this.TipCont.Location = new System.Drawing.Point(12, 87);
            this.TipCont.Name = "TipCont";
            this.TipCont.Size = new System.Drawing.Size(57, 16);
            this.TipCont.TabIndex = 12;
            this.TipCont.Text = "Tip Cont";
            // 
            // Pentru
            // 
            this.Pentru.AutoSize = true;
            this.Pentru.Location = new System.Drawing.Point(12, 149);
            this.Pentru.Name = "Pentru";
            this.Pentru.Size = new System.Drawing.Size(45, 16);
            this.Pentru.TabIndex = 13;
            this.Pentru.Text = "Pentru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Pentru);
            this.Controls.Add(this.TipCont);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.Salar);
            this.Controls.Add(this.Chirie);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.checkMancare);
            this.Controls.Add(this.textSuma);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Cheltuieli);
            this.Controls.Add(this.Venit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Venit;
        private System.Windows.Forms.RadioButton Cheltuieli;
        private System.Windows.Forms.Label Suma;
        private System.Windows.Forms.TextBox textSuma;
        private System.Windows.Forms.CheckBox checkMancare;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.CheckBox Chirie;
        private System.Windows.Forms.CheckBox Salar;
        private System.Windows.Forms.CheckBox Tips;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label TipCont;
        private System.Windows.Forms.Label Pentru;
    }
}

