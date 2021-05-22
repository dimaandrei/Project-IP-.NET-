using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProiectIP
{
    public partial class Vanzare : Form
    {
        private Form _adaugaClient, _adaugaProducator, _adaugaModel;
        private OracleConnection _dbConn;
        private int _accessLevel;
        public Vanzare(int accessLevel)
        {
            _accessLevel = accessLevel;
            _dbConn = DatabaseConnection.DatabaseConnection.GetConncetionInstance();
            InitializeComponent();
            if (_accessLevel == -1)
            {
                this.buttonAddClient.Enabled = false;
                this.comboBoxClient.Enabled = false;
                this.comboBoxModel.Enabled = false;
                this.comboBoxProducator.Enabled = false;
                this.radioButtonPersoanaFizica.Enabled = false;
                this.radioButtonPersoanaJuridica.Enabled = false;
                this.textBoxSasiu.Enabled = false;
                this.numericUpDownCost.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.buttonGenFactura.Enabled = false;
            }
            else if (_accessLevel == 0)
            {
                this.buttonAddProducator.Enabled = false;
                this.buttonAddModel.Enabled = false;
            }
        }

        private void callbackUpdateComboBoxClient(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(); ;
                OracleDataReader dr;
                cmd.CommandText = "SELECT nume_client FROM client";
                cmd.Connection = _dbConn;
                _dbConn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    List<Object> prod = new List<Object>();
                    while (dr.Read())
                    {
                        prod.Add(dr["nume_client"].ToString());
                    }
                    object[] prodArray = prod.ConvertAll<object>(item => (object)item).ToArray();
                    comboBoxClient.Items.Clear();
                    comboBoxClient.Items.AddRange(prodArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInterfata nu a putut fi incarcata. Clientii nu au putut fi incarcati.", "Eroare-incarcare clienti");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void callbackUpdateComboBoxProducator(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(); ;
                OracleDataReader dr;
                cmd.CommandText = "SELECT nume_marca FROM producator";
                cmd.Connection = _dbConn;
                _dbConn.Open();
                dr = cmd.ExecuteReader();
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
                MessageBox.Show(ex.Message + "\nInterfata nu a putut fi incarcata. Marcile auto nu au putut fi incarcate.", "Eroare-incarcare marca auto");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            _adaugaClient = new AdaugaClient();
            _adaugaClient.FormClosed += callbackUpdateComboBoxClient;
            _adaugaClient.ShowDialog(this);
        }

        private void buttonAddProducator_Click(object sender, EventArgs e)
        {
            _adaugaProducator = new AdaugaProducator();
            _adaugaProducator.FormClosed += callbackUpdateComboBoxProducator;
            _adaugaProducator.ShowDialog(this);
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {
            _adaugaModel = new AdaugaModel();
            _adaugaModel.FormClosed += comboBoxProducator_SelectedIndexChanged;
            _adaugaModel.ShowDialog(this);

        }

        private void Vanzare_Load(object sender, EventArgs e)
        { 
            comboBoxModel.SelectedIndex = -1;
            comboBoxProducator.SelectedIndex = -1;
            comboBoxClient.SelectedIndex = -1;
            try
            {
                OracleCommand cmd = new OracleCommand(); ;
                OracleDataReader dr;
                cmd.CommandText = "SELECT nume_marca FROM producator";
                cmd.Connection = _dbConn;
                _dbConn.Open();
                dr = cmd.ExecuteReader();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInterfata nu a putut fi incarcata. Marcile auto nu au putut fi incarcate.", "Eroare-incarcare marca auto");
            }
            finally
            {
                _dbConn.Close();
            }

            try
            {
                OracleCommand cmd = new OracleCommand(); ;
                OracleDataReader dr;
                cmd.CommandText = "SELECT nume_client FROM client";
                cmd.Connection = _dbConn;
                _dbConn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    List<Object> prod = new List<Object>();
                    while (dr.Read())
                    {
                        prod.Add(dr["nume_client"].ToString());
                    }
                    object[] prodArray = prod.ConvertAll<object>(item => (object)item).ToArray();
                    comboBoxClient.Items.Clear();
                    comboBoxClient.Items.AddRange(prodArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInterfata nu a putut fi incarcata. Clientii nu au putut fi incarcati.", "Eroare-incarcare clienti");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void comboBoxProducator_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModel.Items.Clear();
            int producator = 0;
            try
            {
                OracleCommand cmd = new OracleCommand(); ;
                OracleDataReader dr;
                _dbConn.Open();
                cmd = new OracleCommand();
                cmd.CommandText = "SELECT id_producator FROM producator WHERE nume_marca='" + comboBoxProducator.Text + "'";
                cmd.Connection = _dbConn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        producator = Int32.Parse(dr["id_producator"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInterfata nu a putut fi incarcata", "Eroare - incarcare interfata");
            }
            finally
            {
                _dbConn.Close();
            }

            try
            {
                OracleCommand cmd = new OracleCommand(); ;
                OracleDataReader dr;
                _dbConn.Open();
                cmd.CommandText = "SELECT model FROM model_masina WHERE id_producator=" + producator;
                cmd.Connection = _dbConn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    List<Object> prod = new List<Object>();
                    while (dr.Read())
                    {
                        prod.Add(dr["model"].ToString());
                    }
                    object[] prodArray = prod.ConvertAll<object>(item => (object)item).ToArray();
                    comboBoxModel.Items.AddRange(prodArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInterfata nu a putut fi incarcata. Modelele de autoturisme nu au putut fi incarcate.", "Eroare - incarcare interfata");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void buttonGenFactura_Click(object sender, EventArgs e)
        {
            string tip_persoana = null;
            if (radioButtonPersoanaFizica.Checked)
                tip_persoana = "fizica";
            else
                if(radioButtonPersoanaJuridica.Checked)
                tip_persoana = "juridica";
            string serie_sasiu = textBoxSasiu.Text;
            string data = null;
            if(dateTimePicker1.Value.Month<10)
                data = dateTimePicker1.Value.Day + "-0" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Year;
            else
                data = dateTimePicker1.Value.Day + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Year;
            
            int client = 0;
            try
            {
                OracleCommand cmd = new OracleCommand(); ;
                OracleDataReader dr;
                _dbConn.Open();
                cmd = new OracleCommand();
                cmd.CommandText = "SELECT id_client FROM client WHERE nume_client='" + comboBoxClient.Text + "'";
                cmd.Connection = _dbConn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        client = Int32.Parse(dr["id_client"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nIncarcarea bazei de date a esuat.", "Eroare - incarcare baza de date");
            }
            finally
            {
                _dbConn.Close();
            }

            try
            {
                _dbConn.Open();
                string sql = "INSERT INTO factura (tip_persoana, serie_sasiu, cost, data_achizitionare, id_client, model_masina) VALUES ('" + tip_persoana + "','" + serie_sasiu + "'," + numericUpDownCost.Value + ", TO_DATE('"+data+"', 'DD-MM-YYYY'), " + client + ",'" + comboBoxModel.Text + "')";
                OracleCommand cmd = new OracleCommand(sql, _dbConn);
                cmd.BindByName = true;

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                _dbConn.Close();

                SaveFileDialog sd = new SaveFileDialog();
                sd.FileName = dateTimePicker1.Value.Day + "_" + dateTimePicker1.Value.Month + "_" + dateTimePicker1.Value.Year + "_" + comboBoxClient.Text + "_" + textBoxSasiu.Text + ".txt";
                sd.Filter = "Text File | *.txt";
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sd.FileName))
                    {
                        sw.WriteLine("Client:" + comboBoxClient.Text);
                        sw.WriteLine("Tip persoana:" + tip_persoana);
                        sw.WriteLine("Producator:" + comboBoxProducator.Text);
                        sw.WriteLine("Model:" + comboBoxModel.Text);
                        sw.WriteLine("Serie sasiu:" + textBoxSasiu.Text);
                        sw.WriteLine("Data achizitiei:" + dateTimePicker1.Value);
                        sw.WriteLine("Cost:" + numericUpDownCost.Value);
                    }

                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nFactura nu a putut fi introdusa in baza de date!", "Eroare - generare factura");
            }
            finally
            {
                _dbConn.Close();
            }



        }
    }
    }


