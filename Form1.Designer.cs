namespace ProiectASD
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
            this.NumeUtilizator = new System.Windows.Forms.TextBox();
            this.Parola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.creazaCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeUtilizator
            // 
            this.NumeUtilizator.Location = new System.Drawing.Point(323, 193);
            this.NumeUtilizator.Name = "NumeUtilizator";
            this.NumeUtilizator.Size = new System.Drawing.Size(179, 20);
            this.NumeUtilizator.TabIndex = 0;
            // 
            // Parola
            // 
            this.Parola.Location = new System.Drawing.Point(323, 235);
            this.Parola.Name = "Parola";
            this.Parola.PasswordChar = '*';
            this.Parola.Size = new System.Drawing.Size(179, 20);
            this.Parola.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUME UTILIZATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(323, 277);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(179, 34);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // creazaCont
            // 
            this.creazaCont.Location = new System.Drawing.Point(323, 317);
            this.creazaCont.Name = "creazaCont";
            this.creazaCont.Size = new System.Drawing.Size(179, 23);
            this.creazaCont.TabIndex = 5;
            this.creazaCont.Text = "Creaza Cont";
            this.creazaCont.UseVisualStyleBackColor = true;
            this.creazaCont.Click += new System.EventHandler(this.creazaCont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 526);
            this.Controls.Add(this.creazaCont);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.NumeUtilizator);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeUtilizator;
        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button creazaCont;
    }
}

