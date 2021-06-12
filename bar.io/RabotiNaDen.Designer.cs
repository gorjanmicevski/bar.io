
namespace bar.io
{
    partial class RabotiNaDen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RabotiNaDen));
            this.btnDodadiRezervacija = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            this.lbRezervacii = new System.Windows.Forms.ListBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodadiRezervacija
            // 
            this.btnDodadiRezervacija.Location = new System.Drawing.Point(510, 206);
            this.btnDodadiRezervacija.Name = "btnDodadiRezervacija";
            this.btnDodadiRezervacija.Size = new System.Drawing.Size(230, 58);
            this.btnDodadiRezervacija.TabIndex = 0;
            this.btnDodadiRezervacija.Text = "Додади резервација";
            this.btnDodadiRezervacija.UseVisualStyleBackColor = true;
            this.btnDodadiRezervacija.Click += new System.EventHandler(this.btnDodadiRezervacija_Click);
            // 
            // btnPecati
            // 
            this.btnPecati.Location = new System.Drawing.Point(510, 370);
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.Size = new System.Drawing.Size(230, 58);
            this.btnPecati.TabIndex = 1;
            this.btnPecati.Text = "Печати резервации";
            this.btnPecati.UseVisualStyleBackColor = true;
            // 
            // lbRezervacii
            // 
            this.lbRezervacii.FormattingEnabled = true;
            this.lbRezervacii.ItemHeight = 16;
            this.lbRezervacii.Location = new System.Drawing.Point(42, 24);
            this.lbRezervacii.Name = "lbRezervacii";
            this.lbRezervacii.Size = new System.Drawing.Size(380, 404);
            this.lbRezervacii.TabIndex = 2;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(723, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(65, 69);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Избриши резервација";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RabotiNaDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lbRezervacii);
            this.Controls.Add(this.btnPecati);
            this.Controls.Add(this.btnDodadiRezervacija);
            this.Name = "RabotiNaDen";
            this.Text = "RabotiNaDen";
            this.Load += new System.EventHandler(this.RabotiNaDen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodadiRezervacija;
        private System.Windows.Forms.Button btnPecati;
        private System.Windows.Forms.ListBox lbRezervacii;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button button1;
    }
}