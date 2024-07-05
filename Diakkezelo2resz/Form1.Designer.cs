namespace Diakkezelo2resz
{
    partial class Form1
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
            this.pnlGombok = new System.Windows.Forms.Panel();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstDiakok = new System.Windows.Forms.ListBox();
            this.lstKereseseredmeny = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(489, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Születési év";
            // 
            // pnlGombok
            // 
            this.pnlGombok.AutoScroll = true;
            this.pnlGombok.BackColor = System.Drawing.Color.Coral;
            this.pnlGombok.Location = new System.Drawing.Point(369, 60);
            this.pnlGombok.Name = "pnlGombok";
            this.pnlGombok.Size = new System.Drawing.Size(390, 48);
            this.pnlGombok.TabIndex = 5;
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(119, 397);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(96, 39);
            this.btnAdatbevitel.TabIndex = 6;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.adatbe_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstDiakok
            // 
            this.lstDiakok.FormattingEnabled = true;
            this.lstDiakok.Location = new System.Drawing.Point(43, 60);
            this.lstDiakok.Name = "lstDiakok";
            this.lstDiakok.Size = new System.Drawing.Size(253, 316);
            this.lstDiakok.TabIndex = 7;
            // 
            // lstKereseseredmeny
            // 
            this.lstKereseseredmeny.FormattingEnabled = true;
            this.lstKereseseredmeny.Location = new System.Drawing.Point(369, 190);
            this.lstKereseseredmeny.Name = "lstKereseseredmeny";
            this.lstKereseseredmeny.Size = new System.Drawing.Size(390, 186);
            this.lstKereseseredmeny.TabIndex = 8;
            this.lstKereseseredmeny.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(364, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "A keresés edménye:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstKereseseredmeny);
            this.Controls.Add(this.lstDiakok);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.pnlGombok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGombok;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstDiakok;
        private System.Windows.Forms.ListBox lstKereseseredmeny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

