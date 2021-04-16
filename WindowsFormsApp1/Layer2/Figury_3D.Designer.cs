namespace WindowsFormsApp1
{
    partial class Figury_3D
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
            this.Kula = new System.Windows.Forms.Button();
            this.Prostopadłościan = new System.Windows.Forms.Button();
            this.Ostrosłup = new System.Windows.Forms.Button();
            this.Stożek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kula
            // 
            this.Kula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Kula.Location = new System.Drawing.Point(93, 86);
            this.Kula.Margin = new System.Windows.Forms.Padding(4);
            this.Kula.Name = "Kula";
            this.Kula.Size = new System.Drawing.Size(267, 117);
            this.Kula.TabIndex = 0;
            this.Kula.Text = "Kula";
            this.Kula.UseVisualStyleBackColor = true;
            this.Kula.Click += new System.EventHandler(this.Kula_Click);
            // 
            // Prostopadłościan
            // 
            this.Prostopadłościan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Prostopadłościan.Location = new System.Drawing.Point(533, 86);
            this.Prostopadłościan.Margin = new System.Windows.Forms.Padding(4);
            this.Prostopadłościan.Name = "Prostopadłościan";
            this.Prostopadłościan.Size = new System.Drawing.Size(267, 117);
            this.Prostopadłościan.TabIndex = 1;
            this.Prostopadłościan.Text = "Prostopadłościan";
            this.Prostopadłościan.UseVisualStyleBackColor = true;
            this.Prostopadłościan.Click += new System.EventHandler(this.Prostopadłościan_Click);
            // 
            // Ostrosłup
            // 
            this.Ostrosłup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Ostrosłup.Location = new System.Drawing.Point(93, 325);
            this.Ostrosłup.Margin = new System.Windows.Forms.Padding(4);
            this.Ostrosłup.Name = "Ostrosłup";
            this.Ostrosłup.Size = new System.Drawing.Size(267, 117);
            this.Ostrosłup.TabIndex = 2;
            this.Ostrosłup.Text = "Ostrosłup";
            this.Ostrosłup.UseVisualStyleBackColor = true;
            this.Ostrosłup.Click += new System.EventHandler(this.Ostrosłup_Click);
            // 
            // Stożek
            // 
            this.Stożek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Stożek.Location = new System.Drawing.Point(533, 325);
            this.Stożek.Margin = new System.Windows.Forms.Padding(4);
            this.Stożek.Name = "Stożek";
            this.Stożek.Size = new System.Drawing.Size(267, 117);
            this.Stożek.TabIndex = 3;
            this.Stożek.Text = "Stożek";
            this.Stożek.UseVisualStyleBackColor = true;
            this.Stożek.Click += new System.EventHandler(this.Stożek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(248, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wybierz rodzaj bryły która cie interesuje";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(1, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Figury_3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stożek);
            this.Controls.Add(this.Ostrosłup);
            this.Controls.Add(this.Prostopadłościan);
            this.Controls.Add(this.Kula);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Figury_3D";
            this.Text = "Figury_3D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kula;
        private System.Windows.Forms.Button Prostopadłościan;
        private System.Windows.Forms.Button Ostrosłup;
        private System.Windows.Forms.Button Stożek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}