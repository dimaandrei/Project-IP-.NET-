using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    public partial class Interfata : Form
    {
        private Form _vanzare = new Vanzare();
        private Form _istoric = new Istoric();
        private Form _modele = new Modele();

        public Interfata()
        {
            
            InitializeComponent();
            this.buttonIstoricVanzari.Visible = false;
            this.buttonSell.Visible = false;
            this.buttonModels.Visible = false;
            this.textBoxPass.PasswordChar = '*';
        }

        private void buttonLog_Click_1(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "test" && textBoxPass.Text == "test")
            {

                buttonLog.Visible = false;
                labelPass.Visible = false;
                labelUser.Visible = false;
                textBoxPass.Visible = false;
                textBoxUser.Visible = false;
                buttonIstoricVanzari.Visible = true;
                this.buttonSell.Visible = true;
                this.buttonModels.Visible = true;
                //OracleConnection conn = new OracleConnection(@"Data Source=localhost;User ID=andreidima;Password=********");
                // conn.Open();
                //MessageBox.Show("Connected to Oracle" + conn.ServerVersion);
                //DataTable dtbl = new DataTable();
                //OracleDataAdapter orcl = new OracleDataAdapter("", conn);
                //orcl.Fill(dtbl);
            }
            else
            {
                MessageBox.Show("User sau parola incorecta!", "Eroare!");
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            _vanzare.ShowDialog(this);
        }

       
        private void buttonIstoricVanzari_Click(object sender, EventArgs e)
        {
            _istoric.ShowDialog(this);
        }

        private void Interfata_Load(object sender, EventArgs e)
        {

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonModels_Click(object sender, EventArgs e)
        {
            _modele.ShowDialog(this);
        }
    }
}

