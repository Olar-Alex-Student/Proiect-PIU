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
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string NumeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie =
            Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + NumeFisier;
            AdministrareVenit_FisierText adminConturi = new
            AdministrareVenit_FisierText(caleCompletaFisier);
            int nrConturi = 0;
            Cont[] conturi = adminConturi.GetConturi(out nrConturi);
            //lblNume.Text = conturi[nrConturi].NumeCont;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
