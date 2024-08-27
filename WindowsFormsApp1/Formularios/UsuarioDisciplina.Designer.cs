namespace WindowsFormsApp1.Formularios
{
    partial class UsuarioDisciplina
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
            this.SearchCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SearchCbx
            // 
            this.SearchCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchCbx.FormattingEnabled = true;
            this.SearchCbx.Location = new System.Drawing.Point(12, 12);
            this.SearchCbx.Name = "SearchCbx";
            this.SearchCbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchCbx.Size = new System.Drawing.Size(121, 21);
            this.SearchCbx.TabIndex = 0;
            // 
            // UsuarioDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchCbx);
            this.Name = "UsuarioDisciplina";
            this.Text = "UsuarioDisciplina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SearchCbx;
    }
}