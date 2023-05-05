using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nivel_Stocare_Date;
using System.Configuration;
using Cont_Utilizator;
using System.IO;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareConturi_FisierText adminConturi;

        private Label lblId;
        private Label lblNume;
        private Label lblSuma;

        private Label[] lblsId;
        private Label[] lblsNume;
        private Label[] lblsSuma;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        public Form1()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminConturi = new AdministrareConturi_FisierText(caleCompletaFisier);

            InitializeComponent();

            this.Size = new Size(500, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Informatii Conturi";

            lblId = new Label();
            lblId.Width = LATIME_CONTROL;
            lblId.Text = "ID";
            lblId.Left = DIMENSIUNE_PAS_X;
            lblId.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblId);

            lblSuma = new Label();
            lblSuma.Width = LATIME_CONTROL;
            lblSuma.Text = "Sume";
            lblSuma.Left = 2 * DIMENSIUNE_PAS_X;
            lblSuma.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblSuma);

            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Left = 3 * DIMENSIUNE_PAS_X;
            lblNume.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblNume);


            button1.Text = "Adauga";
            button1.ForeColor = Color.DarkGreen;

            button2.Text = "Refresh";
            button2.ForeColor = Color.DarkGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaConturi();
        }

        private void AfiseazaConturi()
        {
            Cont[] conturi = adminConturi.GetConturi(out int nrConturi);

            lblsNume = new Label[nrConturi];
            lblsSuma = new Label[nrConturi];

            int i = 0;
            foreach (Cont cont in conturi)
            {
                lblsId[i] = new Label();
                lblsId[i].Width = LATIME_CONTROL;
                lblsId[i].Text = cont.NumeCont;
                lblsId[i].Left = DIMENSIUNE_PAS_X;
                lblsId[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsId[i]);

                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = cont.NumeCont;
                lblsNume[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                lblsSuma[i] = new Label();
                lblsSuma[i].Width = LATIME_CONTROL;
                lblsSuma[i].Text = string.Join(" ", cont.GetSume());
                lblsSuma[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsSuma[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsSuma[i]);
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
