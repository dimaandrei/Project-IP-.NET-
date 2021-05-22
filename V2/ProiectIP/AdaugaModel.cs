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
    public partial class AdaugaModel : Form
    {
        private OracleConnection _dbConn;
        public AdaugaModel()
        {
            _dbConn = DatabaseConnection.DatabaseConnection.GetConncetionInstance();
            InitializeComponent();
        }

        private void AdaugaModel_Load(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT nume_marca FROM producator";
                cmd.Connection = _dbConn;
                _dbConn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    List<Object> prod = new List<Object>();
                    while (dr.Read())
                    {
                        prod.Add(dr["nume_marca"].ToString());
                    }
                    object[] prodArray = prod.ConvertAll<object>(item => (object)item).ToArray();
                    comboBoxProducator.Items.Clear();
                    comboBoxProducator.Items.AddRange(prodArray);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nLipsa producatori", "Eroare - incarcare bd");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void labelBuget_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaModel_Click(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[A-Za-z0-9 -]+$")).IsMatch(textBoxNume.Text) || textBoxNume.Text.Length <= 3)
            {
                MessageBox.Show("Formatul modelului nu este potrivit!");
                return;
            }

            if (comboBoxBuget.SelectedIndex < 0)
            {
                MessageBox.Show("Tipul bugetului nu este selectat!");
                return;
            }
            if (comboBoxTipCombustibil.SelectedIndex < 0)
            {
                MessageBox.Show("Tipul combustibilului nu este selectat!");
                return;
            }
            if (numericUpDownCaiPutere.Value < 50 || numericUpDownCaiPutere.Value > 750)
            {
                MessageBox.Show("Numarul de cai putere trebuie sa fie intre 50 si 750!");
                return;
            }
            if (comboBoxTransmisie.SelectedIndex < 0)
            {
                MessageBox.Show("Tipul de transmisie nu este selectat!");
                return;
            }
            if (comboBoxInterior.SelectedIndex < 0)
            {
                MessageBox.Show("Tipul de interior nu este selectat!");
                return;
            }

            try
            {
                _dbConn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT id_producator FROM producator WHERE nume_marca='" + comboBoxProducator.Text + "'";
                cmd.Connection = _dbConn;
                OracleDataReader dr = cmd.ExecuteReader();
                int producator = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        producator = Int32.Parse(dr["id_producator"].ToString());
                    }
                }
                string sql = "INSERT INTO model_masina (model, tip_buget, tip_combustibil, cai_putere, transmisie, interior, id_producator) VALUES ('" + textBoxNume.Text + "','" + comboBoxBuget.Text + "','" + comboBoxTipCombustibil.Text + "'," + numericUpDownCaiPutere.Value + ",'" + comboBoxTransmisie.Text + "','" + comboBoxInterior.Text + "'," + producator + ")";
                cmd = new OracleCommand(sql, _dbConn);
                cmd.BindByName = true;

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Modelul nu poate fi introdus in baza de date!", "Eroare - introducere model");
            }
            finally
            {
                _dbConn.Close();
                
            }

        }
    }
}

