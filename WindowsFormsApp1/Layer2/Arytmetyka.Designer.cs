namespace WindowsFormsApp1
{
    partial class Artmetyka
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
            this.NWD_NWW = new System.Windows.Forms.Button();
            this.Dzielenie_z_resztą = new System.Windows.Forms.Button();
            this.Funkcja_liniowa = new System.Windows.Forms.Button();
            this.Funkcja_kwadratowa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NWD_NWW
            // 
            this.NWD_NWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NWD_NWW.Location = new System.Drawing.Point(160, 123);
            this.NWD_NWW.Margin = new System.Windows.Forms.Padding(4);
            this.NWD_NWW.Name = "NWD_NWW";
            this.NWD_NWW.Size = new System.Drawing.Size(267, 148);
            this.NWD_NWW.TabIndex = 0;
            this.NWD_NWW.Text = "NWD i NWW";
            this.NWD_NWW.UseVisualStyleBackColor = true;
            this.NWD_NWW.Click += new System.EventHandler(this.NWD_NWW_Click);
            // 
            // Dzielenie_z_resztą
            // 
            this.Dzielenie_z_resztą.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dzielenie_z_resztą.Location = new System.Drawing.Point(600, 123);
            this.Dzielenie_z_resztą.Margin = new System.Windows.Forms.Padding(4);
            this.Dzielenie_z_resztą.Name = "Dzielenie_z_resztą";
            this.Dzielenie_z_resztą.Size = new System.Drawing.Size(267, 148);
            this.Dzielenie_z_resztą.TabIndex = 1;
            this.Dzielenie_z_resztą.Text = "Dzielenie z resztą";
            this.Dzielenie_z_resztą.UseVisualStyleBackColor = true;
            this.Dzielenie_z_resztą.Click += new System.EventHandler(this.Dzielenie_z_resztą_Click);
            // 
            // Funkcja_liniowa
            // 
            this.Funkcja_liniowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Funkcja_liniowa.Location = new System.Drawing.Point(160, 369);
            this.Funkcja_liniowa.Margin = new System.Windows.Forms.Padding(4);
            this.Funkcja_liniowa.Name = "Funkcja_liniowa";
            this.Funkcja_liniowa.Size = new System.Drawing.Size(267, 148);
            this.Funkcja_liniowa.TabIndex = 2;
            this.Funkcja_liniowa.Text = "Funkcja liniowa";
            this.Funkcja_liniowa.UseVisualStyleBackColor = true;
            this.Funkcja_liniowa.Click += new System.EventHandler(this.Funkcja_liniowa_Click);
            // 
            // Funkcja_kwadratowa
            // 
            this.Funkcja_kwadratowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Funkcja_kwadratowa.Location = new System.Drawing.Point(600, 369);
            this.Funkcja_kwadratowa.Margin = new System.Windows.Forms.Padding(4);
            this.Funkcja_kwadratowa.Name = "Funkcja_kwadratowa";
            this.Funkcja_kwadratowa.Size = new System.Drawing.Size(267, 148);
            this.Funkcja_kwadratowa.TabIndex = 3;
            this.Funkcja_kwadratowa.Text = "Funkcja kwadratowa";
            this.Funkcja_kwadratowa.UseVisualStyleBackColor = true;
            this.Funkcja_kwadratowa.Click += new System.EventHandler(this.Funkcja_kwadratowa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(280, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wybierz dziedzine która cie interesuje";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(3, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Artmetyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Funkcja_kwadratowa);
            this.Controls.Add(this.Funkcja_liniowa);
            this.Controls.Add(this.Dzielenie_z_resztą);
            this.Controls.Add(this.NWD_NWW);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Artmetyka";
            this.Text = "Arytmetyka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NWD_NWW;
        private System.Windows.Forms.Button Dzielenie_z_resztą;
        private System.Windows.Forms.Button Funkcja_liniowa;
        private System.Windows.Forms.Button Funkcja_kwadratowa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}