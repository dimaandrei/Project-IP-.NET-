
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
            this.comboBoxOrigine = new System.Windows.Forms.ComboBox();
            this.labelTara = new System.Windows.Forms.Label();
            this.comboBoxGrupAuto = new System.Windows.Forms.ComboBox();
            this.labelGrup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitlu.Location = new System.Drawing.Point(261, 48);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(298, 54);
            this.labelTitlu.TabIndex = 21;
            this.labelTitlu.Text = "Producator nou";
            // 
            // buttonAdaugaProducator
            // 
            this.buttonAdaugaProducator.Location = new System.Drawing.Point(311, 369);
            this.buttonAdaugaProducator.Name = "buttonAdaugaProducator";
            this.buttonAdaugaProducator.Size = new System.Drawing.Size(206, 33);
            this.buttonAdaugaProducator.TabIndex = 20;
            this.buttonAdaugaProducator.Text = "Adauga producator";
            this.buttonAdaugaProducator.UseVisualStyleBackColor = true;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(199, 268);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(465, 23);
            this.textBoxTelefon.TabIndex = 18;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(199, 307);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(465, 23);
            this.textBoxMail.TabIndex = 17;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(199, 154);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(465, 23);
            this.textBoxNume.TabIndex = 16;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(151, 310);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(30, 15);
            this.labelMail.TabIndex = 15;
            this.labelMail.Text = "Mail";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(136, 271);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(45, 15);
            this.labelTelefon.TabIndex = 13;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(109, 157);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(76, 15);
            this.labelNume.TabIndex = 12;
            this.labelNume.Text = "Nume marca";
            // 
            // comboBoxOrigine
            // 
            this.comboBoxOrigine.FormattingEnabled = true;
            this.comboBoxOrigine.Location = new System.Drawing.Point(199, 192);
            this.comboBoxOrigine.Name = "comboBoxOrigine";
            this.comboBoxOrigine.Size = new System.Drawing.Size(465, 23);
            this.comboBoxOrigine.TabIndex = 23;
            // 
            // labelTara
            // 
            this.labelTara.AutoSize = true;
            this.labelTara.Location = new System.Drawing.Point(101, 195);
            this.labelTara.Name = "labelTara";
            this.labelTara.Size = new System.Drawing.Size(84, 15);
            this.labelTara.TabIndex = 22;
            this.labelTara.Text = "Tara de origine";
            // 
            // comboBoxGrupAuto
            // 
            this.comboBoxGrupAuto.FormattingEnabled = true;
            this.comboBoxGrupAuto.Location = new System.Drawing.Point(199, 230);
            this.comboBoxGrupAuto.Name = "comboBoxGrupAuto";
            this.comboBoxGrupAuto.Size = new System.Drawing.Size(465, 23);
            this.comboBoxGrupAuto.TabIndex = 25;
            // 
            // labelGrup
            // 
            this.labelGrup.AutoSize = true;
            this.labelGrup.Location = new System.Drawing.Point(121, 233);
            this.labelGrup.Name = "labelGrup";
            this.labelGrup.Size = new System.Drawing.Size(60, 15);
            this.labelGrup.TabIndex = 24;
            this.labelGrup.Text = "Grup auto";
            // 
            // AdaugaProducator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxGrupAuto);
            this.Controls.Add(this.labelGrup);
            this.Controls.Add(this.comboBoxOrigine);
            this.Controls.Add(this.labelTara);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.buttonAdaugaProducator);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelNume);
            this.Name = "AdaugaProducator";
            this.Text = "AdaugaProducator";
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
        private System.Windows.Forms.ComboBox comboBoxOrigine;
        private System.Windows.Forms.Label labelTara;
        private System.Windows.Forms.ComboBox comboBoxGrupAuto;
        private System.Windows.Forms.Label labelGrup;
    }
}