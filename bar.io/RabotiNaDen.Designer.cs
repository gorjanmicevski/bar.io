
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
            this.btnDodadiRezervacija = new System.Windows.Forms.Button();
            this.btnPecati = new System.Windows.Forms.Button();
            this.lbRezervacii = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDodadiRezervacija
            // 
            this.btnDodadiRezervacija.Location = new System.Drawing.Point(32, 13);
            this.btnDodadiRezervacija.Name = "btnDodadiRezervacija";
            this.btnDodadiRezervacija.Size = new System.Drawing.Size(230, 58);
            this.btnDodadiRezervacija.TabIndex = 0;
            this.btnDodadiRezervacija.Text = "Додади резервација";
            this.btnDodadiRezervacija.UseVisualStyleBackColor = true;
            // 
            // btnPecati
            // 
            this.btnPecati.Location = new System.Drawing.Point(547, 13);
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
            this.lbRezervacii.Location = new System.Drawing.Point(42, 104);
            this.lbRezervacii.Name = "lbRezervacii";
            this.lbRezervacii.Size = new System.Drawing.Size(380, 324);
            this.lbRezervacii.TabIndex = 2;
            // 
            // RabotiNaDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}