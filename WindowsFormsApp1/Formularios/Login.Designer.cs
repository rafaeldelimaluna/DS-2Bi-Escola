namespace WindowsFormsApp1.Formularios
{
    partial class Login
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
            this.NomeTbx = new System.Windows.Forms.TextBox();
            this.SenhaTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-52, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(150, 5, 150, 5);
            this.label1.Size = new System.Drawing.Size(370, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // NomeTbx
            // 
            this.NomeTbx.Location = new System.Drawing.Point(64, 63);
            this.NomeTbx.Name = "NomeTbx";
            this.NomeTbx.Size = new System.Drawing.Size(141, 20);
            this.NomeTbx.TabIndex = 1;
            this.NomeTbx.WordWrap = false;
            // 
            // SenhaTbx
            // 
            this.SenhaTbx.Location = new System.Drawing.Point(64, 115);
            this.SenhaTbx.Name = "SenhaTbx";
            this.SenhaTbx.PasswordChar = '*';
            this.SenhaTbx.ShortcutsEnabled = false;
            this.SenhaTbx.Size = new System.Drawing.Size(141, 20);
            this.SenhaTbx.TabIndex = 2;
            this.SenhaTbx.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(55, 0, 55, 25);
            this.label2.Size = new System.Drawing.Size(148, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(61, 47);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(30, 0, 30, 25);
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome de Usuário";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Location = new System.Drawing.Point(64, 173);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(145, 36);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Entrar";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(61, 212);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(35, 13);
            this.MessageLbl.TabIndex = 6;
            this.MessageLbl.Text = "label4";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 249);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.SenhaTbx);
            this.Controls.Add(this.NomeTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTbx;
        private System.Windows.Forms.TextBox SenhaTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label MessageLbl;
    }
}