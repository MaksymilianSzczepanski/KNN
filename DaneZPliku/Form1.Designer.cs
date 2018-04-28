namespace DaneZPlikuOkienko
{
    partial class DaneZPliku
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
            this.btnWybierzSystemTestowy = new System.Windows.Forms.Button();
            this.tbSciezkaDoSystemuTestowego = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSciezkaDoSystemuTreningowego = new System.Windows.Forms.TextBox();
            this.btnWybierzSystemTreningowy = new System.Windows.Forms.Button();
            this.tbSystemTreningowy = new System.Windows.Forms.TextBox();
            this.tbSystemTestowy = new System.Windows.Forms.TextBox();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWybierzSystemTestowy
            // 
            this.btnWybierzSystemTestowy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWybierzSystemTestowy.Location = new System.Drawing.Point(774, 12);
            this.btnWybierzSystemTestowy.Name = "btnWybierzSystemTestowy";
            this.btnWybierzSystemTestowy.Size = new System.Drawing.Size(42, 23);
            this.btnWybierzSystemTestowy.TabIndex = 0;
            this.btnWybierzSystemTestowy.Text = "...";
            this.btnWybierzSystemTestowy.UseVisualStyleBackColor = true;
            this.btnWybierzSystemTestowy.Click += new System.EventHandler(this.btnWybierzSystemTestowy_Click);
            // 
            // tbSciezkaDoSystemuTestowego
            // 
            this.tbSciezkaDoSystemuTestowego.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSciezkaDoSystemuTestowego.Location = new System.Drawing.Point(252, 12);
            this.tbSciezkaDoSystemuTestowego.Name = "tbSciezkaDoSystemuTestowego";
            this.tbSciezkaDoSystemuTestowego.ReadOnly = true;
            this.tbSciezkaDoSystemuTestowego.Size = new System.Drawing.Size(516, 22);
            this.tbSciezkaDoSystemuTestowego.TabIndex = 1;
            this.tbSciezkaDoSystemuTestowego.Click += new System.EventHandler(this.btnWybierzSystemTestowy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ścieżka do systemu testowego";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(344, 577);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 43);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Pracuj";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ścieżka do systemu treningowego";
            // 
            // tbSciezkaDoSystemuTreningowego
            // 
            this.tbSciezkaDoSystemuTreningowego.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSciezkaDoSystemuTreningowego.Location = new System.Drawing.Point(252, 44);
            this.tbSciezkaDoSystemuTreningowego.Name = "tbSciezkaDoSystemuTreningowego";
            this.tbSciezkaDoSystemuTreningowego.ReadOnly = true;
            this.tbSciezkaDoSystemuTreningowego.Size = new System.Drawing.Size(516, 22);
            this.tbSciezkaDoSystemuTreningowego.TabIndex = 5;
            this.tbSciezkaDoSystemuTreningowego.Click += new System.EventHandler(this.btnWybierzSystemTreningowy_Click);
            // 
            // btnWybierzSystemTreningowy
            // 
            this.btnWybierzSystemTreningowy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWybierzSystemTreningowy.Location = new System.Drawing.Point(774, 44);
            this.btnWybierzSystemTreningowy.Name = "btnWybierzSystemTreningowy";
            this.btnWybierzSystemTreningowy.Size = new System.Drawing.Size(42, 23);
            this.btnWybierzSystemTreningowy.TabIndex = 6;
            this.btnWybierzSystemTreningowy.Text = "...";
            this.btnWybierzSystemTreningowy.UseVisualStyleBackColor = true;
            this.btnWybierzSystemTreningowy.Click += new System.EventHandler(this.btnWybierzSystemTreningowy_Click);
            // 
            // tbSystemTreningowy
            // 
            this.tbSystemTreningowy.Location = new System.Drawing.Point(398, 72);
            this.tbSystemTreningowy.Multiline = true;
            this.tbSystemTreningowy.Name = "tbSystemTreningowy";
            this.tbSystemTreningowy.ReadOnly = true;
            this.tbSystemTreningowy.Size = new System.Drawing.Size(370, 238);
            this.tbSystemTreningowy.TabIndex = 10;
            this.tbSystemTreningowy.TextChanged += new System.EventHandler(this.tbSystemTreningowy_TextChanged);
            // 
            // tbSystemTestowy
            // 
            this.tbSystemTestowy.Location = new System.Drawing.Point(15, 72);
            this.tbSystemTestowy.Multiline = true;
            this.tbSystemTestowy.Name = "tbSystemTestowy";
            this.tbSystemTestowy.ReadOnly = true;
            this.tbSystemTestowy.Size = new System.Drawing.Size(377, 238);
            this.tbSystemTestowy.TabIndex = 11;
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(15, 333);
            this.wynik.Multiline = true;
            this.wynik.Name = "wynik";
            this.wynik.ReadOnly = true;
            this.wynik.Size = new System.Drawing.Size(468, 226);
            this.wynik.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "wybierz metryke";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(614, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "podaj K";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(614, 394);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // DaneZPliku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 632);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.tbSystemTestowy);
            this.Controls.Add(this.tbSystemTreningowy);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnWybierzSystemTreningowy);
            this.Controls.Add(this.tbSciezkaDoSystemuTreningowego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSciezkaDoSystemuTestowego);
            this.Controls.Add(this.btnWybierzSystemTestowy);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "DaneZPliku";
            this.Text = "Dane z pliku";
            this.Load += new System.EventHandler(this.DaneZPliku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWybierzSystemTestowy;
        private System.Windows.Forms.TextBox tbSciezkaDoSystemuTestowego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSciezkaDoSystemuTreningowego;
        private System.Windows.Forms.Button btnWybierzSystemTreningowy;
        private System.Windows.Forms.TextBox tbSystemTreningowy;
        private System.Windows.Forms.TextBox tbSystemTestowy;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

