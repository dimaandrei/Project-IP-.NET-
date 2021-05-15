
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
            this.comboBoxProducator.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxProducator.FormattingEnabled = true;
            this.comboBoxProducator.Location = new System.Drawing.Point(252, 112);
            this.comboBoxProducator.Name = "comboBoxProducator";
            this.comboBoxProducator.Size = new System.Drawing.Size(181, 21);
            this.comboBoxProducator.TabIndex = 0;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(438, 112);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(181, 21);
            this.comboBoxModel.TabIndex = 1;
            // 
            // buttonGenFactura
            // 
            this.buttonGenFactura.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenFactura.Location = new System.Drawing.Point(262, 369);
            this.buttonGenFactura.Name = "buttonGenFactura";
            this.buttonGenFactura.Size = new System.Drawing.Size(181, 25);
            this.buttonGenFactura.TabIndex = 2;
            this.buttonGenFactura.Text = "Generare factura";
            this.buttonGenFactura.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.Location = new System.Drawing.Point(95, 37);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(121, 32);
            this.buttonAddClient.TabIndex = 3;
            this.buttonAddClient.Text = "Adauga client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonAddProducator
            // 
            this.buttonAddProducator.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProducator.Location = new System.Drawing.Point(276, 29);
            this.buttonAddProducator.Name = "buttonAddProducator";
            this.buttonAddProducator.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonAddProducator.Size = new System.Drawing.Size(144, 49);
            this.buttonAddProducator.TabIndex = 4;
            this.buttonAddProducator.Text = "Adauga producator";
            this.buttonAddProducator.UseVisualStyleBackColor = true;
            this.buttonAddProducator.Click += new System.EventHandler(this.buttonAddProducator_Click);
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddModel.Location = new System.Drawing.Point(473, 37);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonAddModel.Size = new System.Drawing.Size(121, 32);
            this.buttonAddModel.TabIndex = 5;
            this.buttonAddModel.Text = "Adauga model masina";
            this.buttonAddModel.UseVisualStyleBackColor = true;
            this.buttonAddModel.Click += new System.EventHandler(this.buttonAddModel_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(66, 112);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(181, 21);
            this.comboBoxClient.TabIndex = 6;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.BackColor = System.Drawing.Color.Transparent;
            this.labelClient.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(136, 89);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(48, 18);
            this.labelClient.TabIndex = 7;
            this.labelClient.Text = "Client";
            // 
            // labelProducator
            // 
            this.labelProducator.AutoSize = true;
            this.labelProducator.BackColor = System.Drawing.Color.Transparent;
            this.labelProducator.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducator.ForeColor = System.Drawing.Color.White;
            this.labelProducator.Location = new System.Drawing.Point(309, 89);
            this.labelProducator.Name = "labelProducator";
            this.labelProducator.Size = new System.Drawing.Size(80, 18);
            this.labelProducator.TabIndex = 8;
            this.labelProducator.Text = "Producator";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.ForeColor = System.Drawing.Color.White;
            this.labelModel.Location = new System.Drawing.Point(495, 89);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(99, 18);
            this.labelModel.TabIndex = 9;
            this.labelModel.Text = "Model masina";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(262, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 11;
            // 
            // radioButtonPersoanaFizica
            // 
            this.radioButtonPersoanaFizica.AutoSize = true;
            this.radioButtonPersoanaFizica.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPersoanaFizica.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPersoanaFizica.ForeColor = System.Drawing.Color.White;
            this.radioButtonPersoanaFizica.Location = new System.Drawing.Point(59, 200);
            this.radioButtonPersoanaFizica.Name = "radioButtonPersoanaFizica";
            this.radioButtonPersoanaFizica.Size = new System.Drawing.Size(125, 22);
            this.radioButtonPersoanaFizica.TabIndex = 13;
            this.radioButtonPersoanaFizica.TabStop = true;
            this.radioButtonPersoanaFizica.Text = "Persoana fizica";
            this.radioButtonPersoanaFizica.UseVisualStyleBackColor = false;
            // 
            // radioButtonPersoanaJuridica
            // 
            this.radioButtonPersoanaJuridica.AutoSize = true;
            this.radioButtonPersoanaJuridica.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPersoanaJuridica.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPersoanaJuridica.ForeColor = System.Drawing.Color.White;
            this.radioButtonPersoanaJuridica.Location = new System.Drawing.Point(498, 200);
            this.radioButtonPersoanaJuridica.Name = "radioButtonPersoanaJuridica";
            this.radioButtonPersoanaJuridica.Size = new System.Drawing.Size(140, 22);
            this.radioButtonPersoanaJuridica.TabIndex = 14;
            this.radioButtonPersoanaJuridica.TabStop = true;
            this.radioButtonPersoanaJuridica.Text = "Persoana juridica";
            this.radioButtonPersoanaJuridica.UseVisualStyleBackColor = false;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.BackColor = System.Drawing.Color.DarkGray;
            this.numericUpDownCost.Location = new System.Drawing.Point(449, 333);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(180, 20);
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
            this.labelCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCost.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCost.Location = new System.Drawing.Point(520, 309);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(36, 18);
            this.labelCost.TabIndex = 18;
            this.labelCost.Text = "Cost";
            // 
            // labelSasiu
            // 
            this.labelSasiu.AutoSize = true;
            this.labelSasiu.BackColor = System.Drawing.Color.Transparent;
            this.labelSasiu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSasiu.ForeColor = System.Drawing.Color.White;
            this.labelSasiu.Location = new System.Drawing.Point(319, 309);
            this.labelSasiu.Name = "labelSasiu";
            this.labelSasiu.Size = new System.Drawing.Size(79, 18);
            this.labelSasiu.TabIndex = 17;
            this.labelSasiu.Text = "Serie sasiu";
            // 
            // labelAchizitonare
            // 
            this.labelAchizitonare.AutoSize = true;
            this.labelAchizitonare.BackColor = System.Drawing.Color.Transparent;
            this.labelAchizitonare.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchizitonare.ForeColor = System.Drawing.Color.White;
            this.labelAchizitonare.Location = new System.Drawing.Point(107, 309);
            this.labelAchizitonare.Name = "labelAchizitonare";
            this.labelAchizitonare.Size = new System.Drawing.Size(128, 18);
            this.labelAchizitonare.TabIndex = 16;
            this.labelAchizitonare.Text = "Data achizitonarii";
            // 
            // Vanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.vanzare1;
            this.ClientSize = new System.Drawing.Size(686, 411);
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
            this.MaximumSize = new System.Drawing.Size(702, 450);
            this.MinimumSize = new System.Drawing.Size(702, 450);
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