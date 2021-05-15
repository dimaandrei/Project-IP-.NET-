
namespace ProiectIP
{
    partial class Istoric
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
            this.labelIstoric = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowHistory = new System.Windows.Forms.Button();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIstoric
            // 
            this.labelIstoric.AutoSize = true;
            this.labelIstoric.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelIstoric.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIstoric.ForeColor = System.Drawing.Color.Black;
            this.labelIstoric.Location = new System.Drawing.Point(18, 31);
            this.labelIstoric.Name = "labelIstoric";
            this.labelIstoric.Size = new System.Drawing.Size(382, 79);
            this.labelIstoric.TabIndex = 0;
            this.labelIstoric.Text = "Istoric vanzari";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1040, 257);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.labelIstoric);
            this.panel1.Location = new System.Drawing.Point(67, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 145);
            this.panel1.TabIndex = 2;
            // 
            // buttonShowHistory
            // 
            this.buttonShowHistory.BackColor = System.Drawing.Color.Teal;
            this.buttonShowHistory.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowHistory.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonShowHistory.Location = new System.Drawing.Point(12, 368);
            this.buttonShowHistory.Name = "buttonShowHistory";
            this.buttonShowHistory.Size = new System.Drawing.Size(295, 38);
            this.buttonShowHistory.TabIndex = 3;
            this.buttonShowHistory.Text = "Afiseaza";
            this.buttonShowHistory.UseVisualStyleBackColor = false;
            this.buttonShowHistory.Click += new System.EventHandler(this.buttonShowHistory_Click);
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.BackColor = System.Drawing.Color.Teal;
            this.buttonClearHistory.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearHistory.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonClearHistory.Location = new System.Drawing.Point(757, 368);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(295, 38);
            this.buttonClearHistory.TabIndex = 4;
            this.buttonClearHistory.Text = "Sterge";
            this.buttonClearHistory.UseVisualStyleBackColor = false;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // Istoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.istoricBG;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.buttonShowHistory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Istoric";
            this.Text = "Istoric";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelIstoric;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowHistory;
        private System.Windows.Forms.Button buttonClearHistory;
    }
}