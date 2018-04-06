namespace BazaDanych
{
    partial class okno1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logowanieBTN = new System.Windows.Forms.Button();
            this.nazwaSerweraTB = new System.Windows.Forms.TextBox();
            this.bazaDanychTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hasloTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa serwera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baza danych";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasło";
            // 
            // logowanieBTN
            // 
            this.logowanieBTN.Location = new System.Drawing.Point(72, 197);
            this.logowanieBTN.Name = "logowanieBTN";
            this.logowanieBTN.Size = new System.Drawing.Size(140, 22);
            this.logowanieBTN.TabIndex = 4;
            this.logowanieBTN.Text = "Zaloguj";
            this.logowanieBTN.UseVisualStyleBackColor = true;
            this.logowanieBTN.Click += new System.EventHandler(this.logowanieBTN_Click);
            // 
            // nazwaSerweraTB
            // 
            this.nazwaSerweraTB.Location = new System.Drawing.Point(107, 45);
            this.nazwaSerweraTB.Name = "nazwaSerweraTB";
            this.nazwaSerweraTB.Size = new System.Drawing.Size(125, 20);
            this.nazwaSerweraTB.TabIndex = 5;
            // 
            // bazaDanychTB
            // 
            this.bazaDanychTB.Location = new System.Drawing.Point(107, 73);
            this.bazaDanychTB.Name = "bazaDanychTB";
            this.bazaDanychTB.Size = new System.Drawing.Size(125, 20);
            this.bazaDanychTB.TabIndex = 6;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(107, 101);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(125, 20);
            this.loginTB.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(182, 90);
            this.dataGridView1.TabIndex = 9;
            // 
            // hasloTB
            // 
            this.hasloTB.Location = new System.Drawing.Point(107, 130);
            this.hasloTB.Name = "hasloTB";
            this.hasloTB.PasswordChar = '*';
            this.hasloTB.Size = new System.Drawing.Size(125, 20);
            this.hasloTB.TabIndex = 10;
            // 
            // okno1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.hasloTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.bazaDanychTB);
            this.Controls.Add(this.nazwaSerweraTB);
            this.Controls.Add(this.logowanieBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "okno1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logowanieBTN;
        private System.Windows.Forms.TextBox nazwaSerweraTB;
        private System.Windows.Forms.TextBox bazaDanychTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox hasloTB;
    }
}

