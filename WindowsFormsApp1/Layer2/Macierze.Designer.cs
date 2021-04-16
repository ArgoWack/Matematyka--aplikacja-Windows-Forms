namespace WindowsFormsApp1
{
    partial class Macierze
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
            this.Jedna_macierz = new System.Windows.Forms.Button();
            this.Dwie_macierze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jedna_macierz
            // 
            this.Jedna_macierz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Jedna_macierz.Location = new System.Drawing.Point(67, 160);
            this.Jedna_macierz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Jedna_macierz.Name = "Jedna_macierz";
            this.Jedna_macierz.Size = new System.Drawing.Size(333, 185);
            this.Jedna_macierz.TabIndex = 0;
            this.Jedna_macierz.Text = "Jedna macierz";
            this.Jedna_macierz.UseVisualStyleBackColor = true;
            this.Jedna_macierz.Click += new System.EventHandler(this.Jedna_macierz_Click);
            // 
            // Dwie_macierze
            // 
            this.Dwie_macierze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dwie_macierze.Location = new System.Drawing.Point(555, 166);
            this.Dwie_macierze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dwie_macierze.Name = "Dwie_macierze";
            this.Dwie_macierze.Size = new System.Drawing.Size(333, 185);
            this.Dwie_macierze.TabIndex = 1;
            this.Dwie_macierze.Text = "Dwie macierze";
            this.Dwie_macierze.UseVisualStyleBackColor = true;
            this.Dwie_macierze.Click += new System.EventHandler(this.Dwie_macierze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(329, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wybierz ilość macierzy";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(0, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 81);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Macierze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dwie_macierze);
            this.Controls.Add(this.Jedna_macierz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Macierze";
            this.Text = "Macierze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Jedna_macierz;
        private System.Windows.Forms.Button Dwie_macierze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}