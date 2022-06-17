
namespace FormApp
{
    partial class ModificarPasajero
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
            this.lstBox_Avion1 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion2 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion3 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion4 = new System.Windows.Forms.ListBox();
            this.btn_Modificar1 = new System.Windows.Forms.Button();
            this.btn_Modificar2 = new System.Windows.Forms.Button();
            this.btn_Modificar3 = new System.Windows.Forms.Button();
            this.btn_Modificar4 = new System.Windows.Forms.Button();
            this.txtBox_DNI = new System.Windows.Forms.TextBox();
            this.txtBox_Apellido = new System.Windows.Forms.TextBox();
            this.txtBox_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_AceptarCambios = new System.Windows.Forms.Button();
            this.dgv_Pasajeros = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_AsientosLibres = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBox_Avion1
            // 
            this.lstBox_Avion1.FormattingEnabled = true;
            this.lstBox_Avion1.ItemHeight = 15;
            this.lstBox_Avion1.Location = new System.Drawing.Point(12, 12);
            this.lstBox_Avion1.Name = "lstBox_Avion1";
            this.lstBox_Avion1.Size = new System.Drawing.Size(129, 139);
            this.lstBox_Avion1.TabIndex = 9;
            // 
            // lstBox_Avion2
            // 
            this.lstBox_Avion2.FormattingEnabled = true;
            this.lstBox_Avion2.ItemHeight = 15;
            this.lstBox_Avion2.Location = new System.Drawing.Point(147, 12);
            this.lstBox_Avion2.Name = "lstBox_Avion2";
            this.lstBox_Avion2.Size = new System.Drawing.Size(129, 139);
            this.lstBox_Avion2.TabIndex = 10;
            // 
            // lstBox_Avion3
            // 
            this.lstBox_Avion3.FormattingEnabled = true;
            this.lstBox_Avion3.ItemHeight = 15;
            this.lstBox_Avion3.Location = new System.Drawing.Point(282, 12);
            this.lstBox_Avion3.Name = "lstBox_Avion3";
            this.lstBox_Avion3.Size = new System.Drawing.Size(129, 139);
            this.lstBox_Avion3.TabIndex = 11;
            // 
            // lstBox_Avion4
            // 
            this.lstBox_Avion4.FormattingEnabled = true;
            this.lstBox_Avion4.ItemHeight = 15;
            this.lstBox_Avion4.Location = new System.Drawing.Point(417, 12);
            this.lstBox_Avion4.Name = "lstBox_Avion4";
            this.lstBox_Avion4.Size = new System.Drawing.Size(129, 139);
            this.lstBox_Avion4.TabIndex = 12;
            // 
            // btn_Modificar1
            // 
            this.btn_Modificar1.Location = new System.Drawing.Point(12, 157);
            this.btn_Modificar1.Name = "btn_Modificar1";
            this.btn_Modificar1.Size = new System.Drawing.Size(129, 31);
            this.btn_Modificar1.TabIndex = 13;
            this.btn_Modificar1.Text = "Modificar vuelo\r\n";
            this.btn_Modificar1.UseVisualStyleBackColor = true;
            this.btn_Modificar1.Click += new System.EventHandler(this.btn_Modificar1_Click);
            // 
            // btn_Modificar2
            // 
            this.btn_Modificar2.Location = new System.Drawing.Point(147, 157);
            this.btn_Modificar2.Name = "btn_Modificar2";
            this.btn_Modificar2.Size = new System.Drawing.Size(129, 31);
            this.btn_Modificar2.TabIndex = 14;
            this.btn_Modificar2.Text = "Modificar vuelo\r\n";
            this.btn_Modificar2.UseVisualStyleBackColor = true;
            this.btn_Modificar2.Click += new System.EventHandler(this.btn_Modificar2_Click);
            // 
            // btn_Modificar3
            // 
            this.btn_Modificar3.Location = new System.Drawing.Point(282, 157);
            this.btn_Modificar3.Name = "btn_Modificar3";
            this.btn_Modificar3.Size = new System.Drawing.Size(129, 31);
            this.btn_Modificar3.TabIndex = 15;
            this.btn_Modificar3.Text = "Modificar vuelo\r\n";
            this.btn_Modificar3.UseVisualStyleBackColor = true;
            this.btn_Modificar3.Click += new System.EventHandler(this.btn_Modificar3_Click);
            // 
            // btn_Modificar4
            // 
            this.btn_Modificar4.Location = new System.Drawing.Point(416, 157);
            this.btn_Modificar4.Name = "btn_Modificar4";
            this.btn_Modificar4.Size = new System.Drawing.Size(129, 31);
            this.btn_Modificar4.TabIndex = 16;
            this.btn_Modificar4.Text = "Modificar vuelo\r\n";
            this.btn_Modificar4.UseVisualStyleBackColor = true;
            this.btn_Modificar4.Click += new System.EventHandler(this.btn_Modificar4_Click);
            // 
            // txtBox_DNI
            // 
            this.txtBox_DNI.Location = new System.Drawing.Point(416, 204);
            this.txtBox_DNI.Name = "txtBox_DNI";
            this.txtBox_DNI.PlaceholderText = "Ingrese DNI";
            this.txtBox_DNI.Size = new System.Drawing.Size(129, 23);
            this.txtBox_DNI.TabIndex = 20;
            // 
            // txtBox_Apellido
            // 
            this.txtBox_Apellido.Location = new System.Drawing.Point(417, 262);
            this.txtBox_Apellido.Name = "txtBox_Apellido";
            this.txtBox_Apellido.PlaceholderText = "Ingrese apellido";
            this.txtBox_Apellido.Size = new System.Drawing.Size(129, 23);
            this.txtBox_Apellido.TabIndex = 19;
            // 
            // txtBox_Nombre
            // 
            this.txtBox_Nombre.Location = new System.Drawing.Point(417, 233);
            this.txtBox_Nombre.Name = "txtBox_Nombre";
            this.txtBox_Nombre.PlaceholderText = "Ingrese nombre";
            this.txtBox_Nombre.Size = new System.Drawing.Size(129, 23);
            this.txtBox_Nombre.TabIndex = 18;
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(12, 360);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(398, 23);
            this.btn_Atras.TabIndex = 22;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_AceptarCambios
            // 
            this.btn_AceptarCambios.Location = new System.Drawing.Point(417, 331);
            this.btn_AceptarCambios.Name = "btn_AceptarCambios";
            this.btn_AceptarCambios.Size = new System.Drawing.Size(129, 23);
            this.btn_AceptarCambios.TabIndex = 23;
            this.btn_AceptarCambios.Text = "Aceptar cambios";
            this.btn_AceptarCambios.UseVisualStyleBackColor = true;
            this.btn_AceptarCambios.Click += new System.EventHandler(this.btn_AceptarCambios_Click);
            // 
            // dgv_Pasajeros
            // 
            this.dgv_Pasajeros.AllowUserToResizeColumns = false;
            this.dgv_Pasajeros.AllowUserToResizeRows = false;
            this.dgv_Pasajeros.AutoGenerateColumns = false;
            this.dgv_Pasajeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.idAsientoDataGridViewTextBoxColumn});
            this.dgv_Pasajeros.DataSource = this.pasajeroBindingSource;
            this.dgv_Pasajeros.Location = new System.Drawing.Point(12, 204);
            this.dgv_Pasajeros.Name = "dgv_Pasajeros";
            this.dgv_Pasajeros.RowHeadersVisible = false;
            this.dgv_Pasajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Pasajeros.RowTemplate.Height = 25;
            this.dgv_Pasajeros.RowTemplate.ReadOnly = true;
            this.dgv_Pasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pasajeros.Size = new System.Drawing.Size(398, 150);
            this.dgv_Pasajeros.TabIndex = 24;
            this.dgv_Pasajeros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pasajeros_CellDoubleClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // idAsientoDataGridViewTextBoxColumn
            // 
            this.idAsientoDataGridViewTextBoxColumn.DataPropertyName = "IdAsiento";
            this.idAsientoDataGridViewTextBoxColumn.HeaderText = "IdAsiento";
            this.idAsientoDataGridViewTextBoxColumn.Name = "idAsientoDataGridViewTextBoxColumn";
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Entidades.Pasajero);
            // 
            // cmb_AsientosLibres
            // 
            this.cmb_AsientosLibres.FormattingEnabled = true;
            this.cmb_AsientosLibres.Location = new System.Drawing.Point(416, 290);
            this.cmb_AsientosLibres.Name = "cmb_AsientosLibres";
            this.cmb_AsientosLibres.Size = new System.Drawing.Size(129, 23);
            this.cmb_AsientosLibres.TabIndex = 25;
            // 
            // ModificarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.cmb_AsientosLibres);
            this.Controls.Add(this.dgv_Pasajeros);
            this.Controls.Add(this.btn_AceptarCambios);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.txtBox_DNI);
            this.Controls.Add(this.txtBox_Apellido);
            this.Controls.Add(this.txtBox_Nombre);
            this.Controls.Add(this.btn_Modificar4);
            this.Controls.Add(this.btn_Modificar3);
            this.Controls.Add(this.btn_Modificar2);
            this.Controls.Add(this.btn_Modificar1);
            this.Controls.Add(this.lstBox_Avion4);
            this.Controls.Add(this.lstBox_Avion3);
            this.Controls.Add(this.lstBox_Avion2);
            this.Controls.Add(this.lstBox_Avion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarPasajero";
            this.Text = "ModificarPasajero";
            this.Load += new System.EventHandler(this.ModificarPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Avion1;
        private System.Windows.Forms.ListBox lstBox_Avion2;
        private System.Windows.Forms.ListBox lstBox_Avion3;
        private System.Windows.Forms.ListBox lstBox_Avion4;
        private System.Windows.Forms.Button btn_Modificar1;
        private System.Windows.Forms.Button btn_Modificar2;
        private System.Windows.Forms.Button btn_Modificar3;
        private System.Windows.Forms.Button btn_Modificar4;
        private System.Windows.Forms.TextBox txtBox_DNI;
        private System.Windows.Forms.TextBox txtBox_Apellido;
        private System.Windows.Forms.TextBox txtBox_Nombre;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_AceptarCambios;
        private System.Windows.Forms.DataGridView dgv_Pasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pasajeroBindingSource;
        private System.Windows.Forms.ComboBox cmb_AsientosLibres;
    }
}