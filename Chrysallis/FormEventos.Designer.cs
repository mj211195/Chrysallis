﻿namespace Chrysallis
{
    partial class FormEventos
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
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLimiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAsistentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEventos = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.labelHasta = new System.Windows.Forms.Label();
            this.labelDesde = new System.Windows.Forms.Label();
            this.buttonAgregarEvento = new AppDesktop.Button_WOC();
            this.pictureBoxLupa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEventos.AutoGenerateColumns = false;
            this.dataGridViewEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.fechaLimiteDataGridViewTextBoxColumn,
            this.numAsistentesDataGridViewTextBoxColumn,
            this.idcomunidadDataGridViewTextBoxColumn,
            this.asistirDataGridViewTextBoxColumn,
            this.comunidadesDataGridViewTextBoxColumn,
            this.documentosDataGridViewTextBoxColumn,
            this.notificacionesDataGridViewTextBoxColumn,
            this.Comunidad});
            this.dataGridViewEventos.DataSource = this.bindingSourceEventos;
            this.dataGridViewEventos.Location = new System.Drawing.Point(1, 84);
            this.dataGridViewEventos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEventos.Size = new System.Drawing.Size(948, 330);
            this.dataGridViewEventos.TabIndex = 0;
            this.dataGridViewEventos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEventos_CellFormatting);
            this.dataGridViewEventos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewEventos_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaLimiteDataGridViewTextBoxColumn
            // 
            this.fechaLimiteDataGridViewTextBoxColumn.DataPropertyName = "fechaLimite";
            this.fechaLimiteDataGridViewTextBoxColumn.HeaderText = "fechaLimite";
            this.fechaLimiteDataGridViewTextBoxColumn.Name = "fechaLimiteDataGridViewTextBoxColumn";
            this.fechaLimiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numAsistentesDataGridViewTextBoxColumn
            // 
            this.numAsistentesDataGridViewTextBoxColumn.DataPropertyName = "numAsistentes";
            this.numAsistentesDataGridViewTextBoxColumn.HeaderText = "numAsistentes";
            this.numAsistentesDataGridViewTextBoxColumn.Name = "numAsistentesDataGridViewTextBoxColumn";
            this.numAsistentesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcomunidadDataGridViewTextBoxColumn
            // 
            this.idcomunidadDataGridViewTextBoxColumn.DataPropertyName = "id_comunidad";
            this.idcomunidadDataGridViewTextBoxColumn.HeaderText = "id_comunidad";
            this.idcomunidadDataGridViewTextBoxColumn.Name = "idcomunidadDataGridViewTextBoxColumn";
            this.idcomunidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomunidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // asistirDataGridViewTextBoxColumn
            // 
            this.asistirDataGridViewTextBoxColumn.DataPropertyName = "asistir";
            this.asistirDataGridViewTextBoxColumn.HeaderText = "asistir";
            this.asistirDataGridViewTextBoxColumn.Name = "asistirDataGridViewTextBoxColumn";
            this.asistirDataGridViewTextBoxColumn.ReadOnly = true;
            this.asistirDataGridViewTextBoxColumn.Visible = false;
            // 
            // comunidadesDataGridViewTextBoxColumn
            // 
            this.comunidadesDataGridViewTextBoxColumn.DataPropertyName = "comunidades";
            this.comunidadesDataGridViewTextBoxColumn.HeaderText = "comunidades";
            this.comunidadesDataGridViewTextBoxColumn.Name = "comunidadesDataGridViewTextBoxColumn";
            this.comunidadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.comunidadesDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentosDataGridViewTextBoxColumn
            // 
            this.documentosDataGridViewTextBoxColumn.DataPropertyName = "documentos";
            this.documentosDataGridViewTextBoxColumn.HeaderText = "documentos";
            this.documentosDataGridViewTextBoxColumn.Name = "documentosDataGridViewTextBoxColumn";
            this.documentosDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentosDataGridViewTextBoxColumn.Visible = false;
            // 
            // notificacionesDataGridViewTextBoxColumn
            // 
            this.notificacionesDataGridViewTextBoxColumn.DataPropertyName = "notificaciones";
            this.notificacionesDataGridViewTextBoxColumn.HeaderText = "notificaciones";
            this.notificacionesDataGridViewTextBoxColumn.Name = "notificacionesDataGridViewTextBoxColumn";
            this.notificacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notificacionesDataGridViewTextBoxColumn.Visible = false;
            // 
            // Comunidad
            // 
            this.Comunidad.HeaderText = "Comunidad";
            this.Comunidad.Name = "Comunidad";
            this.Comunidad.ReadOnly = true;
            // 
            // bindingSourceEventos
            // 
            this.bindingSourceEventos.DataSource = typeof(Chrysallis.eventos);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(87, 7);
            this.dateTimePickerDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDesde.TabIndex = 11;
            this.dateTimePickerDesde.ValueChanged += new System.EventHandler(this.dateTimePickerFiltroFecha_ValueChanged);
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(87, 38);
            this.dateTimePickerHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerHasta.TabIndex = 12;
            this.dateTimePickerHasta.ValueChanged += new System.EventHandler(this.dateTimePickerHasta_ValueChanged);
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(16, 46);
            this.labelHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(45, 17);
            this.labelHasta.TabIndex = 13;
            this.labelHasta.Text = "Hasta";
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(16, 15);
            this.labelDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(49, 17);
            this.labelDesde.TabIndex = 14;
            this.labelDesde.Text = "Desde";
            // 
            // buttonAgregarEvento
            // 
            this.buttonAgregarEvento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAgregarEvento.AutoSize = true;
            this.buttonAgregarEvento.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarEvento.BorderColor = System.Drawing.Color.Black;
            this.buttonAgregarEvento.ButtonColor = System.Drawing.SystemColors.Info;
            this.buttonAgregarEvento.FlatAppearance.BorderSize = 0;
            this.buttonAgregarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarEvento.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonAgregarEvento.Location = new System.Drawing.Point(333, 430);
            this.buttonAgregarEvento.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregarEvento.Name = "buttonAgregarEvento";
            this.buttonAgregarEvento.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonAgregarEvento.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonAgregarEvento.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonAgregarEvento.Size = new System.Drawing.Size(267, 49);
            this.buttonAgregarEvento.TabIndex = 10;
            this.buttonAgregarEvento.Text = "Agregar evento";
            this.buttonAgregarEvento.TextColor = System.Drawing.Color.Black;
            this.buttonAgregarEvento.UseVisualStyleBackColor = false;
            this.buttonAgregarEvento.Click += new System.EventHandler(this.buttonAgregarEvento_Click);
            // 
            // pictureBoxLupa
            // 
            this.pictureBoxLupa.Image = global::Chrysallis.Properties.Resources.lupa;
            this.pictureBoxLupa.Location = new System.Drawing.Point(378, 10);
            this.pictureBoxLupa.Name = "pictureBoxLupa";
            this.pictureBoxLupa.Size = new System.Drawing.Size(68, 50);
            this.pictureBoxLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLupa.TabIndex = 16;
            this.pictureBoxLupa.TabStop = false;
            this.pictureBoxLupa.Click += new System.EventHandler(this.pictureBoxLupa_Click);
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 492);
            this.Controls.Add(this.pictureBoxLupa);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.buttonAgregarEvento);
            this.Controls.Add(this.dataGridViewEventos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEventos";
            this.Text = "FormEventos";
            this.Load += new System.EventHandler(this.FormEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private AppDesktop.Button_WOC buttonAgregarEvento;
        private System.Windows.Forms.BindingSource bindingSourceEventos;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLimiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAsistentesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comunidad;
        private System.Windows.Forms.PictureBox pictureBoxLupa;
    }
}