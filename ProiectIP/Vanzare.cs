using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectIP
{
    public partial class Vanzare : Form
    {
        static Form adauga;
        public Vanzare()
        {
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            adauga = new AdaugaClient();
            adauga.ShowDialog(this);
        }

        private void buttonAddProducator_Click(object sender, EventArgs e)
        {
            adauga = new AdaugaProducator();
            adauga.ShowDialog(this);
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {
            adauga = new AdaugaModel();
            adauga.ShowDialog(this);

        }
    }
}
