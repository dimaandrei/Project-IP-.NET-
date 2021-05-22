
namespace ProiectIP
{
    partial class AdaugaProducator
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
            this.labelTitlu = new System.Windows.Forms.Label();
            this.buttonAdaugaProducator = new System.Windows.Forms.Button();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelTara = new System.Windows.Forms.Label();
            this.labelGrup = new System.Windows.Forms.Label();
            this.textBoxOrigine = new System.Windows.Forms.TextBox();
            this.textBoxGrupAuto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.BackColor = System.Drawing.Color.DarkGreen;
            this.labelTitlu.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.ForeColor = System.Drawing.Color.White;
            this.labelTitlu.Location = new System.Drawing.Point(215, -3);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(299, 57);
            this.labelTitlu.TabIndex = 21;
            this.labelTitlu.Text = "Producător nou";
            // 
            // buttonAdaugaProducator
            // 
            this.buttonAdaugaProducator.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAdaugaProducator.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaProducator.ForeColor = System.Drawing.Color.Black;
            this.buttonAdaugaProducator.Location = new System.Drawing.Point(258, 308);
            this.buttonAdaugaProducator.Name = "buttonAdaugaProducator";
            this.buttonAdaugaProducator.Size = new System.Drawing.Size(188, 43);
            this.buttonAdaugaProducator.TabIndex = 20;
            this.buttonAdaugaProducator.Text = "Adaugă producător";
            this.buttonAdaugaProducator.UseVisualStyleBackColor = false;
            this.buttonAdaugaProducator.Click += new System.EventHandler(this.buttonAdaugaProducator_Click);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(267, 248);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(168, 20);
            this.textBoxTelefon.TabIndex = 18;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(267, 282);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(168, 20);
            this.textBoxMail.TabIndex = 17;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(267, 116);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(168, 20);
            this.textBoxNume.TabIndex = 16;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelMail.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.Color.Black;
            this.labelMail.Location = new System.Drawing.Point(185, 282);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(54, 22);
            this.labelMail.TabIndex = 15;
            this.labelMail.Text = "Mail:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelTelefon.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefon.ForeColor = System.Drawing.Color.Black;
            this.labelTelefon.Location = new System.Drawing.Point(173, 248);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(74, 22);
            this.labelTelefon.TabIndex = 13;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelNume.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.ForeColor = System.Drawing.Color.Black;
            this.labelNume.Location = new System.Drawing.Point(149, 116);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(112, 22);
            this.labelNume.TabIndex = 12;
            this.labelNume.Text = "Nume marcă:";
            // 
            // labelTara
            // 
            this.labelTara.AutoSize = true;
            this.labelTara.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelTara.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTara.ForeColor = System.Drawing.Color.Black;
            this.labelTara.Location = new System.Drawing.Point(143, 149);
            this.labelTara.Name = "labelTara";
            this.labelTara.Size = new System.Drawing.Size(133, 22);
            this.labelTara.TabIndex = 22;
            this.labelTara.Text = "Țară de origine:";
            // 
            // labelGrup
            // 
            this.labelGrup.AutoSize = true;
            this.labelGrup.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelGrup.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrup.ForeColor = System.Drawing.Color.Black;
            this.labelGrup.Location = new System.Drawing.Point(160, 182);
            this.labelGrup.Name = "labelGrup";
            this.labelGrup.Size = new System.Drawing.Size(95, 22);
            this.labelGrup.TabIndex = 24;
            this.labelGrup.Text = "Grup auto:";
            // 
            // textBoxOrigine
            // 
            this.textBoxOrigine.Location = new System.Drawing.Point(278, 151);
            this.textBoxOrigine.Name = "textBoxOrigine";
            this.textBoxOrigine.Size = new System.Drawing.Size(168, 20);
            this.textBoxOrigine.TabIndex = 26;
            // 
            // textBoxGrupAuto
            // 
            this.textBoxGrupAuto.Location = new System.Drawing.Point(258, 184);
            this.textBoxGrupAuto.Name = "textBoxGrupAuto";
            this.textBoxGrupAuto.Size = new System.Drawing.Size(168, 20);
            this.textBoxGrupAuto.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.labelTitlu);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 54);
            this.panel1.TabIndex = 28;
            // 
            // AdaugaProducator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.producerBG;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.textBoxGrupAuto);
            this.Controls.Add(this.textBoxOrigine);
            this.Controls.Add(this.labelGrup);
            this.Controls.Add(this.labelTara);
            this.Controls.Add(this.buttonAdaugaProducator);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.panel1);
            this.Name = "AdaugaProducator";
            this.Text = "AdaugaProducator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button buttonAdaugaProducator;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelTara;
        private System.Windows.Forms.Label labelGrup;
        private System.Windows.Forms.TextBox textBoxOrigine;
        private System.Windows.Forms.TextBox textBoxGrupAuto;
        private System.Windows.Forms.Panel panel1;
    }
}