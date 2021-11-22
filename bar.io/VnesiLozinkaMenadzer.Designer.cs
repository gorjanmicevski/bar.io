
namespace bar.io
{
    partial class VnesiLozinkaMenadzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VnesiLozinkaMenadzer));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Лозинка:";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(76, 130);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(177, 70);
            this.btnPotvrdi.TabIndex = 4;
            this.btnPotvrdi.Text = "ПОТВРДИ";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click_1);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(65, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(228, 22);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 23);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel2.Location = new System.Drawing.Point(2, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 230);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel3.Location = new System.Drawing.Point(-1, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 230);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel4.Location = new System.Drawing.Point(77, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 10);
            this.panel4.TabIndex = 18;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(317, 40);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(79, 73);
            this.btnGoBack.TabIndex = 19;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // VnesiLozinkaMenadzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 231);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.tbPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VnesiLozinkaMenadzer";
            this.Text = "VnesiLozinkaMenadzer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGoBack;
    }
}