namespace ProiectASD
{
    partial class Form4
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
            this.nume = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.RadioButton();
            this.client = new System.Windows.Forms.RadioButton();
            this.cc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meniu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(124, 86);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 20);
            this.nume.TabIndex = 0;
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(124, 128);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(100, 20);
            this.parola.TabIndex = 1;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Checked = true;
            this.admin.Location = new System.Drawing.Point(124, 154);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(54, 17);
            this.admin.TabIndex = 2;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Location = new System.Drawing.Point(124, 177);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(51, 17);
            this.client.TabIndex = 3;
            this.client.Text = "Client";
            this.client.UseVisualStyleBackColor = true;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(124, 200);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(100, 23);
            this.cc.TabIndex = 4;
            this.cc.Text = "Creaza Cont";
            this.cc.UseVisualStyleBackColor = true;
            this.cc.Click += new System.EventHandler(this.cc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parola";
            // 
            // meniu
            // 
            this.meniu.Location = new System.Drawing.Point(124, 229);
            this.meniu.Name = "meniu";
            this.meniu.Size = new System.Drawing.Size(100, 23);
            this.meniu.TabIndex = 7;
            this.meniu.Text = "Meniu Principal";
            this.meniu.UseVisualStyleBackColor = true;
            this.meniu.Click += new System.EventHandler(this.meniu_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 316);
            this.Controls.Add(this.meniu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.client);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.nume);
            this.Name = "Form4";
            this.Text = "Creaza Cont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.RadioButton client;
        private System.Windows.Forms.Button cc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button meniu;
    }
}