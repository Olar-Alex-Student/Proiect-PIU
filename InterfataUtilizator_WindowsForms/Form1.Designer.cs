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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxSumaIntrodusa = new System.Windows.Forms.GroupBox();
            this.buttonAfiseaza = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.labelTipSuma = new System.Windows.Forms.Label();
            this.radioButtonCheltuieli = new System.Windows.Forms.RadioButton();
            this.radioButtonVenit = new System.Windows.Forms.RadioButton();
            this.textBoxDetalii = new System.Windows.Forms.TextBox();
            this.labelDetaliiSuma = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelSumaIntrodusa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxSumaCont = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSumaCont = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSumaIntrodusa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSumaCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSumaIntrodusa
            // 
            resources.ApplyResources(this.groupBoxSumaIntrodusa, "groupBoxSumaIntrodusa");
            this.groupBoxSumaIntrodusa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxSumaIntrodusa.Controls.Add(this.buttonAfiseaza);
            this.groupBoxSumaIntrodusa.Controls.Add(this.buttonAdauga);
            this.groupBoxSumaIntrodusa.Controls.Add(this.labelTipSuma);
            this.groupBoxSumaIntrodusa.Controls.Add(this.radioButtonCheltuieli);
            this.groupBoxSumaIntrodusa.Controls.Add(this.radioButtonVenit);
            this.groupBoxSumaIntrodusa.Controls.Add(this.textBoxDetalii);
            this.groupBoxSumaIntrodusa.Controls.Add(this.labelDetaliiSuma);
            this.groupBoxSumaIntrodusa.Controls.Add(this.numericUpDown1);
            this.groupBoxSumaIntrodusa.Controls.Add(this.labelSumaIntrodusa);
            this.groupBoxSumaIntrodusa.Name = "groupBoxSumaIntrodusa";
            this.groupBoxSumaIntrodusa.TabStop = false;
            this.groupBoxSumaIntrodusa.Enter += new System.EventHandler(this.groupBoxSumaIntrodusa_Enter);
            // 
            // buttonAfiseaza
            // 
            resources.ApplyResources(this.buttonAfiseaza, "buttonAfiseaza");
            this.buttonAfiseaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAfiseaza.Name = "buttonAfiseaza";
            this.buttonAfiseaza.UseVisualStyleBackColor = false;
            this.buttonAfiseaza.Click += new System.EventHandler(this.buttonAfiseaza_Click);
            // 
            // buttonAdauga
            // 
            resources.ApplyResources(this.buttonAdauga, "buttonAdauga");
            this.buttonAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // labelTipSuma
            // 
            resources.ApplyResources(this.labelTipSuma, "labelTipSuma");
            this.labelTipSuma.Name = "labelTipSuma";
            // 
            // radioButtonCheltuieli
            // 
            resources.ApplyResources(this.radioButtonCheltuieli, "radioButtonCheltuieli");
            this.radioButtonCheltuieli.Name = "radioButtonCheltuieli";
            this.radioButtonCheltuieli.TabStop = true;
            this.radioButtonCheltuieli.UseVisualStyleBackColor = true;
            this.radioButtonCheltuieli.CheckedChanged += new System.EventHandler(this.radioButtonCheltuieli_CheckedChanged);
            // 
            // radioButtonVenit
            // 
            resources.ApplyResources(this.radioButtonVenit, "radioButtonVenit");
            this.radioButtonVenit.Name = "radioButtonVenit";
            this.radioButtonVenit.TabStop = true;
            this.radioButtonVenit.UseVisualStyleBackColor = true;
            this.radioButtonVenit.CheckedChanged += new System.EventHandler(this.radioButtonVenit_CheckedChanged);
            // 
            // textBoxDetalii
            // 
            resources.ApplyResources(this.textBoxDetalii, "textBoxDetalii");
            this.textBoxDetalii.Name = "textBoxDetalii";
            // 
            // labelDetaliiSuma
            // 
            resources.ApplyResources(this.labelDetaliiSuma, "labelDetaliiSuma");
            this.labelDetaliiSuma.Name = "labelDetaliiSuma";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // labelSumaIntrodusa
            // 
            resources.ApplyResources(this.labelSumaIntrodusa, "labelSumaIntrodusa");
            this.labelSumaIntrodusa.Name = "labelSumaIntrodusa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBoxSumaCont
            // 
            resources.ApplyResources(this.groupBoxSumaCont, "groupBoxSumaCont");
            this.groupBoxSumaCont.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxSumaCont.Controls.Add(this.label2);
            this.groupBoxSumaCont.Controls.Add(this.labelSumaCont);
            this.groupBoxSumaCont.Controls.Add(this.label1);
            this.groupBoxSumaCont.Name = "groupBoxSumaCont";
            this.groupBoxSumaCont.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelSumaCont
            // 
            resources.ApplyResources(this.labelSumaCont, "labelSumaCont");
            this.labelSumaCont.Name = "labelSumaCont";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.groupBoxSumaCont);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxSumaIntrodusa);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBoxSumaIntrodusa.ResumeLayout(false);
            this.groupBoxSumaIntrodusa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSumaCont.ResumeLayout(false);
            this.groupBoxSumaCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSumaIntrodusa;
        private System.Windows.Forms.Label labelSumaIntrodusa;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxDetalii;
        private System.Windows.Forms.Label labelDetaliiSuma;
        private System.Windows.Forms.RadioButton radioButtonCheltuieli;
        private System.Windows.Forms.RadioButton radioButtonVenit;
        private System.Windows.Forms.Label labelTipSuma;
        private System.Windows.Forms.Button buttonAfiseaza;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxSumaCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSumaCont;
        private System.Windows.Forms.Label label2;
    }
}

