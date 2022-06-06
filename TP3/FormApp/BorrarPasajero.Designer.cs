
namespace FormApp
{
    partial class BorrarPasajero
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
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_EliminarPasajero = new System.Windows.Forms.Button();
            this.txtBox_DNI = new System.Windows.Forms.TextBox();
            this.lstBox_Pasajeros = new System.Windows.Forms.ListBox();
            this.btn_Modificar4 = new System.Windows.Forms.Button();
            this.btn_Modificar3 = new System.Windows.Forms.Button();
            this.btn_Modificar2 = new System.Windows.Forms.Button();
            this.btn_Modificar1 = new System.Windows.Forms.Button();
            this.lstBox_Avion4 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion3 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion2 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(12, 393);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(316, 23);
            this.btn_Atras.TabIndex = 34;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarPasajero
            // 
            this.btn_EliminarPasajero.Location = new System.Drawing.Point(373, 301);
            this.btn_EliminarPasajero.Name = "btn_EliminarPasajero";
            this.btn_EliminarPasajero.Size = new System.Drawing.Size(129, 23);
            this.btn_EliminarPasajero.TabIndex = 33;
            this.btn_EliminarPasajero.Text = "Eliminar pasajero";
            this.btn_EliminarPasajero.UseVisualStyleBackColor = true;
            this.btn_EliminarPasajero.Click += new System.EventHandler(this.btn_EliminarPasajero_Click);
            // 
            // txtBox_DNI
            // 
            this.txtBox_DNI.Location = new System.Drawing.Point(373, 272);
            this.txtBox_DNI.Name = "txtBox_DNI";
            this.txtBox_DNI.PlaceholderText = "Ingrese DNI";
            this.txtBox_DNI.Size = new System.Drawing.Size(129, 23);
            this.txtBox_DNI.TabIndex = 32;
            // 
            // lstBox_Pasajeros
            // 
            this.lstBox_Pasajeros.FormattingEnabled = true;
            this.lstBox_Pasajeros.ItemHeight = 15;
            this.lstBox_Pasajeros.Location = new System.Drawing.Point(12, 220);
            this.lstBox_Pasajeros.Name = "lstBox_Pasajeros";
            this.lstBox_Pasajeros.Size = new System.Drawing.Size(316, 154);
            this.lstBox_Pasajeros.TabIndex = 31;
            // 
            // btn_Modificar4
            // 
            this.btn_Modificar4.Location = new System.Drawing.Point(416, 157);
            this.btn_Modificar4.Name = "btn_Modificar4";
            this.btn_Modificar4.Size = new System.Drawing.Size(129, 31);
            this.btn_Modificar4.TabIndex = 30;
            this.btn_Modificar4.Text = "Eliminar un pasajero";
            this.btn_Modificar4.UseVisualStyleBackColor = true;
            this.btn_Modificar4.Click += new System.EventHandler(this.btn_Modificar4_Click);
            // 
            // btn_Modificar3
            // 
            this.btn_Modificar3.Location = new System.Drawing.Point(282, 157);
            this.btn_Modificar3.Name = "btn_Modificar3";
            this.btn_Modificar3.Size = new System.Drawing.Size(129, 31);
            this.btn_Modificar3.TabIndex = 29;
            this.btn_Modificar3.Text = "Eliminar un pasajero";
            this.btn_Modificar3.UseVisualStyleBackColor = true;
            this.btn_Modificar3.Click += new System.EventHandler(this.btn_Modificar3_Click);
            // 
            // btn_Modificar2
            // 
            this.btn_Modificar2.Location = new System.Drawing.Point(147, 157);
            this.btn_Modificar2.Name = "btn_Modificar2";
            this.btn_Modificar2.Size = new System.Drawing.Size(129, 31);
            this.btn_Modificar2.TabIndex = 28;
            this.btn_Modificar2.Text = "Eliminar un pasajero";
            this.btn_Modificar2.UseVisualStyleBackColor = true;
            this.btn_Modificar2.Click += new System.EventHandler(this.btn_Modificar2_Click);
            // 
            // btn_Modificar1
            // 
            this.btn_Modificar1.Location = new System.Drawing.Point(12, 157);
            this.btn_Modificar1.Name = "btn_Modificar1";
            this.btn_Modificar1.Size = new System.Drawing.Size(129, 31);
            this.btn_Modificar1.TabIndex = 27;
            this.btn_Modificar1.Text = "Eliminar un pasajero";
            this.btn_Modificar1.UseVisualStyleBackColor = true;
            this.btn_Modificar1.Click += new System.EventHandler(this.btn_Modificar1_Click);
            // 
            // lstBox_Avion4
            // 
            this.lstBox_Avion4.FormattingEnabled = true;
            this.lstBox_Avion4.ItemHeight = 15;
            this.lstBox_Avion4.Location = new System.Drawing.Point(417, 12);
            this.lstBox_Avion4.Name = "lstBox_Avion4";
            this.lstBox_Avion4.Size = new System.Drawing.Size(129, 139);
            this.lstBox_Avion4.TabIndex = 26;
            // 
            // lstBox_Avion3
            // 
            this.lstBox_Avion3.FormattingEnabled = true;
            this.lstBox_Avion3.ItemHeight = 15;
            this.lstBox_Avion3.Location = new System.Drawing.Point(282, 12);
            this.lstBox_Avion3.Name = "lstBox_Avion3";
            this.lstBox_Avion3.Size = new System.Drawing.Size(129, 139);
            this.lstBox_Avion3.TabIndex = 25;
            // 
            // lstBox_Avion2
            // 
            this.lstBox_Avion2.FormattingEnabled = true;
            this.lstBox_Avion2.ItemHeight = 15;
            this.lstBox_Avion2.Location = new System.Drawing.Point(147, 12);
            this.lstBox_Avion2.Name = "lstBox_Avion2";
            this.lstBox_Avion2.Size = new System.Drawing.Size(129, 139);
            this.lstBox_Avion2.TabIndex = 24;
            // 
            // lstBox_Avion1
            // 
            this.lstBox_Avion1.FormattingEnabled = true;
            this.lstBox_Avion1.ItemHeight = 15;
            this.lstBox_Avion1.Location = new System.Drawing.Point(12, 12);
            this.lstBox_Avion1.Name = "lstBox_Avion1";
            this.lstBox_Avion1.Size = new System.Drawing.Size(129, 139);
            this.lstBox_Avion1.TabIndex = 23;
            // 
            // BorrarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_EliminarPasajero);
            this.Controls.Add(this.txtBox_DNI);
            this.Controls.Add(this.lstBox_Pasajeros);
            this.Controls.Add(this.btn_Modificar4);
            this.Controls.Add(this.btn_Modificar3);
            this.Controls.Add(this.btn_Modificar2);
            this.Controls.Add(this.btn_Modificar1);
            this.Controls.Add(this.lstBox_Avion4);
            this.Controls.Add(this.lstBox_Avion3);
            this.Controls.Add(this.lstBox_Avion2);
            this.Controls.Add(this.lstBox_Avion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrarPasajero";
            this.Text = "BorrarPasajero";
            this.Load += new System.EventHandler(this.BorrarPasajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_EliminarPasajero;
        private System.Windows.Forms.TextBox txtBox_DNI;
        private System.Windows.Forms.ListBox lstBox_Pasajeros;
        private System.Windows.Forms.Button btn_Modificar4;
        private System.Windows.Forms.Button btn_Modificar3;
        private System.Windows.Forms.Button btn_Modificar2;
        private System.Windows.Forms.Button btn_Modificar1;
        private System.Windows.Forms.ListBox lstBox_Avion4;
        private System.Windows.Forms.ListBox lstBox_Avion3;
        private System.Windows.Forms.ListBox lstBox_Avion2;
        private System.Windows.Forms.ListBox lstBox_Avion1;
    }
}