
namespace bar.io
{
    partial class Login
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
            this.btnNajavaMenadzer = new System.Windows.Forms.Button();
            this.btnNajavaKelner = new System.Windows.Forms.Button();
            this.btnNajavaSanker = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNajavaMenadzer
            // 
            this.btnNajavaMenadzer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNajavaMenadzer.Location = new System.Drawing.Point(255, 281);
            this.btnNajavaMenadzer.Name = "btnNajavaMenadzer";
            this.btnNajavaMenadzer.Size = new System.Drawing.Size(312, 66);
            this.btnNajavaMenadzer.TabIndex = 1;
            this.btnNajavaMenadzer.Text = "Најави се како менаџер";
            this.btnNajavaMenadzer.UseVisualStyleBackColor = true;
            // 
            // btnNajavaKelner
            // 
            this.btnNajavaKelner.Location = new System.Drawing.Point(255, 382);
            this.btnNajavaKelner.Name = "btnNajavaKelner";
            this.btnNajavaKelner.Size = new System.Drawing.Size(312, 66);
            this.btnNajavaKelner.TabIndex = 2;
            this.btnNajavaKelner.Text = "Најави се како келнер";
            this.btnNajavaKelner.UseVisualStyleBackColor = true;
            // 
            // btnNajavaSanker
            // 
            this.btnNajavaSanker.Location = new System.Drawing.Point(255, 484);
            this.btnNajavaSanker.Name = "btnNajavaSanker";
            this.btnNajavaSanker.Size = new System.Drawing.Size(312, 66);
            this.btnNajavaSanker.TabIndex = 3;
            this.btnNajavaSanker.Text = "Најави се како шанкер";
            this.btnNajavaSanker.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::bar.io.Properties.Resources.urbanista_white_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 233);
            this.panel1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.btnNajavaSanker);
            this.Controls.Add(this.btnNajavaKelner);
            this.Controls.Add(this.btnNajavaMenadzer);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNajavaMenadzer;
        private System.Windows.Forms.Button btnNajavaKelner;
        private System.Windows.Forms.Button btnNajavaSanker;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}