
namespace Formulario
{
    partial class Professores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professores));
            this.label1 = new System.Windows.Forms.Label();
            this.NomeEbx = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApelidoTbxx = new System.Windows.Forms.TextBox();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SearchTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NomeEbx
            // 
            resources.ApplyResources(this.NomeEbx, "NomeEbx");
            this.NomeEbx.Name = "NomeEbx";
            this.NomeEbx.Enter += new System.EventHandler(this.NomeEbx_Enter);
            this.NomeEbx.Leave += new System.EventHandler(this.NomeEb_Leave);
            // 
            // ClearBtn
            // 
            resources.ApplyResources(this.ClearBtn, "ClearBtn");
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RegisterBtn
            // 
            resources.ApplyResources(this.RegisterBtn, "RegisterBtn");
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Table, "Table");
            this.Table.Name = "Table";
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridProfessores_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Name = "panel1";
            // 
            // ApelidoTbxx
            // 
            resources.ApplyResources(this.ApelidoTbxx, "ApelidoTbxx");
            this.ApelidoTbxx.Name = "ApelidoTbxx";
            this.ApelidoTbxx.Enter += new System.EventHandler(this.ApelidoTbxx_Enter);
            this.ApelidoTbxx.Leave += new System.EventHandler(this.ApelidoTbxx_Leave);
            // 
            // DeleteRowBtn
            // 
            resources.ApplyResources(this.DeleteRowBtn, "DeleteRowBtn");
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // EditBtn
            // 
            resources.ApplyResources(this.EditBtn, "EditBtn");
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SearchTbx
            // 
            resources.ApplyResources(this.SearchTbx, "SearchTbx");
            this.SearchTbx.Name = "SearchTbx";
            this.SearchTbx.TextChanged += new System.EventHandler(this.SearchTbx_TextChanged);
            // 
            // Professores
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchTbx);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.ApelidoTbxx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.NomeEbx);
            this.Name = "Professores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeEbx;
        
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ApelidoTbxx;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox SearchTbx;
    }
}