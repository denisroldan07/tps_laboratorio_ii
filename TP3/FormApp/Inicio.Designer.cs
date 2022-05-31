namespace FormApp
{
    partial class Inicio
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
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_User
            // 
            this.btn_User.Location = new System.Drawing.Point(134, 154);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(198, 23);
            this.btn_User.TabIndex = 0;
            this.btn_User.Text = "Ingresar como usuario";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(134, 196);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(198, 23);
            this.btn_Admin.TabIndex = 1;
            this.btn_Admin.Text = "Ingresar como administrador";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // Inicio
            // 
            this.ClientSize = new System.Drawing.Size(484, 372);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_User);
            this.Name = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Admin;
    }
}