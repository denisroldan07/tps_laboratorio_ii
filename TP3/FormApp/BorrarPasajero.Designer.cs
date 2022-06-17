
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
            this.components = new System.ComponentModel.Container();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_EliminarPasajero = new System.Windows.Forms.Button();
            this.btn_Eliminar4 = new System.Windows.Forms.Button();
            this.btn_Eliminar3 = new System.Windows.Forms.Button();
            this.btn_Eliminar2 = new System.Windows.Forms.Button();
            this.btn_Eliminar1 = new System.Windows.Forms.Button();
            this.lstBox_Avion4 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion3 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion2 = new System.Windows.Forms.ListBox();
            this.lstBox_Avion1 = new System.Windows.Forms.ListBox();
            this.dgv_Pasajeros = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(12, 393);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(534, 23);
            this.btn_Atras.TabIndex = 34;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_EliminarPasajero
            // 
            this.btn_EliminarPasajero.Location = new System.Drawing.Point(12, 364);
            this.btn_EliminarPasajero.Name = "btn_EliminarPasajero";
            this.btn_EliminarPasajero.Size = new System.Drawing.Size(534, 23);
            this.btn_EliminarPasajero.TabIndex = 33;
            this.btn_EliminarPasajero.Text = "Eliminar pasajero";
            this.btn_EliminarPasajero.UseVisualStyleBackColor = true;
            this.btn_EliminarPasajero.Click += new System.EventHandler(this.btn_EliminarPasajero_Click);
            // 
            // btn_Eliminar4
            // 
            this.btn_Eliminar4.Location = new System.Drawing.Point(416, 157);
            this.btn_Eliminar4.Name = "btn_Eliminar4";
            this.btn_Eliminar4.Size = new System.Drawing.Size(130, 31);
            this.btn_Eliminar4.TabIndex = 30;
            this.btn_Eliminar4.Text = "Eliminar un pasajero";
            this.btn_Eliminar4.UseVisualStyleBackColor = true;
            this.btn_Eliminar4.Click += new System.EventHandler(this.btn_Eliminar4_Click);
            // 
            // btn_Eliminar3
            // 
            this.btn_Eliminar3.Location = new System.Drawing.Point(282, 157);
            this.btn_Eliminar3.Name = "btn_Eliminar3";
            this.btn_Eliminar3.Size = new System.Drawing.Size(129, 31);
            this.btn_Eliminar3.TabIndex = 29;
            this.btn_Eliminar3.Text = "Eliminar un pasajero";
            this.btn_Eliminar3.UseVisualStyleBackColor = true;
            this.btn_Eliminar3.Click += new System.EventHandler(this.btn_Eliminar3_Click);
            // 
            // btn_Eliminar2
            // 
            this.btn_Eliminar2.Location = new System.Drawing.Point(147, 157);
            this.btn_Eliminar2.Name = "btn_Eliminar2";
            this.btn_Eliminar2.Size = new System.Drawing.Size(129, 31);
            this.btn_Eliminar2.TabIndex = 28;
            this.btn_Eliminar2.Text = "Eliminar un pasajero";
            this.btn_Eliminar2.UseVisualStyleBackColor = true;
            this.btn_Eliminar2.Click += new System.EventHandler(this.btn_Eliminar2_Click);
            // 
            // btn_Eliminar1
            // 
            this.btn_Eliminar1.Location = new System.Drawing.Point(12, 157);
            this.btn_Eliminar1.Name = "btn_Eliminar1";
            this.btn_Eliminar1.Size = new System.Drawing.Size(129, 31);
            this.btn_Eliminar1.TabIndex = 27;
            this.btn_Eliminar1.Text = "Eliminar un pasajero";
            this.btn_Eliminar1.UseVisualStyleBackColor = true;
            this.btn_Eliminar1.Click += new System.EventHandler(this.btn_Eliminar1_Click);
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
            // dgv_Pasajeros
            // 
            this.dgv_Pasajeros.AllowUserToResizeColumns = false;
            this.dgv_Pasajeros.AllowUserToResizeRows = false;
            this.dgv_Pasajeros.AutoGenerateColumns = false;
            this.dgv_Pasajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Pasajeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.idAsientoDataGridViewTextBoxColumn});
            this.dgv_Pasajeros.DataSource = this.pasajeroBindingSource;
            this.dgv_Pasajeros.Location = new System.Drawing.Point(12, 208);
            this.dgv_Pasajeros.Name = "dgv_Pasajeros";
            this.dgv_Pasajeros.RowHeadersVisible = false;
            this.dgv_Pasajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Pasajeros.RowTemplate.Height = 25;
            this.dgv_Pasajeros.RowTemplate.ReadOnly = true;
            this.dgv_Pasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pasajeros.Size = new System.Drawing.Size(534, 150);
            this.dgv_Pasajeros.TabIndex = 35;
            this.dgv_Pasajeros.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Pasajeros_CellMouseClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn.Width = 150;
            // 
            // idAsientoDataGridViewTextBoxColumn
            // 
            this.idAsientoDataGridViewTextBoxColumn.DataPropertyName = "IdAsiento";
            this.idAsientoDataGridViewTextBoxColumn.HeaderText = "IdAsiento";
            this.idAsientoDataGridViewTextBoxColumn.Name = "idAsientoDataGridViewTextBoxColumn";
            this.idAsientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsientoDataGridViewTextBoxColumn.Width = 140;
            // 
            // pasajeroBindingSource
            // 
            this.pasajeroBindingSource.DataSource = typeof(Entidades.Pasajero);
            // 
            // BorrarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.dgv_Pasajeros);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_EliminarPasajero);
            this.Controls.Add(this.btn_Eliminar4);
            this.Controls.Add(this.btn_Eliminar3);
            this.Controls.Add(this.btn_Eliminar2);
            this.Controls.Add(this.btn_Eliminar1);
            this.Controls.Add(this.lstBox_Avion4);
            this.Controls.Add(this.lstBox_Avion3);
            this.Controls.Add(this.lstBox_Avion2);
            this.Controls.Add(this.lstBox_Avion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrarPasajero";
            this.Text = "BorrarPasajero";
            this.Load += new System.EventHandler(this.BorrarPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_EliminarPasajero;
        private System.Windows.Forms.Button btn_Eliminar4;
        private System.Windows.Forms.Button btn_Eliminar3;
        private System.Windows.Forms.Button btn_Eliminar2;
        private System.Windows.Forms.Button btn_Eliminar1;
        private System.Windows.Forms.ListBox lstBox_Avion4;
        private System.Windows.Forms.ListBox lstBox_Avion3;
        private System.Windows.Forms.ListBox lstBox_Avion2;
        private System.Windows.Forms.ListBox lstBox_Avion1;
        private System.Windows.Forms.DataGridView dgv_Pasajeros;
        private System.Windows.Forms.BindingSource pasajeroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsientoDataGridViewTextBoxColumn;
    }
}