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
using System.Collections;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        public static string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
        public static string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        
        public static string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

        AdministrareCont_FisierText adminModificari = new AdministrareCont_FisierText(caleCompletaFisier);
        
        List<Cont> modificari;
        Cont cont = new Cont();

        public int Id = 0;

        public Form1()
        {
            InitializeComponent();
            modificari = adminModificari.GetGestiune();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modificari;
        }

        private void buttonAfiseaza_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = modificari;

            numericUpDown1.Value = 0;
            textBoxDetalii.Text = string.Empty;
            radioButtonCheltuieli.Checked = false;
            radioButtonVenit.Checked= false;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (cont.ValideazaSuma(Convert.ToInt32(numericUpDown1.Value)) == true)
            {
                cont.SumaIntrodusa = Convert.ToInt32(numericUpDown1.Value);
                cont.Detalii = textBoxDetalii.Text;
                radioButtonCheltuieli_CheckedChanged(sender, new EventArgs());
                radioButtonVenit_CheckedChanged(sender, new EventArgs());
            }
            modificari.Add(cont);
        }

        private void buttonEditeaza_Click(object sender, EventArgs e)
        {

        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonVenit_CheckedChanged(object sender, EventArgs e)
        {
            cont.SumaCont += cont.SumaIntrodusa;
        }

        private void radioButtonCheltuieli_CheckedChanged(object sender, EventArgs e)
        {
            cont.SumaCont -= cont.SumaIntrodusa;
        }
    }
}
