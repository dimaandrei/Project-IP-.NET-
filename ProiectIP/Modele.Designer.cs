
namespace ProiectIP
{
    partial class Modele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelModele = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowModels = new System.Windows.Forms.Button();
            this.buttonClearModels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1040, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.BackColor = System.Drawing.Color.Bisque;
            this.labelModele.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.Location = new System.Drawing.Point(15, 17);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(441, 79);
            this.labelModele.TabIndex = 1;
            this.labelModele.Text = "Modele de masini";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.labelModele);
            this.panel1.Location = new System.Drawing.Point(22, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 106);
            this.panel1.TabIndex = 2;
            // 
            // buttonShowModels
            // 
            this.buttonShowModels.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonShowModels.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowModels.Location = new System.Drawing.Point(12, 399);
            this.buttonShowModels.Name = "buttonShowModels";
            this.buttonShowModels.Size = new System.Drawing.Size(343, 42);
            this.buttonShowModels.TabIndex = 3;
            this.buttonShowModels.Text = "Afiseaza";
            this.buttonShowModels.UseVisualStyleBackColor = false;
            // 
            // buttonClearModels
            // 
            this.buttonClearModels.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonClearModels.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearModels.Location = new System.Drawing.Point(709, 408);
            this.buttonClearModels.Name = "buttonClearModels";
            this.buttonClearModels.Size = new System.Drawing.Size(343, 42);
            this.buttonClearModels.TabIndex = 4;
            this.buttonClearModels.Text = "Sterge";
            this.buttonClearModels.UseVisualStyleBackColor = false;
            // 
            // Modele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.modeleBG;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.buttonClearModels);
            this.Controls.Add(this.buttonShowModels);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Modele";
            this.Text = "Modele";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowModels;
        private System.Windows.Forms.Button buttonClearModels;
    }
}