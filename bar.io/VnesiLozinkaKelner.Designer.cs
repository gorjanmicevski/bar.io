
namespace bar.io
{
    partial class VnesiLozinkaKelner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VnesiLozinkaKelner));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(64, 79);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(228, 22);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(80, 128);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(183, 70);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "ПОТВРДИ";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лозинка:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 23);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel2.Location = new System.Drawing.Point(-1, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 230);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel4.Location = new System.Drawing.Point(80, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 10);
            this.panel4.TabIndex = 17;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(317, 38);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(79, 73);
            this.btnGoBack.TabIndex = 18;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // VnesiLozinkaKelner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 231);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.tbPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VnesiLozinkaKelner";
            this.Text = "VnesiLozinkaKelner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGoBack;
    }
}