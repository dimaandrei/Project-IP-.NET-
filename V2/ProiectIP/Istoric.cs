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
    public partial class Istoric : Form
    {
        private OracleConnection _dbConn;
        public Istoric()
        {
            _dbConn = DatabaseConnection.DatabaseConnection.GetConncetionInstance();
            InitializeComponent();
        }

        private void buttonShowHistory_Click(object sender, EventArgs e)
        {
            try
            {
                OracleDataAdapter dataadapter = new OracleDataAdapter("SELECT * FROM factura", _dbConn);
                DataSet ds = new DataSet();
                _dbConn.Open();
                dataadapter.Fill(ds, "Istoric_table");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Istoric_table";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nTabelul nu a putut fi incarcat.", "Eroare - extragere din baza de date");
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
