
namespace WindowsFormsApp1
{
    partial class Main
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
            this.MainRegisterRoomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainRegisterRoomBtn
            // 
            this.MainRegisterRoomBtn.Location = new System.Drawing.Point(307, 298);
            this.MainRegisterRoomBtn.Name = "MainRegisterRoomBtn";
            this.MainRegisterRoomBtn.Size = new System.Drawing.Size(164, 54);
            this.MainRegisterRoomBtn.TabIndex = 0;
            this.MainRegisterRoomBtn.Text = "Cadastrar Salas";
            this.MainRegisterRoomBtn.UseVisualStyleBackColor = true;
            this.MainRegisterRoomBtn.Click += new System.EventHandler(this.MainRegisterRoomBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainRegisterRoomBtn);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainRegisterRoomBtn;
    }
}

