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
            this.Table = new System.Windows.Forms.DataGridView();
            this.PeriodoCbx = new System.Windows.Forms.ComboBox();
            this.TurnoLbl = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // CursoCbx
            // 
            this.CursoCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CursoCbx.FormattingEnabled = true;
            this.CursoCbx.Location = new System.Drawing.Point(77, 32);
            this.CursoCbx.Name = "CursoCbx";
            this.CursoCbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CursoCbx.Size = new System.Drawing.Size(160, 21);
            this.CursoCbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disciplina";
            // 
            // DisciplinaCbx
            // 
            this.DisciplinaCbx.FormattingEnabled = true;
            this.DisciplinaCbx.Location = new System.Drawing.Point(77, 73);
            this.DisciplinaCbx.Name = "DisciplinaCbx";
            this.DisciplinaCbx.Size = new System.Drawing.Size(160, 21);
            this.DisciplinaCbx.TabIndex = 3;
            this.DisciplinaCbx.SelectedIndexChanged += new System.EventHandler(this.DisciplinaCbx_SelectedIndexChanged);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(255, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(738, 426);
            this.Table.TabIndex = 4;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // PeriodoCbx
            // 
            this.PeriodoCbx.FormattingEnabled = true;
            this.PeriodoCbx.Items.AddRange(new object[] {
            "1° Módulo",
            "2° Módulo",
            "3° Módulo",
            "4° Módulo"});
            this.PeriodoCbx.Location = new System.Drawing.Point(77, 117);
            this.PeriodoCbx.Name = "PeriodoCbx";
            this.PeriodoCbx.Size = new System.Drawing.Size(160, 21);
            this.PeriodoCbx.TabIndex = 5;
            // 
            // TurnoLbl
            // 
            this.TurnoLbl.AutoSize = true;
            this.TurnoLbl.Location = new System.Drawing.Point(12, 120);
            this.TurnoLbl.Name = "TurnoLbl";
            this.TurnoLbl.Size = new System.Drawing.Size(43, 13);
            this.TurnoLbl.TabIndex = 6;
            this.TurnoLbl.Text = "Periodo";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(15, 159);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(222, 23);
            this.RegisterBtn.TabIndex = 7;
            this.RegisterBtn.Text = "Adicionar";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(255, 445);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(738, 23);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Excluir Registro {}";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(15, 188);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(222, 23);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CursoDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 471);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.TurnoLbl);
            this.Controls.Add(this.PeriodoCbx);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.DisciplinaCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CursoCbx);
            this.Name = "CursoDisciplina";
            this.Text = "UsuarioDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CursoCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DisciplinaCbx;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ComboBox PeriodoCbx;
        private System.Windows.Forms.Label TurnoLbl;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}