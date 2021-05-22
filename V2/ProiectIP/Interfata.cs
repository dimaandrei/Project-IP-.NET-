using DatabaseConnection;
using Oracle.ManagedDataAccess.Client;
using ProxyInterfaceManager;
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
        private Form _vanzare ;
        private Form _istoric;
        private Form _modele ;
        private ProxyInterfaceManager.ProxyInterfaceManager _proxyInterfaceManager;
        private OracleConnection _dbConn;

        public Interfata()
        {
            _proxyInterfaceManager = ProxyInterfaceManager.ProxyInterfaceManager.GetInstance();
            InitializeComponent();
            buttonSwitchAccount.Visible = false;
            this.buttonIstoricVanzari.Visible = false;
            this.buttonSell.Visible = false;
            this.buttonModels.Visible = false;
            this.textBoxPass.PasswordChar = '*';
        }

        private void buttonLog_Click_1(object sender, EventArgs e)
        {
            if (_proxyInterfaceManager.Login(this.textBoxUser.Text, this.textBoxPass.Text))
            {
                _vanzare = new Vanzare(_proxyInterfaceManager.CurrentAccessLevel);
                _istoric = new Istoric();
                _modele = new Modele();
                buttonLog.Visible = false;
                labelPass.Visible = false;
                labelUser.Visible = false;
                textBoxPass.Visible = false;
                textBoxPass.Clear();
                textBoxUser.Visible = false;
                textBoxUser.Clear();
                buttonIstoricVanzari.Visible = true;
                buttonSwitchAccount.Visible = true;
                this.buttonSell.Visible = true;
                this.buttonModels.Visible = true;
                try
                {
                    _dbConn = DatabaseConnection.DatabaseConnection.GetConncetionInstance();
                    _dbConn.Open();
                    _dbConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nAplicatia nu s-a putut conecta la baza de date!", "Eroare-conectare BD");
                    Application.Exit();
                }
                // conn.Open();
                //DataTable dtbl = new DataTable();
                //OracleDataAdapter orcl = new OracleDataAdapter("", conn);
                //orcl.Fill(dtbl);
            }
            else
            {
                MessageBox.Show("User sau parola incorecta!", "Eroare-logare");
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP - AutoSell\n(c)\tMelinte Alexandru-Gicu\n\tDima Raul Andrei\n\tTizu Matei-Victor\n\tChiper Alexandru-Ioan\nAn universitar 2020-2021", "Despre echipa AutoSell");
        }

        private void buttonSwitchAccount_Click(object sender, EventArgs e)
        {
            buttonSwitchAccount.Visible = false;
            textBoxUser.Visible = true;
            textBoxPass.Visible = true;
            labelPass.Visible = true;
            labelUser.Visible = true;
            buttonIstoricVanzari.Visible = false;
            buttonModels.Visible = false;
            buttonSell.Visible = false;
            buttonLog.Visible = true;
        }
    }
}

