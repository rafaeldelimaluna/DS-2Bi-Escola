namespace WindowsFormsApp1.Formularios
{
    partial class CursoDisciplina
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
            this.CursoCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisciplinaCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CursoCbx
            // 
            this.CursoCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CursoCbx.FormattingEnabled = true;
            this.CursoCbx.Location = new System.Drawing.Point(12, 33);
            this.CursoCbx.Name = "CursoCbx";
            this.CursoCbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CursoCbx.Size = new System.Drawing.Size(221, 21);
            this.CursoCbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disciplina";
            // 
            // DisciplinaCbx
            // 
            this.DisciplinaCbx.FormattingEnabled = true;
            this.DisciplinaCbx.Location = new System.Drawing.Point(552, 33);
            this.DisciplinaCbx.Name = "DisciplinaCbx";
            this.DisciplinaCbx.Size = new System.Drawing.Size(222, 21);
            this.DisciplinaCbx.TabIndex = 3;
            this.DisciplinaCbx.SelectedIndexChanged += new System.EventHandler(this.DisciplinaCbx_SelectedIndexChanged);
            // 
            // CursoDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisciplinaCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CursoCbx);
            this.Name = "CursoDisciplina";
            this.Text = "UsuarioDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CursoCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DisciplinaCbx;
    }
}