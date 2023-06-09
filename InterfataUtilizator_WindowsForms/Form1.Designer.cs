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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxSumaIntrodusa = new System.Windows.Forms.GroupBox();
            this.labelSumaIntrodusa = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelDetaliiSuma = new System.Windows.Forms.Label();
            this.textBoxDetalii = new System.Windows.Forms.TextBox();
            this.radioButtonVenit = new System.Windows.Forms.RadioButton();
            this.radioButtonCheltuieli = new System.Windows.Forms.RadioButton();
            this.labelNaturaSuma = new System.Windows.Forms.Label();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonAfiseaza = new System.Windows.Forms.Button();
            this.buttonEditeaza = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idSumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaContDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaIntrodusaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSumaIntrodusa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSumaIntrodusa
            // 
            this.groupBoxSumaIntrodusa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxSumaIntrodusa.Controls.Add(this.buttonSterge);
            this.groupBoxSumaIntrodusa.Controls.Add(this.buttonEditeaza);
            this.groupBoxSumaIntrodusa.Controls.Add(this.buttonAfiseaza);
            this.groupBoxSumaIntrodusa.Controls.Add(this.buttonAdauga);
            this.groupBoxSumaIntrodusa.Controls.Add(this.labelNaturaSuma);
            this.groupBoxSumaIntrodusa.Controls.Add(this.radioButtonCheltuieli);
            this.groupBoxSumaIntrodusa.Controls.Add(this.radioButtonVenit);
            this.groupBoxSumaIntrodusa.Controls.Add(this.textBoxDetalii);
            this.groupBoxSumaIntrodusa.Controls.Add(this.labelDetaliiSuma);
            this.groupBoxSumaIntrodusa.Controls.Add(this.numericUpDown1);
            this.groupBoxSumaIntrodusa.Controls.Add(this.labelSumaIntrodusa);
            resources.ApplyResources(this.groupBoxSumaIntrodusa, "groupBoxSumaIntrodusa");
            this.groupBoxSumaIntrodusa.Name = "groupBoxSumaIntrodusa";
            this.groupBoxSumaIntrodusa.TabStop = false;
            // 
            // labelSumaIntrodusa
            // 
            resources.ApplyResources(this.labelSumaIntrodusa, "labelSumaIntrodusa");
            this.labelSumaIntrodusa.Name = "labelSumaIntrodusa";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // labelDetaliiSuma
            // 
            resources.ApplyResources(this.labelDetaliiSuma, "labelDetaliiSuma");
            this.labelDetaliiSuma.Name = "labelDetaliiSuma";
            // 
            // textBoxDetalii
            // 
            resources.ApplyResources(this.textBoxDetalii, "textBoxDetalii");
            this.textBoxDetalii.Name = "textBoxDetalii";
            // 
            // radioButtonVenit
            // 
            resources.ApplyResources(this.radioButtonVenit, "radioButtonVenit");
            this.radioButtonVenit.Name = "radioButtonVenit";
            this.radioButtonVenit.TabStop = true;
            this.radioButtonVenit.UseVisualStyleBackColor = true;
            this.radioButtonVenit.CheckedChanged += new System.EventHandler(this.radioButtonVenit_CheckedChanged);
            // 
            // radioButtonCheltuieli
            // 
            resources.ApplyResources(this.radioButtonCheltuieli, "radioButtonCheltuieli");
            this.radioButtonCheltuieli.Name = "radioButtonCheltuieli";
            this.radioButtonCheltuieli.TabStop = true;
            this.radioButtonCheltuieli.UseVisualStyleBackColor = true;
            this.radioButtonCheltuieli.CheckedChanged += new System.EventHandler(this.radioButtonCheltuieli_CheckedChanged);
            // 
            // labelNaturaSuma
            // 
            resources.ApplyResources(this.labelNaturaSuma, "labelNaturaSuma");
            this.labelNaturaSuma.Name = "labelNaturaSuma";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.buttonAdauga, "buttonAdauga");
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonAfiseaza
            // 
            this.buttonAfiseaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.buttonAfiseaza, "buttonAfiseaza");
            this.buttonAfiseaza.Name = "buttonAfiseaza";
            this.buttonAfiseaza.UseVisualStyleBackColor = false;
            this.buttonAfiseaza.Click += new System.EventHandler(this.buttonAfiseaza_Click);
            // 
            // buttonEditeaza
            // 
            this.buttonEditeaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.buttonEditeaza, "buttonEditeaza");
            this.buttonEditeaza.Name = "buttonEditeaza";
            this.buttonEditeaza.UseVisualStyleBackColor = false;
            this.buttonEditeaza.Click += new System.EventHandler(this.buttonEditeaza_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.buttonSterge, "buttonSterge");
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSumaDataGridViewTextBoxColumn,
            this.sumaContDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.sumaIntrodusaDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contBindingSource
            // 
            this.contBindingSource.DataSource = typeof(Cont_Utilizator.Cont);
            // 
            // idSumaDataGridViewTextBoxColumn
            // 
            this.idSumaDataGridViewTextBoxColumn.DataPropertyName = "IdSuma";
            resources.ApplyResources(this.idSumaDataGridViewTextBoxColumn, "idSumaDataGridViewTextBoxColumn");
            this.idSumaDataGridViewTextBoxColumn.Name = "idSumaDataGridViewTextBoxColumn";
            // 
            // sumaContDataGridViewTextBoxColumn
            // 
            this.sumaContDataGridViewTextBoxColumn.DataPropertyName = "SumaCont";
            resources.ApplyResources(this.sumaContDataGridViewTextBoxColumn, "sumaContDataGridViewTextBoxColumn");
            this.sumaContDataGridViewTextBoxColumn.Name = "sumaContDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            resources.ApplyResources(this.tipDataGridViewTextBoxColumn, "tipDataGridViewTextBoxColumn");
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // sumaIntrodusaDataGridViewTextBoxColumn
            // 
            this.sumaIntrodusaDataGridViewTextBoxColumn.DataPropertyName = "SumaIntrodusa";
            resources.ApplyResources(this.sumaIntrodusaDataGridViewTextBoxColumn, "sumaIntrodusaDataGridViewTextBoxColumn");
            this.sumaIntrodusaDataGridViewTextBoxColumn.Name = "sumaIntrodusaDataGridViewTextBoxColumn";
            // 
            // detaliiDataGridViewTextBoxColumn
            // 
            this.detaliiDataGridViewTextBoxColumn.DataPropertyName = "Detalii";
            resources.ApplyResources(this.detaliiDataGridViewTextBoxColumn, "detaliiDataGridViewTextBoxColumn");
            this.detaliiDataGridViewTextBoxColumn.Name = "detaliiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxSumaIntrodusa);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBoxSumaIntrodusa.ResumeLayout(false);
            this.groupBoxSumaIntrodusa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contBindingSource)).EndInit();
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
        private System.Windows.Forms.Label labelNaturaSuma;
        private System.Windows.Forms.Button buttonAfiseaza;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonEditeaza;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaContDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaIntrodusaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contBindingSource;
    }
}

