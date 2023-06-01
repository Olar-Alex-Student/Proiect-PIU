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
        IStocareData adminModificari;

        private Label lblHeaderSumaCont;
        private Label lblHeaderTip;
        private Label lblHeaderSumaIntrodusa;

        private Label[] lblsSumaCont;
        private Label[] lblsTip;
        private Label[] lblsSumaIntrodusa;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;

        //ArrayList disciplineSelectate = new ArrayList();

        public Form1()
        {

            //adminStudenti = StocareFactory.GetAdministratorStocare();

            InitializeComponent();

            //setare proprietati
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informatii Cont";

            List<Cont> modificari = adminModificari.GetGestiune();

            AfiseazaModificari(modificari);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Cont> modificari = adminModificari.GetGestiune();

            AfiseazaModificari(modificari);
        }

        private void AfiseazaModificari(List<Cont> modificari)
        {
            //adaugare control de tip Label pentru 'Nume';
            lblHeaderSumaCont = new Label();
            lblHeaderSumaCont.Width = LATIME_CONTROL;
            lblHeaderSumaCont.Text = "Suma Cont";
            lblHeaderSumaCont.Left = OFFSET_X + 0;
            lblHeaderSumaCont.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderSumaCont);

            //adaugare control de tip Label pentru 'Prenume';
            lblHeaderTip = new Label();
            lblHeaderTip.Width = LATIME_CONTROL;
            lblHeaderTip.Text = "Tip";
            lblHeaderTip.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderTip.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderTip);

            //adaugare control de tip Label pentru 'Note';
            lblHeaderSumaIntrodusa = new Label();
            lblHeaderSumaIntrodusa.Width = LATIME_CONTROL;
            lblHeaderSumaIntrodusa.Text = "Suma Introdusa";
            lblHeaderSumaIntrodusa.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderSumaIntrodusa.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderSumaIntrodusa);

            int nrModificari = modificari.Count;
            lblsSumaCont = new Label[nrModificari];
            lblsTip = new Label[nrModificari];
            lblsSumaIntrodusa = new Label[nrModificari];

            int i = 0;
            foreach (Cont cont in modificari)
            {
                //adaugare control de tip Label pentru numele studentilor;
                lblsSumaCont[i] = new Label();
                lblsSumaCont[i].Width = LATIME_CONTROL;
                lblsSumaCont[i].Text = cont.SumaCont.ToString();
                lblsSumaCont[i].Left = OFFSET_X + 0;
                lblsSumaCont[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsSumaCont[i]);

                //adaugare control de tip Label pentru prenumele studentilor
                lblsTip[i] = new Label();
                lblsTip[i].Width = LATIME_CONTROL;
                lblsTip[i].Text = cont.Tip.ToString();
                lblsTip[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsTip[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsTip[i]);

                //adaugare control de tip Label pentru notele studentilor
                lblsSumaIntrodusa[i] = new Label();
                lblsSumaIntrodusa[i].Width = LATIME_CONTROL;
                lblsSumaIntrodusa[i].Text = string.Join(" ", cont.SumaIntrodusa.ToString());
                lblsSumaIntrodusa[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsSumaIntrodusa[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsSumaIntrodusa[i]);
                i++;
            }
        }
        /*
        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblDiscipline.ForeColor = Color.Red;
                lblNote.ForeColor = Color.Red;

                return;
            }

            Student s = new Student(0, txtNume.Text, txtPrenume.Text);
            s.SetNote(txtNote.Text);

            //set program studiu
            //verificare radioButton selectat
            ProgramStudiu specializareSelectata = GetProgramStudiuSelectat();
            s.Specializare = specializareSelectata;

            //set Discipline
            s.Discipline = new ArrayList();
            s.Discipline.AddRange(disciplineSelectate);

            adminStudenti.AddStudent(s);
            lblMesaj.Text = "Studentul a fost adaugat";

            //resetarea controalelor pentru a introduce datele unui student nou
            ResetareControale();
        }

        private bool DateIntrareValide()
        {
            string[] note = txtNote.Text.Split(' ');
            if (disciplineSelectate.Count != note.Length)
            {
                return false;
            }

            return true;
        }

        private void CkbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string disciplinaSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                disciplineSelectate.Add(disciplinaSelectata);
            else
                disciplineSelectate.Remove(disciplinaSelectata);
        }

        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtNote.Text = string.Empty;

            rdbCalculatoare.Checked = false;
            rdbAutomatica.Checked = false;
            rdbElectronica.Checked = false;

            ckbPCLP.Checked = false;
            ckbPOO.Checked = false;
            ckbPIU.Checked = false;

            disciplineSelectate.Clear();
            lblMesaj.Text = string.Empty;
        }

        private ProgramStudiu GetProgramStudiuSelectat()
        {
            if (rdbCalculatoare.Checked)
                return ProgramStudiu.Calculatoare;
            if (rdbAutomatica.Checked)
                return ProgramStudiu.Automatica;
            if (rdbElectronica.Checked)
                return ProgramStudiu.Electronica;

            return ProgramStudiu.Calculatoare;
        }
        

        private void BtnAfiseaza_Click(object sender, EventArgs e)
        {
            List<Cont> modificari = adminModificari.GetGestiune();
            AfiseazaModificari(modificari);
            AfisareStudentiInControlListbox(modificari);
            AfisareStudentiInControlDataGridView(modificari);
        }

        private void AfisareStudentiInControlListbox(List<Cont> modificari)
        {
            lstAfisare.Items.Clear();
            foreach (Cont cont in modificari)
            {
                //pentru a adauga un obiect de tip Student in colectia de Items a unui control de tip ListBox, 
                // clasa Student trebuie sa implementeze metoda ToString() specificand cuvantul cheie 'override' in definitie
                //pentru a arata ca metoda ToString a clasei de baza (Object) este suprascrisa
                lstAfisare.Items.Add(cont);

                //personalizare sursa de date
                //lstAfisare.Items.Add(s.NumeComplet);
            }
        }

        private void AfisareStudentiInControlDataGridView(List<Cont> modificari)
        {
            //reset continut control DataGridView
            dataGridModificari.DataSource = null;

            //!!!! Controlul de tip DataGridView are ca sursa de date lista de obiecte de tip Student !!!
            dataGridModificari.DataSource = modificari;

            // personalizare sursa de date
            // dataGridStudenti.DataSource = studenti.Select(s => new { s.Id, s.Nume, s.Prenume, 
            // s.Specializare, Discipline = string.Join(",", s.Discipline), 
            // Note = string.Join(",", s.GetNote()) } ).ToList();
        }
        */
    }
}
