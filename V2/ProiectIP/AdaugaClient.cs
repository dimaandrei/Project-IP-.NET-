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
    public partial class AdaugaClient : Form
    {
        private OracleConnection _dbConn;
        public AdaugaClient()
        {
            _dbConn = DatabaseConnection.DatabaseConnection.GetConncetionInstance();
            InitializeComponent();
        }

        private void buttonAdaugaClient_Click(object sender, EventArgs e)
        {
            if(!(new Regex(@"^[A-Za-z ]+$")).IsMatch(textBoxNume.Text) || textBoxNume.Text.Length <= 4)
            {
                MessageBox.Show("Formatul numelui clientului nu este potrivit!");
                return;
            }

            if (!(new Regex(@"[a-z0-9._%-]+@[a-z0-9._%-]+\.[a-z]{2,4}")).IsMatch(textBoxMail.Text) || textBoxMail.Text.Length < 1)
            {
                MessageBox.Show("Formatul adresei de mail nu este potrivit!");
                return;
            }

            if(comboBoxTipPlata.SelectedIndex < 0)
            {
                MessageBox.Show("Tipul de plata nu este selectat!");
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
                string sql = "INSERT INTO client (nume_client, numar_telefon_client, tip_plata, adresa_mail_client) VALUES ('" + textBoxNume.Text + "', '" + textBoxTelefon.Text + "', '" + comboBoxTipPlata.Text + "', '" + textBoxMail.Text + "')";
                OracleCommand cmd = new OracleCommand(sql, _dbConn);
                cmd.BindByName = true;
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nClientul nu a putut fi introdus in baza de date!", "Eroare - introducere client!");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
