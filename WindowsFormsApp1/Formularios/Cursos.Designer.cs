
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
            this.components = new System.ComponentModel.Container();
            this.Table = new System.Windows.Forms.DataGridView();
            this.NomeTbx = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SearchTbx = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SiglaTbx = new System.Windows.Forms.TextBox();
            this.TurnoTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AtivoChk = new System.Windows.Forms.CheckBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.IdNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(230, 41);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(402, 327);
            this.Table.TabIndex = 0;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // NomeTbx
            // 
            this.NomeTbx.Location = new System.Drawing.Point(68, 53);
            this.NomeTbx.Name = "NomeTbx";
            this.NomeTbx.Size = new System.Drawing.Size(109, 20);
            this.NomeTbx.TabIndex = 1;
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
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.Location = new System.Drawing.Point(230, 374);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(293, 23);
            this.DeleteRowBtn.TabIndex = 11;
            this.DeleteRowBtn.Text = "Deletar Linha {}";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(529, 374);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 23);
            this.EditBtn.TabIndex = 12;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SearchTbx
            // 
            this.SearchTbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchTbx.Location = new System.Drawing.Point(230, 15);
            this.SearchTbx.Name = "SearchTbx";
            this.SearchTbx.Size = new System.Drawing.Size(402, 20);
            this.SearchTbx.TabIndex = 14;
            this.SearchTbx.TextChanged += new System.EventHandler(this.SearchTbx_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SiglaTbx
            // 
            this.SiglaTbx.Location = new System.Drawing.Point(68, 79);
            this.SiglaTbx.Name = "SiglaTbx";
            this.SiglaTbx.Size = new System.Drawing.Size(109, 20);
            this.SiglaTbx.TabIndex = 15;
            // 
            // TurnoTbx
            // 
            this.TurnoTbx.Location = new System.Drawing.Point(68, 106);
            this.TurnoTbx.Name = "TurnoTbx";
            this.TurnoTbx.Size = new System.Drawing.Size(109, 20);
            this.TurnoTbx.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sigla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Turno";
            // 
            // AtivoChk
            // 
            this.AtivoChk.AutoSize = true;
            this.AtivoChk.Location = new System.Drawing.Point(15, 134);
            this.AtivoChk.Name = "AtivoChk";
            this.AtivoChk.Size = new System.Drawing.Size(50, 17);
            this.AtivoChk.TabIndex = 20;
            this.AtivoChk.Text = "Ativo";
            this.AtivoChk.UseVisualStyleBackColor = true;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(12, 30);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(16, 13);
            this.IdLbl.TabIndex = 22;
            this.IdLbl.Text = "Id";
            // 
            // IdNUD
            // 
            this.IdNUD.InterceptArrowKeys = false;
            this.IdNUD.Location = new System.Drawing.Point(68, 30);
            this.IdNUD.Name = "IdNUD";
            this.IdNUD.ReadOnly = true;
            this.IdNUD.Size = new System.Drawing.Size(109, 20);
            this.IdNUD.TabIndex = 23;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 513);
            this.Controls.Add(this.IdNUD);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.AtivoChk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TurnoTbx);
            this.Controls.Add(this.SiglaTbx);
            this.Controls.Add(this.SearchTbx);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.NomeTbx);
            this.Controls.Add(this.Table);
            this.Name = "Cursos";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox NomeTbx;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox SearchTbx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox SiglaTbx;
        private System.Windows.Forms.TextBox TurnoTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AtivoChk;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.NumericUpDown IdNUD;
    }
}