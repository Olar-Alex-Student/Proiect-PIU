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

        AdministrareTranzactie_FisierText admin = new AdministrareTranzactie_FisierText(caleCompletaFisier);
        
        Cont cont = new Cont();

        List<Tranzactie> tranzactii = new List<Tranzactie>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            tranzactii = admin.GetTranzactii();
        }

        private void buttonAfiseaza_Click(object sender, EventArgs e)
        {
            SetSuma(tranzactii, cont);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tranzactii;

            labelSumaCont.Text = cont.Suma.ToString();

            radioButtonCheltuieli.Checked = false;
            radioButtonVenit.Checked = false;
            numericUpDown1.Value = 0;
            textBoxDetalii.Text = string.Empty;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Tranzactie tranzactie = new Tranzactie();
            tranzactie.Id = admin.GetId();
            if ((tranzactie.ValideazaSuma((int)numericUpDown1.Value) == true) && (ValideazaTip() == true))
            {
                tranzactie.SumaIntrodusa = (int)numericUpDown1.Value;

                tranzactie.TipTranzactie = GetTip();

                tranzactie.Detalii = Detalii();

                tranzactii.Add(tranzactie);

                admin.AddTranzactie(tranzactie);
            }
            if((tranzactie.ValideazaSuma((int)numericUpDown1.Value) == false) || (ValideazaTip() == false))
            {
                MessageBox.Show("Date Invalide!");

                radioButtonCheltuieli.Checked = false;
                radioButtonVenit.Checked = false;
                numericUpDown1.Value = 0;
                textBoxDetalii.Text = string.Empty;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonVenit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCheltuieli_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool ValideazaTip()
        {
            if (radioButtonCheltuieli.Checked)
            {
                return true;
            }
            if (radioButtonVenit.Checked)
            {
                return true;
            }

            return false;
        }

        private string GetTip()
        {
            if(radioButtonCheltuieli.Checked)
            {
                return radioButtonCheltuieli.Text;
            }
            if(radioButtonVenit.Checked)
            {
                return radioButtonVenit.Text;
            }

            return radioButtonVenit.Text;
        }

        private string Detalii()
        {
            if(textBoxDetalii.Text != string.Empty)
            {
                return textBoxDetalii.Text;
            }

            return (string)"Necunoscut";
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBoxSumaIntrodusa_Enter(object sender, EventArgs e)
        {

        }

        private void SetSuma(List<Tranzactie> tranzactii, Cont cont)
        {
            cont.Suma = 0;
            foreach(Tranzactie tranzactie in tranzactii)
            {
                if(tranzactie.TipTranzactie == "Venit")
                {
                    cont.Venit(tranzactie.SumaIntrodusa);
                }
                if (tranzactie.TipTranzactie == "Cheltuieli")
                {
                    cont.Cheltuiala(tranzactie.SumaIntrodusa);
                }
            }
        }
    }
}
