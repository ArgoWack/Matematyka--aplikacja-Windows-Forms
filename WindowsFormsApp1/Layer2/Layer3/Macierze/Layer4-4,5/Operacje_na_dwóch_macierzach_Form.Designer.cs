namespace WindowsFormsApp1.Layer3.Macierze.Layer4_4_5.Layer_5
{
    partial class Operacje_na_dwóch_macierzach_Form
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
            this.Iloczyn_Kroneckera = new System.Windows.Forms.Button();
            this.Iloczyn_Hadamarda = new System.Windows.Forms.Button();
            this.Mnożenie = new System.Windows.Forms.Button();
            this.Dodawanie = new System.Windows.Forms.Button();
            this.Odejmowanie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(471, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wybierz operacje";
            // 
            // Iloczyn_Kroneckera
            // 
            this.Iloczyn_Kroneckera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Iloczyn_Kroneckera.Location = new System.Drawing.Point(638, 399);
            this.Iloczyn_Kroneckera.Margin = new System.Windows.Forms.Padding(4);
            this.Iloczyn_Kroneckera.Name = "Iloczyn_Kroneckera";
            this.Iloczyn_Kroneckera.Size = new System.Drawing.Size(267, 123);
            this.Iloczyn_Kroneckera.TabIndex = 14;
            this.Iloczyn_Kroneckera.Text = "Iloczyn Kroneckera";
            this.Iloczyn_Kroneckera.UseVisualStyleBackColor = true;
            this.Iloczyn_Kroneckera.Click += new System.EventHandler(this.Iloczyn_Kroneckera_Click);
            // 
            // Iloczyn_Hadamarda
            // 
            this.Iloczyn_Hadamarda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Iloczyn_Hadamarda.Location = new System.Drawing.Point(264, 399);
            this.Iloczyn_Hadamarda.Margin = new System.Windows.Forms.Padding(4);
            this.Iloczyn_Hadamarda.Name = "Iloczyn_Hadamarda";
            this.Iloczyn_Hadamarda.Size = new System.Drawing.Size(267, 123);
            this.Iloczyn_Hadamarda.TabIndex = 13;
            this.Iloczyn_Hadamarda.Text = "Iloczyn Hadamarda";
            this.Iloczyn_Hadamarda.UseVisualStyleBackColor = true;
            this.Iloczyn_Hadamarda.Click += new System.EventHandler(this.Iloczyn_Hadamarda_Click);
            // 
            // Mnożenie
            // 
            this.Mnożenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Mnożenie.Location = new System.Drawing.Point(784, 152);
            this.Mnożenie.Margin = new System.Windows.Forms.Padding(4);
            this.Mnożenie.Name = "Mnożenie";
            this.Mnożenie.Size = new System.Drawing.Size(267, 123);
            this.Mnożenie.TabIndex = 12;
            this.Mnożenie.Text = "Mnożenie";
            this.Mnożenie.UseVisualStyleBackColor = true;
            this.Mnożenie.Click += new System.EventHandler(this.Mnożenie_Click);
            // 
            // Dodawanie
            // 
            this.Dodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dodawanie.Location = new System.Drawing.Point(451, 152);
            this.Dodawanie.Margin = new System.Windows.Forms.Padding(4);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(267, 123);
            this.Dodawanie.TabIndex = 11;
            this.Dodawanie.Text = "Dodawanie";
            this.Dodawanie.UseVisualStyleBackColor = true;
            this.Dodawanie.Click += new System.EventHandler(this.Dodawanie_Click);
            // 
            // Odejmowanie
            // 
            this.Odejmowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Odejmowanie.Location = new System.Drawing.Point(104, 152);
            this.Odejmowanie.Margin = new System.Windows.Forms.Padding(4);
            this.Odejmowanie.Name = "Odejmowanie";
            this.Odejmowanie.Size = new System.Drawing.Size(267, 123);
            this.Odejmowanie.TabIndex = 10;
            this.Odejmowanie.Text = "Odejmowanie";
            this.Odejmowanie.UseVisualStyleBackColor = true;
            this.Odejmowanie.Click += new System.EventHandler(this.Odejmowanie_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(-3, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 96);
            this.button1.TabIndex = 16;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operacje_na_dwóch_macierzach_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1190, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Iloczyn_Kroneckera);
            this.Controls.Add(this.Iloczyn_Hadamarda);
            this.Controls.Add(this.Mnożenie);
            this.Controls.Add(this.Dodawanie);
            this.Controls.Add(this.Odejmowanie);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Operacje_na_dwóch_macierzach_Form";
            this.Text = "Operacje_na_dwóch_macierzach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Iloczyn_Kroneckera;
        private System.Windows.Forms.Button Iloczyn_Hadamarda;
        private System.Windows.Forms.Button Mnożenie;
        private System.Windows.Forms.Button Dodawanie;
        private System.Windows.Forms.Button Odejmowanie;
        private System.Windows.Forms.Button button1;
    }
}