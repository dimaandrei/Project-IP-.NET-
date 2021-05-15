
namespace ProiectIP
{
    partial class Vanzare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxProducator = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonGenFactura = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonAddProducator = new System.Windows.Forms.Button();
            this.buttonAddModel = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelProducator = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonPersoanaFizica = new System.Windows.Forms.RadioButton();
            this.radioButtonPersoanaJuridica = new System.Windows.Forms.RadioButton();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelSasiu = new System.Windows.Forms.Label();
            this.labelAchizitonare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProducator
            // 
            this.comboBoxProducator.FormattingEnabled = true;
            this.comboBoxProducator.Location = new System.Drawing.Point(294, 158);
            this.comboBoxProducator.Name = "comboBoxProducator";
            this.comboBoxProducator.Size = new System.Drawing.Size(211, 23);
            this.comboBoxProducator.TabIndex = 0;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(511, 158);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(211, 23);
            this.comboBoxModel.TabIndex = 1;
            // 
            // buttonGenFactura
            // 
            this.buttonGenFactura.Location = new System.Drawing.Point(294, 356);
            this.buttonGenFactura.Name = "buttonGenFactura";
            this.buttonGenFactura.Size = new System.Drawing.Size(211, 23);
            this.buttonGenFactura.TabIndex = 2;
            this.buttonGenFactura.Text = "Generare factura";
            this.buttonGenFactura.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(111, 43);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(141, 23);
            this.buttonAddClient.TabIndex = 3;
            this.buttonAddClient.Text = "Adauga client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonAddProducator
            // 
            this.buttonAddProducator.Location = new System.Drawing.Point(309, 43);
            this.buttonAddProducator.Name = "buttonAddProducator";
            this.buttonAddProducator.Size = new System.Drawing.Size(141, 23);
            this.buttonAddProducator.TabIndex = 4;
            this.buttonAddProducator.Text = "Adauga producator";
            this.buttonAddProducator.UseVisualStyleBackColor = true;
            this.buttonAddProducator.Click += new System.EventHandler(this.buttonAddProducator_Click);
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.Location = new System.Drawing.Point(512, 43);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.Size = new System.Drawing.Size(141, 23);
            this.buttonAddModel.TabIndex = 5;
            this.buttonAddModel.Text = "Adauga model masina";
            this.buttonAddModel.UseVisualStyleBackColor = true;
            this.buttonAddModel.Click += new System.EventHandler(this.buttonAddModel_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(77, 158);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(211, 23);
            this.comboBoxClient.TabIndex = 6;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(159, 131);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(38, 15);
            this.labelClient.TabIndex = 7;
            this.labelClient.Text = "Client";
            // 
            // labelProducator
            // 
            this.labelProducator.AutoSize = true;
            this.labelProducator.Location = new System.Drawing.Point(361, 131);
            this.labelProducator.Name = "labelProducator";
            this.labelProducator.Size = new System.Drawing.Size(66, 15);
            this.labelProducator.TabIndex = 8;
            this.labelProducator.Text = "Producator";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(577, 131);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(82, 15);
            this.labelModel.TabIndex = 9;
            this.labelModel.Text = "Model masina";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 23);
            this.textBox1.TabIndex = 11;
            // 
            // radioButtonPersoanaFizica
            // 
            this.radioButtonPersoanaFizica.AutoSize = true;
            this.radioButtonPersoanaFizica.Location = new System.Drawing.Point(294, 301);
            this.radioButtonPersoanaFizica.Name = "radioButtonPersoanaFizica";
            this.radioButtonPersoanaFizica.Size = new System.Drawing.Size(103, 19);
            this.radioButtonPersoanaFizica.TabIndex = 13;
            this.radioButtonPersoanaFizica.TabStop = true;
            this.radioButtonPersoanaFizica.Text = "Persoana fizica";
            this.radioButtonPersoanaFizica.UseVisualStyleBackColor = true;
            // 
            // radioButtonPersoanaJuridica
            // 
            this.radioButtonPersoanaJuridica.AutoSize = true;
            this.radioButtonPersoanaJuridica.Location = new System.Drawing.Point(411, 301);
            this.radioButtonPersoanaJuridica.Name = "radioButtonPersoanaJuridica";
            this.radioButtonPersoanaJuridica.Size = new System.Drawing.Size(115, 19);
            this.radioButtonPersoanaJuridica.TabIndex = 14;
            this.radioButtonPersoanaJuridica.TabStop = true;
            this.radioButtonPersoanaJuridica.Text = "Persoana juridica";
            this.radioButtonPersoanaJuridica.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Location = new System.Drawing.Point(512, 226);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(210, 23);
            this.numericUpDownCost.TabIndex = 15;
            this.numericUpDownCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCost.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(595, 199);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(31, 15);
            this.labelCost.TabIndex = 18;
            this.labelCost.Text = "Cost";
            // 
            // labelSasiu
            // 
            this.labelSasiu.AutoSize = true;
            this.labelSasiu.Location = new System.Drawing.Point(361, 199);
            this.labelSasiu.Name = "labelSasiu";
            this.labelSasiu.Size = new System.Drawing.Size(61, 15);
            this.labelSasiu.TabIndex = 17;
            this.labelSasiu.Text = "Serie sasiu";
            // 
            // labelAchizitonare
            // 
            this.labelAchizitonare.AutoSize = true;
            this.labelAchizitonare.Location = new System.Drawing.Point(134, 199);
            this.labelAchizitonare.Name = "labelAchizitonare";
            this.labelAchizitonare.Size = new System.Drawing.Size(98, 15);
            this.labelAchizitonare.TabIndex = 16;
            this.labelAchizitonare.Text = "Data achizitonarii";
            // 
            // Vanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelSasiu);
            this.Controls.Add(this.labelAchizitonare);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.radioButtonPersoanaJuridica);
            this.Controls.Add(this.radioButtonPersoanaFizica);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelProducator);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonAddModel);
            this.Controls.Add(this.buttonAddProducator);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.buttonGenFactura);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxProducator);
            this.Name = "Vanzare";
            this.Text = "Vanzare autoturism";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProducator;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonGenFactura;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonAddProducator;
        private System.Windows.Forms.Button buttonAddModel;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelProducator;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonPersoanaFizica;
        private System.Windows.Forms.RadioButton radioButtonPersoanaJuridica;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelSasiu;
        private System.Windows.Forms.Label labelAchizitonare;
    }
}