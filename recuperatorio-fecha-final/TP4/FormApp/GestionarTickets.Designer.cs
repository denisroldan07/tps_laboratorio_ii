namespace FormApp
{
    partial class GestionarTickets
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Tickets = new System.Windows.Forms.DataGridView();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAvionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_EliminarTicket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion tickets";
            // 
            // dgv_Tickets
            // 
            this.dgv_Tickets.AutoGenerateColumns = false;
            this.dgv_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.asientoDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.idAvionDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgv_Tickets.DataSource = this.ticketsBindingSource;
            this.dgv_Tickets.Location = new System.Drawing.Point(12, 42);
            this.dgv_Tickets.Name = "dgv_Tickets";
            this.dgv_Tickets.ReadOnly = true;
            this.dgv_Tickets.RowHeadersVisible = false;
            this.dgv_Tickets.RowTemplate.Height = 25;
            this.dgv_Tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Tickets.Size = new System.Drawing.Size(528, 306);
            this.dgv_Tickets.TabIndex = 1;
            this.dgv_Tickets.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Tickets_CellMouseClick);
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn.Width = 76;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 76;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 76;
            // 
            // asientoDataGridViewTextBoxColumn
            // 
            this.asientoDataGridViewTextBoxColumn.DataPropertyName = "Asiento";
            this.asientoDataGridViewTextBoxColumn.HeaderText = "Asiento";
            this.asientoDataGridViewTextBoxColumn.Name = "asientoDataGridViewTextBoxColumn";
            this.asientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.asientoDataGridViewTextBoxColumn.Width = 76;
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            this.destinoDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinoDataGridViewTextBoxColumn.Width = 76;
            // 
            // idAvionDataGridViewTextBoxColumn
            // 
            this.idAvionDataGridViewTextBoxColumn.DataPropertyName = "IdAvion";
            this.idAvionDataGridViewTextBoxColumn.HeaderText = "IdAvion";
            this.idAvionDataGridViewTextBoxColumn.Name = "idAvionDataGridViewTextBoxColumn";
            this.idAvionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAvionDataGridViewTextBoxColumn.Width = 76;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 76;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataSource = typeof(Entidades.Tickets);
            // 
            // btn_EliminarTicket
            // 
            this.btn_EliminarTicket.Location = new System.Drawing.Point(12, 354);
            this.btn_EliminarTicket.Name = "btn_EliminarTicket";
            this.btn_EliminarTicket.Size = new System.Drawing.Size(528, 29);
            this.btn_EliminarTicket.TabIndex = 2;
            this.btn_EliminarTicket.Text = "Eliminar ticket";
            this.btn_EliminarTicket.UseVisualStyleBackColor = true;
            this.btn_EliminarTicket.Click += new System.EventHandler(this.btn_EliminarTicket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(140, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // GestionarTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_EliminarTicket);
            this.Controls.Add(this.dgv_Tickets);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "GestionarTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarTickets";
            this.Load += new System.EventHandler(this.GestionarTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Tickets;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private System.Windows.Forms.Button btn_EliminarTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAvionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}