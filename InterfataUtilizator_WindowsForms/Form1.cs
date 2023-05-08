using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cont_Utilizator;
using Nivel_Stocare_Date;
using System.Configuration;
using System.IO;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareConturi_FisierText adminConturi;

        private Label lblIdCont;
        private Label lblNumeCont;
        private Label lblSumeCont;

        private Label[] lblsIdCont;
        private Label[] lblsNumeCont;
        private Label[] lblsSumeCont;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        public Form1()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrareConturi_FisierText adminConturi = new AdministrareConturi_FisierText(caleCompletaFisier);

            Cont cont = new Cont();

            int nrConturi = 0;
            adminConturi.GetConturi(out nrConturi);

            InitializeComponent();

            this.Size = new Size(500, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Informatii conturi";

            lblIdCont = new Label();
            lblIdCont.Width = LATIME_CONTROL;
            lblIdCont.Text = "ID";
            lblIdCont.Left = DIMENSIUNE_PAS_X;
            lblIdCont.ForeColor = Color.Coral;
            this.Controls.Add(lblIdCont);

            lblNumeCont = new Label();
            lblNumeCont.Width = LATIME_CONTROL;
            lblNumeCont.Text = "Nume";
            lblNumeCont.Left = 2 * DIMENSIUNE_PAS_X;
            lblNumeCont.ForeColor = Color.Coral;
            this.Controls.Add(lblNumeCont);

            lblSumeCont = new Label();
            lblSumeCont.Width = LATIME_CONTROL;
            lblSumeCont.Text = "Sume";
            lblSumeCont.Left = 3 * DIMENSIUNE_PAS_X;
            lblSumeCont.ForeColor = Color.Coral;
            this.Controls.Add(lblSumeCont);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaConturi();
        }

        private void AfiseazaConturi()
        {
            Cont[] conturi = adminConturi.GetConturi(out int nrConturi);

            lblsNumeCont = new Label[nrConturi];
            lblsSumeCont = new Label[nrConturi];

            int i = 0;
            foreach (Cont cont in conturi)
            {
                lblsIdCont[i] = new Label();
                lblsIdCont[i].Width = LATIME_CONTROL;
                lblsIdCont[i].Text = string.Join(" ", cont.IdCont);
                lblsIdCont[i].Left =  DIMENSIUNE_PAS_X;
                lblsIdCont[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsIdCont[i]);

                lblsNumeCont[i] = new Label();
                lblsNumeCont[i].Width = LATIME_CONTROL;
                lblsNumeCont[i].Text = cont.NumeCont;
                lblsNumeCont[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsNumeCont[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNumeCont[i]);

                lblsSumeCont[i] = new Label();
                lblsSumeCont[i].Width = LATIME_CONTROL;
                lblsSumeCont[i].Text = string.Join(" ", cont.GetSume());
                lblsSumeCont[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsSumeCont[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsSumeCont[i]);
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Modificare nume cont nou
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adauga cont nou in fisier
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Afiseaza din nou conturile din fisier
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Sumele din contul nou
        }
    }
}
