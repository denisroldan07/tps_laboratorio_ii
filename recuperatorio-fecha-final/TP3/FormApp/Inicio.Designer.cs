
namespace FormApp
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSide = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_EliminarPasajero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ModificarPasajero = new System.Windows.Forms.Button();
            this.btn_BuscarPasajero = new System.Windows.Forms.Button();
            this.btn_CargarPasajero = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.DimGray;
            this.panelSide.Controls.Add(this.btn_Salir);
            this.panelSide.Controls.Add(this.btn_EliminarPasajero);
            this.panelSide.Controls.Add(this.pictureBox1);
            this.panelSide.Controls.Add(this.btn_ModificarPasajero);
            this.panelSide.Controls.Add(this.btn_BuscarPasajero);
            this.panelSide.Controls.Add(this.btn_CargarPasajero);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 30);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(220, 425);
            this.panelSide.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(0, 382);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(220, 40);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_EliminarPasajero
            // 
            this.btn_EliminarPasajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_EliminarPasajero.FlatAppearance.BorderSize = 0;
            this.btn_EliminarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarPasajero.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EliminarPasajero.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarPasajero.Location = new System.Drawing.Point(0, 270);
            this.btn_EliminarPasajero.Name = "btn_EliminarPasajero";
            this.btn_EliminarPasajero.Size = new System.Drawing.Size(220, 40);
            this.btn_EliminarPasajero.TabIndex = 3;
            this.btn_EliminarPasajero.Text = "Borrar pasajero";
            this.btn_EliminarPasajero.UseVisualStyleBackColor = true;
            this.btn_EliminarPasajero.Click += new System.EventHandler(this.btn_EliminarPasajero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FormApp.Properties.Resources.avion2;
            this.pictureBox1.Location = new System.Drawing.Point(47, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ModificarPasajero
            // 
            this.btn_ModificarPasajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ModificarPasajero.FlatAppearance.BorderSize = 0;
            this.btn_ModificarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarPasajero.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ModificarPasajero.ForeColor = System.Drawing.Color.White;
            this.btn_ModificarPasajero.Location = new System.Drawing.Point(0, 224);
            this.btn_ModificarPasajero.Name = "btn_ModificarPasajero";
            this.btn_ModificarPasajero.Size = new System.Drawing.Size(220, 40);
            this.btn_ModificarPasajero.TabIndex = 2;
            this.btn_ModificarPasajero.Text = "Modificar pasajero\r\n";
            this.btn_ModificarPasajero.UseVisualStyleBackColor = true;
            this.btn_ModificarPasajero.Click += new System.EventHandler(this.btn_ModificarPasajero_Click);
            // 
            // btn_BuscarPasajero
            // 
            this.btn_BuscarPasajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_BuscarPasajero.FlatAppearance.BorderSize = 0;
            this.btn_BuscarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarPasajero.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarPasajero.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarPasajero.Location = new System.Drawing.Point(0, 178);
            this.btn_BuscarPasajero.Name = "btn_BuscarPasajero";
            this.btn_BuscarPasajero.Size = new System.Drawing.Size(220, 40);
            this.btn_BuscarPasajero.TabIndex = 1;
            this.btn_BuscarPasajero.Text = "Buscar pasajero";
            this.btn_BuscarPasajero.UseVisualStyleBackColor = true;
            this.btn_BuscarPasajero.Click += new System.EventHandler(this.btn_BuscarPasajero_Click);
            // 
            // btn_CargarPasajero
            // 
            this.btn_CargarPasajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CargarPasajero.FlatAppearance.BorderSize = 0;
            this.btn_CargarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarPasajero.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarPasajero.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CargarPasajero.Location = new System.Drawing.Point(0, 132);
            this.btn_CargarPasajero.Name = "btn_CargarPasajero";
            this.btn_CargarPasajero.Size = new System.Drawing.Size(220, 40);
            this.btn_CargarPasajero.TabIndex = 0;
            this.btn_CargarPasajero.Text = "Cargar pasajero";
            this.btn_CargarPasajero.UseVisualStyleBackColor = true;
            this.btn_CargarPasajero.Click += new System.EventHandler(this.btn_CargarPasajero_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkGray;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.btn_Cerrar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(777, 30);
            this.panelHeader.TabIndex = 1;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cerrar.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Location = new System.Drawing.Point(747, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.Text = "X";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(557, 425);
            this.panelMain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion de pasajeros - Denis Roldan 2A";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 455);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btn_ModificarPasajero;
        private System.Windows.Forms.Button btn_BuscarPasajero;
        private System.Windows.Forms.Button btn_CargarPasajero;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_EliminarPasajero;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
    }
}

