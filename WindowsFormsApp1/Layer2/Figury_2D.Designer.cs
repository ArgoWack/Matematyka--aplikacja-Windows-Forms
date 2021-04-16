namespace WindowsFormsApp1
{
    partial class Figury_2D
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
            this.Koło = new System.Windows.Forms.Button();
            this.Trójkąt = new System.Windows.Forms.Button();
            this.Czworokąt = new System.Windows.Forms.Button();
            this.Wielokąt_foremny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Koło
            // 
            this.Koło.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Koło.Location = new System.Drawing.Point(191, 107);
            this.Koło.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Koło.Name = "Koło";
            this.Koło.Size = new System.Drawing.Size(279, 138);
            this.Koło.TabIndex = 0;
            this.Koło.Text = "Koło";
            this.Koło.UseVisualStyleBackColor = true;
            this.Koło.Click += new System.EventHandler(this.Koło_Click);
            // 
            // Trójkąt
            // 
            this.Trójkąt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Trójkąt.Location = new System.Drawing.Point(708, 107);
            this.Trójkąt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trójkąt.Name = "Trójkąt";
            this.Trójkąt.Size = new System.Drawing.Size(279, 138);
            this.Trójkąt.TabIndex = 1;
            this.Trójkąt.Text = "Trójkąt";
            this.Trójkąt.UseVisualStyleBackColor = true;
            this.Trójkąt.Click += new System.EventHandler(this.Trójkąt_Click);
            // 
            // Czworokąt
            // 
            this.Czworokąt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Czworokąt.Location = new System.Drawing.Point(191, 369);
            this.Czworokąt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Czworokąt.Name = "Czworokąt";
            this.Czworokąt.Size = new System.Drawing.Size(279, 138);
            this.Czworokąt.TabIndex = 2;
            this.Czworokąt.Text = "Czworokąt";
            this.Czworokąt.UseVisualStyleBackColor = true;
            this.Czworokąt.Click += new System.EventHandler(this.Czworokąt_Click);
            // 
            // Wielokąt_foremny
            // 
            this.Wielokąt_foremny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Wielokąt_foremny.Location = new System.Drawing.Point(708, 369);
            this.Wielokąt_foremny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Wielokąt_foremny.Name = "Wielokąt_foremny";
            this.Wielokąt_foremny.Size = new System.Drawing.Size(279, 138);
            this.Wielokąt_foremny.TabIndex = 3;
            this.Wielokąt_foremny.Text = "Wielokąt foremny";
            this.Wielokąt_foremny.UseVisualStyleBackColor = true;
            this.Wielokąt_foremny.Click += new System.EventHandler(this.Wielokąt_foremny_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(432, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wybierz rodzaj figury";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(3, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Figury_2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wielokąt_foremny);
            this.Controls.Add(this.Czworokąt);
            this.Controls.Add(this.Trójkąt);
            this.Controls.Add(this.Koło);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Figury_2D";
            this.Text = "Figury_2D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Koło;
        private System.Windows.Forms.Button Trójkąt;
        private System.Windows.Forms.Button Czworokąt;
        private System.Windows.Forms.Button Wielokąt_foremny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}