
namespace bar.io
{
    partial class DodadiNaracka
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
            this.components = new System.ComponentModel.Container();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNaracka = new System.Windows.Forms.ListBox();
            this.cbArtikli = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(147, 38);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(191, 22);
            this.tbIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име:";
            // 
            // lbNaracka
            // 
            this.lbNaracka.FormattingEnabled = true;
            this.lbNaracka.ItemHeight = 16;
            this.lbNaracka.Location = new System.Drawing.Point(452, 38);
            this.lbNaracka.Name = "lbNaracka";
            this.lbNaracka.Size = new System.Drawing.Size(402, 292);
            this.lbNaracka.TabIndex = 2;
            // 
            // cbArtikli
            // 
            this.cbArtikli.FormattingEnabled = true;
            this.cbArtikli.Location = new System.Drawing.Point(147, 104);
            this.cbArtikli.Name = "cbArtikli";
            this.cbArtikli.Size = new System.Drawing.Size(191, 24);
            this.cbArtikli.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Артикал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количина:";
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(147, 171);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(191, 22);
            this.tbKolicina.TabIndex = 5;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(27, 256);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(151, 74);
            this.btnDodadi.TabIndex = 7;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(218, 256);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(151, 74);
            this.btnPotvrdi.TabIndex = 8;
            this.btnPotvrdi.Text = "Потврди";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodadiNaracka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 382);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbArtikli);
            this.Controls.Add(this.lbNaracka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIme);
            this.Name = "DodadiNaracka";
            this.Text = "DodadiNaracka";
            this.Load += new System.EventHandler(this.DodadiNaracka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbNaracka;
        private System.Windows.Forms.ComboBox cbArtikli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}