
namespace bar.io
{
    partial class PocetnaKelner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaKelner));
            this.btnDodadiMasa = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnEditMasa = new System.Windows.Forms.Button();
            this.btnSmetka = new System.Windows.Forms.Button();
            this.lbMasi = new System.Windows.Forms.ListBox();
            this.btnIzbrisiMasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodadiMasa
            // 
            this.btnDodadiMasa.Location = new System.Drawing.Point(606, 104);
            this.btnDodadiMasa.Name = "btnDodadiMasa";
            this.btnDodadiMasa.Size = new System.Drawing.Size(231, 62);
            this.btnDodadiMasa.TabIndex = 1;
            this.btnDodadiMasa.Text = "Додади маса";
            this.btnDodadiMasa.UseVisualStyleBackColor = true;
            this.btnDodadiMasa.Click += new System.EventHandler(this.btnDodadiMasa_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(783, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(65, 69);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnEditMasa
            // 
            this.btnEditMasa.Location = new System.Drawing.Point(606, 209);
            this.btnEditMasa.Name = "btnEditMasa";
            this.btnEditMasa.Size = new System.Drawing.Size(231, 62);
            this.btnEditMasa.TabIndex = 5;
            this.btnEditMasa.Text = "Уреди маса";
            this.btnEditMasa.UseVisualStyleBackColor = true;
            // 
            // btnSmetka
            // 
            this.btnSmetka.Location = new System.Drawing.Point(606, 398);
            this.btnSmetka.Name = "btnSmetka";
            this.btnSmetka.Size = new System.Drawing.Size(231, 62);
            this.btnSmetka.TabIndex = 6;
            this.btnSmetka.Text = "Извади сметка";
            this.btnSmetka.UseVisualStyleBackColor = true;
            // 
            // lbMasi
            // 
            this.lbMasi.FormattingEnabled = true;
            this.lbMasi.ItemHeight = 16;
            this.lbMasi.Location = new System.Drawing.Point(27, 35);
            this.lbMasi.Name = "lbMasi";
            this.lbMasi.Size = new System.Drawing.Size(491, 436);
            this.lbMasi.TabIndex = 7;
            // 
            // btnIzbrisiMasa
            // 
            this.btnIzbrisiMasa.Location = new System.Drawing.Point(606, 299);
            this.btnIzbrisiMasa.Name = "btnIzbrisiMasa";
            this.btnIzbrisiMasa.Size = new System.Drawing.Size(231, 62);
            this.btnIzbrisiMasa.TabIndex = 8;
            this.btnIzbrisiMasa.Text = "Избриши маса";
            this.btnIzbrisiMasa.UseVisualStyleBackColor = true;
            // 
            // PocetnaKelner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 496);
            this.Controls.Add(this.btnIzbrisiMasa);
            this.Controls.Add(this.lbMasi);
            this.Controls.Add(this.btnSmetka);
            this.Controls.Add(this.btnEditMasa);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnDodadiMasa);
            this.Name = "PocetnaKelner";
            this.Text = "PocetnaKelner";
            this.Load += new System.EventHandler(this.PocetnaKelner_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodadiMasa;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnEditMasa;
        private System.Windows.Forms.Button btnSmetka;
        private System.Windows.Forms.ListBox lbMasi;
        private System.Windows.Forms.Button btnIzbrisiMasa;
    }
}