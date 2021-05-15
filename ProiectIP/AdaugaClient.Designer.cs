
namespace ProiectIP
{
    partial class AdaugaClient
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
            this.labelNume = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelTipPlata = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.comboBoxTipPlata = new System.Windows.Forms.ComboBox();
            this.buttonAdaugaClient = new System.Windows.Forms.Button();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(85, 116);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(63, 13);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume client";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(108, 152);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 1;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelTipPlata
            // 
            this.labelTipPlata.AutoSize = true;
            this.labelTipPlata.Location = new System.Drawing.Point(102, 184);
            this.labelTipPlata.Name = "labelTipPlata";
            this.labelTipPlata.Size = new System.Drawing.Size(48, 13);
            this.labelTipPlata.TabIndex = 2;
            this.labelTipPlata.Text = "Tip plata";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(121, 217);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "Mail";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(162, 114);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(399, 20);
            this.textBoxNume.TabIndex = 4;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(162, 214);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(399, 20);
            this.textBoxMail.TabIndex = 5;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(162, 149);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(399, 20);
            this.textBoxTelefon.TabIndex = 8;
            // 
            // comboBoxTipPlata
            // 
            this.comboBoxTipPlata.FormattingEnabled = true;
            this.comboBoxTipPlata.Location = new System.Drawing.Point(162, 181);
            this.comboBoxTipPlata.Name = "comboBoxTipPlata";
            this.comboBoxTipPlata.Size = new System.Drawing.Size(399, 21);
            this.comboBoxTipPlata.TabIndex = 9;
            // 
            // buttonAdaugaClient
            // 
            this.buttonAdaugaClient.Location = new System.Drawing.Point(261, 272);
            this.buttonAdaugaClient.Name = "buttonAdaugaClient";
            this.buttonAdaugaClient.Size = new System.Drawing.Size(177, 29);
            this.buttonAdaugaClient.TabIndex = 10;
            this.buttonAdaugaClient.Text = "Adauga client";
            this.buttonAdaugaClient.UseVisualStyleBackColor = true;
            this.buttonAdaugaClient.Click += new System.EventHandler(this.buttonAdaugaClient_Click);
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.labelTitlu.Location = new System.Drawing.Point(261, 22);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(206, 54);
            this.labelTitlu.TabIndex = 11;
            this.labelTitlu.Text = "Client nou";
            // 
            // AdaugaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.buttonAdaugaClient);
            this.Controls.Add(this.comboBoxTipPlata);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTipPlata);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelNume);
            this.Name = "AdaugaClient";
            this.Text = "AdaugaClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelTipPlata;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.ComboBox comboBoxTipPlata;
        private System.Windows.Forms.Button buttonAdaugaClient;
        private System.Windows.Forms.Label labelTitlu;
    }
}