namespace FormApp
{
    partial class IngresoUsuario
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
            this.txtBox_Nombre = new System.Windows.Forms.TextBox();
            this.txtBox_Apellido = new System.Windows.Forms.TextBox();
            this.txtBox_NewUserDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_DNI = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Si no tienes usuario , registrate por favor !";
            // 
            // txtBox_Nombre
            // 
            this.txtBox_Nombre.Location = new System.Drawing.Point(12, 117);
            this.txtBox_Nombre.Name = "txtBox_Nombre";
            this.txtBox_Nombre.PlaceholderText = "Ingresá tu nombre";
            this.txtBox_Nombre.Size = new System.Drawing.Size(224, 23);
            this.txtBox_Nombre.TabIndex = 1;
            // 
            // txtBox_Apellido
            // 
            this.txtBox_Apellido.Location = new System.Drawing.Point(12, 164);
            this.txtBox_Apellido.Name = "txtBox_Apellido";
            this.txtBox_Apellido.PlaceholderText = "Ingresá tu apellido";
            this.txtBox_Apellido.Size = new System.Drawing.Size(224, 23);
            this.txtBox_Apellido.TabIndex = 2;
            // 
            // txtBox_NewUserDni
            // 
            this.txtBox_NewUserDni.Location = new System.Drawing.Point(12, 214);
            this.txtBox_NewUserDni.Name = "txtBox_NewUserDni";
            this.txtBox_NewUserDni.PlaceholderText = "Ingresa tu DNI";
            this.txtBox_NewUserDni.Size = new System.Drawing.Size(224, 23);
            this.txtBox_NewUserDni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Si ya reservaste tu lugar , por favor ingresa con tu DNI !";
            // 
            // txtBox_DNI
            // 
            this.txtBox_DNI.Location = new System.Drawing.Point(294, 164);
            this.txtBox_DNI.Name = "txtBox_DNI";
            this.txtBox_DNI.PlaceholderText = "Ingresa tu DNI";
            this.txtBox_DNI.Size = new System.Drawing.Size(224, 23);
            this.txtBox_DNI.TabIndex = 5;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(76, 257);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 6;
            this.btn_SignUp.Text = "Registrarse";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(372, 257);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 7;
            this.btn_Enter.Text = "Ingresar";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // IngresoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 306);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txtBox_DNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_NewUserDni);
            this.Controls.Add(this.txtBox_Apellido);
            this.Controls.Add(this.txtBox_Nombre);
            this.Controls.Add(this.label1);
            this.Name = "IngresoUsuario";
            this.Text = "IngresoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Nombre;
        private System.Windows.Forms.TextBox txtBox_Apellido;
        private System.Windows.Forms.TextBox txtBox_NewUserDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_DNI;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_Enter;
    }
}