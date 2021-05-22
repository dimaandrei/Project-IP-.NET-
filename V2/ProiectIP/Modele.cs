using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProiectIP
{
    public partial class Modele : Form
    {
        private OracleConnection _dbConn;
        public Modele()
        {
            _dbConn = DatabaseConnection.DatabaseConnection.GetConncetionInstance();
            InitializeComponent();
        }

        private void buttonShowModels_Click(object sender, EventArgs e)
        {
            try
            {
                OracleDataAdapter dataadapter = new OracleDataAdapter("SELECT * FROM model_masina", _dbConn);
                DataSet ds = new DataSet();
                _dbConn.Open();
                dataadapter.Fill(ds, "Modele_table");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Modele_table";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nTabelul nu a putut fi incarcat.", "Eroare - extragere din bd");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void buttonClearModels_Click(object sender, EventArgs e)
        {

        }
    }
}
