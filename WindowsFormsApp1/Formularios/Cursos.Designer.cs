
namespace Formulario
{
    partial class Cursos
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.NomeTbx = new System.Windows.Forms.TextBox();
            this.AreaTbx = new System.Windows.Forms.TextBox();
            this.HorarioInicioTbx = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.HorarioFimTbx = new System.Windows.Forms.TextBox();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DuracaoNud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DuracaoNud)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(230, 8);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(402, 327);
            this.Table.TabIndex = 0;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // NomeTbx
            // 
            this.NomeTbx.Location = new System.Drawing.Point(12, 8);
            this.NomeTbx.Name = "NomeTbx";
            this.NomeTbx.Size = new System.Drawing.Size(165, 20);
            this.NomeTbx.TabIndex = 1;
            this.NomeTbx.Text = "Nome";
            // 
            // AreaTbx
            // 
            this.AreaTbx.Location = new System.Drawing.Point(12, 34);
            this.AreaTbx.Name = "AreaTbx";
            this.AreaTbx.Size = new System.Drawing.Size(165, 20);
            this.AreaTbx.TabIndex = 2;
            this.AreaTbx.Text = "Area";
            // 
            // HorarioInicioTbx
            // 
            this.HorarioInicioTbx.Location = new System.Drawing.Point(12, 60);
            this.HorarioInicioTbx.Name = "HorarioInicioTbx";
            this.HorarioInicioTbx.Size = new System.Drawing.Size(165, 20);
            this.HorarioInicioTbx.TabIndex = 3;
            this.HorarioInicioTbx.Text = "Horário Início";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(12, 189);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(165, 23);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Cadastrar";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 218);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(165, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // HorarioFimTbx
            // 
            this.HorarioFimTbx.Location = new System.Drawing.Point(12, 86);
            this.HorarioFimTbx.Name = "HorarioFimTbx";
            this.HorarioFimTbx.Size = new System.Drawing.Size(165, 20);
            this.HorarioFimTbx.TabIndex = 9;
            this.HorarioFimTbx.Text = "Horário Fim";
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.Location = new System.Drawing.Point(230, 341);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(293, 23);
            this.DeleteRowBtn.TabIndex = 11;
            this.DeleteRowBtn.Text = "Deletar Linha {}";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(529, 341);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 23);
            this.EditBtn.TabIndex = 12;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DuracaoNud
            // 
            this.DuracaoNud.Location = new System.Drawing.Point(12, 112);
            this.DuracaoNud.Name = "DuracaoNud";
            this.DuracaoNud.Size = new System.Drawing.Size(165, 20);
            this.DuracaoNud.TabIndex = 13;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 373);
            this.Controls.Add(this.DuracaoNud);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.HorarioFimTbx);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.HorarioInicioTbx);
            this.Controls.Add(this.AreaTbx);
            this.Controls.Add(this.NomeTbx);
            this.Controls.Add(this.Table);
            this.Name = "Cursos";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DuracaoNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox NomeTbx;
        private System.Windows.Forms.TextBox AreaTbx;
        private System.Windows.Forms.TextBox HorarioInicioTbx;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox HorarioFimTbx;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.NumericUpDown DuracaoNud;
    }
}