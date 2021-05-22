using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProiectIP
{
    public partial class AdaugaProducator : Form
    {
        private OracleConnection _dbConn;

        public AdaugaProducator()
        {
            _dbConn = DatabaseConnection.DatabaseConnection.GetConncetionInstance();
            InitializeComponent();
        }

        private void buttonAdaugaProducator_Click(object sender, EventArgs e)
        {
            if(!(new Regex(@"^[A-Za-z0-9 ]+$")).IsMatch(textBoxNume.Text) || textBoxNume.Text.Length <= 2)
            {
                MessageBox.Show("Formatul numelui de marca nu este potrivit!");
                return;
            }
            
            if(!(new Regex(@"^[A-Za-z ]+$")).IsMatch(textBoxOrigine.Text) || textBoxOrigine.Text.Length <= 2)
            {
                MessageBox.Show("Formatul tarii de origine nu este potrivit!");
                return;
            }

            if (!(new Regex(@"^[A-Za-z0-9 ]+$")).IsMatch(textBoxGrupAuto.Text) || textBoxGrupAuto.Text.Length <= 2)
            {
                MessageBox.Show("Formatul grupului auto nu este potrivit!");
                return;
            }

            if (!(new Regex(@"[a-z0-9._%-]+@[a-z0-9._%-]+\.[a-z]{2,4}")).IsMatch(textBoxMail.Text) || textBoxMail.Text == "")
            {
                MessageBox.Show("Formatul adresei de mail nu este potrivit!");
                return;
            }

            if (!(new Regex(@"[0-9]+$")).IsMatch(textBoxTelefon.Text) || textBoxTelefon.Text.Length != 10)
            {
                MessageBox.Show("Formatul numarului de telefon nu este potrivit!");
                return;
            }

            try
            {
                _dbConn.Open();
                string sql = "INSERT INTO producator (nume_marca, tara, grup_auto, numar_telefon, adresa_mail) VALUES ('" + textBoxNume.Text + "', '" + textBoxOrigine.Text + "', '" + textBoxGrupAuto.Text + "', '" + textBoxTelefon.Text + "','" + textBoxMail.Text + "')";
                OracleCommand cmd = new OracleCommand(sql, _dbConn);
                cmd.BindByName = true;

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nProducatorul nu a putut fi introdus in baza de date!", "Eroare - introducere producator");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

