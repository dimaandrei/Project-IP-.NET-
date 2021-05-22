
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
            this.labelNume.BackColor = System.Drawing.Color.Transparent;
            this.labelNume.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(0, 110);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(94, 18);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume client:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefon.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefon.Location = new System.Drawing.Point(23, 146);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(62, 18);
            this.labelTelefon.TabIndex = 1;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelTipPlata
            // 
            this.labelTipPlata.AutoSize = true;
            this.labelTipPlata.BackColor = System.Drawing.Color.Transparent;
            this.labelTipPlata.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipPlata.Location = new System.Drawing.Point(17, 178);
            this.labelTipPlata.Name = "labelTipPlata";
            this.labelTipPlata.Size = new System.Drawing.Size(73, 18);
            this.labelTipPlata.TabIndex = 2;
            this.labelTipPlata.Text = "Tip plată:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.Location = new System.Drawing.Point(36, 211);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(44, 18);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "Mail:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBoxNume.ForeColor = System.Drawing.Color.White;
            this.textBoxNume.Location = new System.Drawing.Point(93, 108);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(161, 20);
            this.textBoxNume.TabIndex = 4;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBoxMail.ForeColor = System.Drawing.Color.White;
            this.textBoxMail.Location = new System.Drawing.Point(93, 208);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(161, 20);
            this.textBoxMail.TabIndex = 5;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBoxTelefon.ForeColor = System.Drawing.Color.White;
            this.textBoxTelefon.Location = new System.Drawing.Point(93, 143);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(161, 20);
            this.textBoxTelefon.TabIndex = 8;
            // 
            // comboBoxTipPlata
            // 
            this.comboBoxTipPlata.BackColor = System.Drawing.Color.SaddleBrown;
            this.comboBoxTipPlata.ForeColor = System.Drawing.Color.White;
            this.comboBoxTipPlata.FormattingEnabled = true;
            this.comboBoxTipPlata.Items.AddRange(new object[] {
            "cash",
            "card"});
            this.comboBoxTipPlata.Location = new System.Drawing.Point(93, 175);
            this.comboBoxTipPlata.Name = "comboBoxTipPlata";
            this.comboBoxTipPlata.Size = new System.Drawing.Size(161, 21);
            this.comboBoxTipPlata.TabIndex = 9;
            // 
            // buttonAdaugaClient
            // 
            this.buttonAdaugaClient.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAdaugaClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaClient.ForeColor = System.Drawing.Color.White;
            this.buttonAdaugaClient.Location = new System.Drawing.Point(36, 257);
            this.buttonAdaugaClient.Name = "buttonAdaugaClient";
            this.buttonAdaugaClient.Size = new System.Drawing.Size(191, 40);
            this.buttonAdaugaClient.TabIndex = 10;
            this.buttonAdaugaClient.Text = "Adaugă client";
            this.buttonAdaugaClient.UseVisualStyleBackColor = false;
            this.buttonAdaugaClient.Click += new System.EventHandler(this.buttonAdaugaClient_Click);
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.BackColor = System.Drawing.Color.Transparent;
            this.labelTitlu.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(29, 37);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(211, 57);
            this.labelTitlu.TabIndex = 11;
            this.labelTitlu.Text = "Client nou";
            // 
            // AdaugaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.clientBG;
            this.ClientSize = new System.Drawing.Size(686, 391);
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
            this.MaximumSize = new System.Drawing.Size(702, 430);
            this.MinimumSize = new System.Drawing.Size(702, 430);
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