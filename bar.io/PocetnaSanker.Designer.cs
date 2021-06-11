
namespace bar.io
{
    partial class PocetnaSanker
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
            this.lbNarackiZaIsporaka = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNarackiZaIsporaka
            // 
            this.lbNarackiZaIsporaka.FormattingEnabled = true;
            this.lbNarackiZaIsporaka.ItemHeight = 16;
            this.lbNarackiZaIsporaka.Location = new System.Drawing.Point(12, 50);
            this.lbNarackiZaIsporaka.Name = "lbNarackiZaIsporaka";
            this.lbNarackiZaIsporaka.Size = new System.Drawing.Size(506, 388);
            this.lbNarackiZaIsporaka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Нарачки за испорака";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Испорачај нарачка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PocetnaSanker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNarackiZaIsporaka);
            this.Name = "PocetnaSanker";
            this.Text = "PocetnaSanker";
            this.Load += new System.EventHandler(this.PocetnaSanker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNarackiZaIsporaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}