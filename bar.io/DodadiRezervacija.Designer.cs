
namespace bar.io
{
    partial class DodadiRezervacija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.cbMasa = new System.Windows.Forms.ComboBox();
            this.lblDodadiRezervacija = new System.Windows.Forms.Label();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Маса:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(129, 77);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(199, 22);
            this.tbIme.TabIndex = 0;
            // 
            // cbMasa
            // 
            this.cbMasa.FormattingEnabled = true;
            this.cbMasa.Location = new System.Drawing.Point(129, 141);
            this.cbMasa.Name = "cbMasa";
            this.cbMasa.Size = new System.Drawing.Size(199, 24);
            this.cbMasa.TabIndex = 1;
            // 
            // lblDodadiRezervacija
            // 
            this.lblDodadiRezervacija.AutoSize = true;
            this.lblDodadiRezervacija.Location = new System.Drawing.Point(175, 29);
            this.lblDodadiRezervacija.Name = "lblDodadiRezervacija";
            this.lblDodadiRezervacija.Size = new System.Drawing.Size(0, 17);
            this.lblDodadiRezervacija.TabIndex = 4;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(46, 229);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(129, 65);
            this.btnDodadi.TabIndex = 2;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(199, 229);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(129, 65);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // DodadiRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 320);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.lblDodadiRezervacija);
            this.Controls.Add(this.cbMasa);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodadiRezervacija";
            this.Text = "DodadiRezervacija";
            this.Load += new System.EventHandler(this.DodadiRezervacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.ComboBox cbMasa;
        private System.Windows.Forms.Label lblDodadiRezervacija;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnOtkazi;
    }
}