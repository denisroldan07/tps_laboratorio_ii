
namespace FormApp
{
    partial class BuscarPasajero
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
            this.txtBox_DNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscarPasajero = new System.Windows.Forms.Button();
            this.txtBox_IdVuelo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_DNI
            // 
            this.txtBox_DNI.Location = new System.Drawing.Point(126, 49);
            this.txtBox_DNI.Name = "txtBox_DNI";
            this.txtBox_DNI.PlaceholderText = "Ingresar DNI";
            this.txtBox_DNI.Size = new System.Drawing.Size(275, 23);
            this.txtBox_DNI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar pasajero:";
            // 
            // btn_BuscarPasajero
            // 
            this.btn_BuscarPasajero.Location = new System.Drawing.Point(126, 107);
            this.btn_BuscarPasajero.Name = "btn_BuscarPasajero";
            this.btn_BuscarPasajero.Size = new System.Drawing.Size(275, 23);
            this.btn_BuscarPasajero.TabIndex = 2;
            this.btn_BuscarPasajero.Text = "Buscar pasajero";
            this.btn_BuscarPasajero.UseVisualStyleBackColor = true;
            this.btn_BuscarPasajero.Click += new System.EventHandler(this.btn_BuscarPasajero_Click);
            // 
            // txtBox_IdVuelo
            // 
            this.txtBox_IdVuelo.Location = new System.Drawing.Point(126, 78);
            this.txtBox_IdVuelo.Name = "txtBox_IdVuelo";
            this.txtBox_IdVuelo.PlaceholderText = "Ingrese numero de vuelo";
            this.txtBox_IdVuelo.Size = new System.Drawing.Size(275, 23);
            this.txtBox_IdVuelo.TabIndex = 1;
            // 
            // BuscarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.txtBox_IdVuelo);
            this.Controls.Add(this.btn_BuscarPasajero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_DNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarPasajero";
            this.Text = "BuscarPasajero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_DNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BuscarPasajero;
        private System.Windows.Forms.TextBox txtBox_IdVuelo;
    }
}