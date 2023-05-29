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
        private Label lblTipCont;
        private Label lblContPt;

        private Label[] lblsIdCont;
        private Label[] lblsNumeCont;
        private Label[] lblsSumeCont;
        private Label[] lblsTipCont;
        private Label[] lblsContPt;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 10;
        private const int DIMENSIUNE_PAS_X = 220;
        private const int OFFSET_X = 600;
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

            //this.Size = new Size(1920, 1080);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Font = new Font("Arial", 12, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informatii conturi";

            lblIdCont = new Label();
            lblIdCont.Width = LATIME_CONTROL;
            lblIdCont.Text = "ID";
            lblIdCont.Top = DIMENSIUNE_PAS_Y;
            lblIdCont.Left = DIMENSIUNE_PAS_X;
            lblIdCont.ForeColor = Color.Black;
            this.Controls.Add(lblIdCont);

            lblNumeCont = new Label();
            lblNumeCont.Width = LATIME_CONTROL;
            lblNumeCont.Text = "Nume";
            lblNumeCont.Top = DIMENSIUNE_PAS_Y;
            lblNumeCont.Left = 2 * DIMENSIUNE_PAS_X;
            lblNumeCont.ForeColor = Color.Black;
            this.Controls.Add(lblNumeCont);

            lblSumeCont = new Label();
            lblSumeCont.Width = LATIME_CONTROL;
            lblSumeCont.Text = "Sume";
            lblSumeCont.Top = DIMENSIUNE_PAS_Y;
            lblSumeCont.Left = 3 * DIMENSIUNE_PAS_X;
            lblSumeCont.ForeColor = Color.Black;
            this.Controls.Add(lblSumeCont);

            lblTipCont = new Label();
            lblTipCont.Width = LATIME_CONTROL;
            lblTipCont.Text = "Tip Cont";
            lblTipCont.Top = DIMENSIUNE_PAS_Y;
            lblTipCont.Left = 4 * DIMENSIUNE_PAS_X;
            lblTipCont.ForeColor = Color.Black;
            this.Controls.Add(lblTipCont);

            lblContPt = new Label();
            lblContPt.Width = LATIME_CONTROL;
            lblContPt.Text = "Pentru";
            lblContPt.Top = DIMENSIUNE_PAS_Y;
            lblContPt.Left = 5 * DIMENSIUNE_PAS_X;
            lblContPt.ForeColor = Color.Black;
            this.Controls.Add(lblContPt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaConturi();
        }

        private void AfiseazaConturi()
        {
            Cont[] conturi = adminConturi.GetConturi(out int nrConturi);

            lblIdCont = new Label();
            lblIdCont.Width = LATIME_CONTROL;
            lblIdCont.Text = "ID";
            lblIdCont.Top = DIMENSIUNE_PAS_Y;
            lblIdCont.Left = OFFSET_X + 0;
            lblIdCont.ForeColor = Color.Black;
            this.Controls.Add(lblIdCont);

            lblNumeCont = new Label();
            lblNumeCont.Width = LATIME_CONTROL;
            lblNumeCont.Text = "Nume";
            lblNumeCont.Top = DIMENSIUNE_PAS_Y;
            lblNumeCont.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblNumeCont.ForeColor = Color.Black;
            this.Controls.Add(lblNumeCont);

            lblSumeCont = new Label();
            lblSumeCont.Width = LATIME_CONTROL;
            lblSumeCont.Text = "Sume";
            lblSumeCont.Top = DIMENSIUNE_PAS_Y;
            lblSumeCont.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblSumeCont.ForeColor = Color.Black;
            this.Controls.Add(lblSumeCont);

            lblTipCont = new Label();
            lblTipCont.Width = LATIME_CONTROL;
            lblTipCont.Text = "Tip Cont";
            lblTipCont.Top = DIMENSIUNE_PAS_Y;
            lblTipCont.Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
            lblTipCont.ForeColor = Color.Black;
            this.Controls.Add(lblTipCont);

            lblContPt = new Label();
            lblContPt.Width = LATIME_CONTROL;
            lblContPt.Text = "Pentru";
            lblContPt.Top = DIMENSIUNE_PAS_Y;
            lblContPt.Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
            lblContPt.ForeColor = Color.Black;
            this.Controls.Add(lblContPt);

            lblsIdCont = new Label[nrConturi];
            lblsNumeCont = new Label[nrConturi];
            lblsSumeCont = new Label[nrConturi];
            lblsTipCont = new Label[nrConturi];
            lblsContPt = new Label[nrConturi];

            int i = 0;
            foreach (Cont cont in conturi)
            {
                /*
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

                lblsTipCont[i] = new Label();
                lblsTipCont[i].Width = LATIME_CONTROL;
                lblsTipCont[i].Text = string.Join(" ", cont.GetSume());
                lblsTipCont[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsTipCont[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsTipCont[i]);

                lblsContPt[i] = new Label();
                lblsContPt[i].Width = LATIME_CONTROL;
                lblsContPt[i].Text = string.Join(" ", cont.GetSume());
                lblsContPt[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsContPt[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsContPt[i]);
                */
                i++;
            }
        }
    }
}
