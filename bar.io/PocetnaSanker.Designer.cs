
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaSanker));
            this.lbNarackiZaIsporaka = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIsporacani = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbNarackiZaIsporaka
            // 
            this.lbNarackiZaIsporaka.FormattingEnabled = true;
            this.lbNarackiZaIsporaka.HorizontalScrollbar = true;
            this.lbNarackiZaIsporaka.ItemHeight = 16;
            this.lbNarackiZaIsporaka.Location = new System.Drawing.Point(99, 104);
            this.lbNarackiZaIsporaka.Name = "lbNarackiZaIsporaka";
            this.lbNarackiZaIsporaka.Size = new System.Drawing.Size(506, 148);
            this.lbNarackiZaIsporaka.TabIndex = 0;
            this.lbNarackiZaIsporaka.SelectedIndexChanged += new System.EventHandler(this.lbNarackiZaIsporaka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Нарачки за испорака";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(99, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "ИСПОРАЧАЈ НАРАЧКА";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 23);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel2.Location = new System.Drawing.Point(-1, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 599);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(112)))));
            this.panel4.Location = new System.Drawing.Point(101, 584);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 10);
            this.panel4.TabIndex = 18;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(616, 29);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(97, 101);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Испорачани нарачки";
            // 
            // lbIsporacani
            // 
            this.lbIsporacani.FormattingEnabled = true;
            this.lbIsporacani.ItemHeight = 16;
            this.lbIsporacani.Location = new System.Drawing.Point(99, 318);
            this.lbIsporacani.Name = "lbIsporacani";
            this.lbIsporacani.Size = new System.Drawing.Size(506, 148);
            this.lbIsporacani.TabIndex = 19;
            // 
            // PocetnaSanker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbIsporacani);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNarackiZaIsporaka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbIsporacani;
    }
}