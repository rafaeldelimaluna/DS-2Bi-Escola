
namespace Formulario
{
    partial class DisciplinasEntidade
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
            this.SiglaTbx = new System.Windows.Forms.TextBox();
            this.isAtivoChk = new System.Windows.Forms.CheckBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.IdNud = new System.Windows.Forms.NumericUpDown();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.EditRowBtn = new System.Windows.Forms.Button();
            this.SearchTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Disciplinas";
            // 
            // NomeTbx
            // 
            this.NomeTbx.Location = new System.Drawing.Point(12, 82);
            this.NomeTbx.Name = "NomeTbx";
            this.NomeTbx.Size = new System.Drawing.Size(167, 20);
            this.NomeTbx.TabIndex = 1;
            this.NomeTbx.Text = "Nome";
            // 
            // SiglaTbx
            // 
            this.SiglaTbx.Location = new System.Drawing.Point(12, 108);
            this.SiglaTbx.Name = "SiglaTbx";
            this.SiglaTbx.Size = new System.Drawing.Size(167, 20);
            this.SiglaTbx.TabIndex = 2;
            this.SiglaTbx.Text = "Sigla";
            // 
            // isAtivoChk
            // 
            this.isAtivoChk.AutoSize = true;
            this.isAtivoChk.Location = new System.Drawing.Point(12, 134);
            this.isAtivoChk.Name = "isAtivoChk";
            this.isAtivoChk.Size = new System.Drawing.Size(50, 17);
            this.isAtivoChk.TabIndex = 3;
            this.isAtivoChk.Text = "Ativo";
            this.isAtivoChk.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(12, 167);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(167, 23);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Cadastrar";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 196);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(167, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(194, 32);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(594, 240);
            this.Table.TabIndex = 6;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // IdNud
            // 
            this.IdNud.Location = new System.Drawing.Point(12, 56);
            this.IdNud.Name = "IdNud";
            this.IdNud.Size = new System.Drawing.Size(167, 20);
            this.IdNud.TabIndex = 7;
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.Location = new System.Drawing.Point(194, 278);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(481, 23);
            this.DeleteRowBtn.TabIndex = 8;
            this.DeleteRowBtn.Text = "Excluir linha atual";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // EditRowBtn
            // 
            this.EditRowBtn.Location = new System.Drawing.Point(681, 278);
            this.EditRowBtn.Name = "EditRowBtn";
            this.EditRowBtn.Size = new System.Drawing.Size(107, 23);
            this.EditRowBtn.TabIndex = 9;
            this.EditRowBtn.Text = "Editar linha";
            this.EditRowBtn.UseVisualStyleBackColor = true;
            this.EditRowBtn.Click += new System.EventHandler(this.EditRowBtn_Click);
            // 
            // SearchTbx
            // 
            this.SearchTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchTbx.Location = new System.Drawing.Point(194, 12);
            this.SearchTbx.Name = "SearchTbx";
            this.SearchTbx.Size = new System.Drawing.Size(594, 20);
            this.SearchTbx.TabIndex = 10;
            this.SearchTbx.TextChanged += new System.EventHandler(this.SearchTbx_TextChanged);
            // 
            // DisciplinasEntidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.SearchTbx);
            this.Controls.Add(this.EditRowBtn);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.IdNud);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.isAtivoChk);
            this.Controls.Add(this.SiglaTbx);
            this.Controls.Add(this.NomeTbx);
            this.Controls.Add(this.label1);
            this.Name = "DisciplinasEntidade";
            this.Text = "Disciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTbx;
        private System.Windows.Forms.TextBox SiglaTbx;
        private System.Windows.Forms.CheckBox isAtivoChk;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.NumericUpDown IdNud;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Button EditRowBtn;
        private System.Windows.Forms.TextBox SearchTbx;
    }
}