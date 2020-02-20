namespace Chrysallis
{
    partial class FormEvento
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
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.labelFechaLimite = new System.Windows.Forms.Label();
            this.dateTimePickerFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.labelNumeroAsistentes = new System.Windows.Forms.Label();
            this.textBoxNumeroAsistentes = new System.Windows.Forms.TextBox();
            this.labelComunidad = new System.Windows.Forms.Label();
            this.labelDocumentos = new System.Windows.Forms.Label();
            this.buttonDocumento = new System.Windows.Forms.Button();
            this.textBoxDocumentos = new System.Windows.Forms.TextBox();
            this.textBoxDocumentos2 = new System.Windows.Forms.TextBox();
            this.buttonDocumentos2 = new System.Windows.Forms.Button();
            this.textBoxDocumentos3 = new System.Windows.Forms.TextBox();
            this.buttonDocumentos3 = new System.Windows.Forms.Button();
            this.labelNotificaciones = new System.Windows.Forms.Label();
            this.buttonSave = new AppDesktop.Button_WOC();
            this.Documento1 = new System.Windows.Forms.OpenFileDialog();
            this.Documento2 = new System.Windows.Forms.OpenFileDialog();
            this.Documento3 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxComunity = new System.Windows.Forms.ComboBox();
            this.listBoxNotificaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(10, 11);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(110, 11);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(263, 20);
            this.dateTimePickerFecha.TabIndex = 1;
            this.dateTimePickerFecha.Value = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Location = new System.Drawing.Point(10, 37);
            this.labelUbicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(55, 13);
            this.labelUbicacion.TabIndex = 2;
            this.labelUbicacion.Text = "Ubicacion";
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Location = new System.Drawing.Point(110, 34);
            this.textBoxUbicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUbicacion.Multiline = true;
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(263, 81);
            this.textBoxUbicacion.TabIndex = 3;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(10, 119);
            this.labelHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(30, 13);
            this.labelHora.TabIndex = 4;
            this.labelHora.Text = "Hora";
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Location = new System.Drawing.Point(110, 120);
            this.comboBoxHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(263, 21);
            this.comboBoxHora.TabIndex = 5;
            // 
            // labelFechaLimite
            // 
            this.labelFechaLimite.AutoSize = true;
            this.labelFechaLimite.Location = new System.Drawing.Point(10, 149);
            this.labelFechaLimite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaLimite.Name = "labelFechaLimite";
            this.labelFechaLimite.Size = new System.Drawing.Size(67, 13);
            this.labelFechaLimite.TabIndex = 6;
            this.labelFechaLimite.Text = "Fecha Limite";
            // 
            // dateTimePickerFechaLimite
            // 
            this.dateTimePickerFechaLimite.Location = new System.Drawing.Point(110, 145);
            this.dateTimePickerFechaLimite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaLimite.Name = "dateTimePickerFechaLimite";
            this.dateTimePickerFechaLimite.Size = new System.Drawing.Size(263, 20);
            this.dateTimePickerFechaLimite.TabIndex = 7;
            // 
            // labelNumeroAsistentes
            // 
            this.labelNumeroAsistentes.AutoSize = true;
            this.labelNumeroAsistentes.Location = new System.Drawing.Point(10, 171);
            this.labelNumeroAsistentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroAsistentes.Name = "labelNumeroAsistentes";
            this.labelNumeroAsistentes.Size = new System.Drawing.Size(95, 13);
            this.labelNumeroAsistentes.TabIndex = 8;
            this.labelNumeroAsistentes.Text = "Numero Asistentes";
            // 
            // textBoxNumeroAsistentes
            // 
            this.textBoxNumeroAsistentes.Location = new System.Drawing.Point(110, 167);
            this.textBoxNumeroAsistentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumeroAsistentes.Name = "textBoxNumeroAsistentes";
            this.textBoxNumeroAsistentes.Size = new System.Drawing.Size(99, 20);
            this.textBoxNumeroAsistentes.TabIndex = 9;
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Location = new System.Drawing.Point(10, 193);
            this.labelComunidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(60, 13);
            this.labelComunidad.TabIndex = 10;
            this.labelComunidad.Text = "Comunidad";
            // 
            // labelDocumentos
            // 
            this.labelDocumentos.AutoSize = true;
            this.labelDocumentos.Location = new System.Drawing.Point(10, 215);
            this.labelDocumentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDocumentos.Name = "labelDocumentos";
            this.labelDocumentos.Size = new System.Drawing.Size(67, 13);
            this.labelDocumentos.TabIndex = 12;
            this.labelDocumentos.Text = "Documentos";
            // 
            // buttonDocumento
            // 
            this.buttonDocumento.Location = new System.Drawing.Point(298, 215);
            this.buttonDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDocumento.Name = "buttonDocumento";
            this.buttonDocumento.Size = new System.Drawing.Size(74, 19);
            this.buttonDocumento.TabIndex = 13;
            this.buttonDocumento.Text = "Selecciona";
            this.buttonDocumento.UseVisualStyleBackColor = true;
            this.buttonDocumento.Click += new System.EventHandler(this.buttonDocumento_Click);
            // 
            // textBoxDocumentos
            // 
            this.textBoxDocumentos.Location = new System.Drawing.Point(110, 215);
            this.textBoxDocumentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDocumentos.Name = "textBoxDocumentos";
            this.textBoxDocumentos.ReadOnly = true;
            this.textBoxDocumentos.Size = new System.Drawing.Size(186, 20);
            this.textBoxDocumentos.TabIndex = 14;
            // 
            // textBoxDocumentos2
            // 
            this.textBoxDocumentos2.Location = new System.Drawing.Point(110, 238);
            this.textBoxDocumentos2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDocumentos2.Name = "textBoxDocumentos2";
            this.textBoxDocumentos2.ReadOnly = true;
            this.textBoxDocumentos2.Size = new System.Drawing.Size(186, 20);
            this.textBoxDocumentos2.TabIndex = 16;
            // 
            // buttonDocumentos2
            // 
            this.buttonDocumentos2.Location = new System.Drawing.Point(298, 238);
            this.buttonDocumentos2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDocumentos2.Name = "buttonDocumentos2";
            this.buttonDocumentos2.Size = new System.Drawing.Size(74, 19);
            this.buttonDocumentos2.TabIndex = 15;
            this.buttonDocumentos2.Text = "Selecciona";
            this.buttonDocumentos2.UseVisualStyleBackColor = true;
            this.buttonDocumentos2.Click += new System.EventHandler(this.buttonDocumentos2_Click);
            // 
            // textBoxDocumentos3
            // 
            this.textBoxDocumentos3.Location = new System.Drawing.Point(110, 261);
            this.textBoxDocumentos3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDocumentos3.Name = "textBoxDocumentos3";
            this.textBoxDocumentos3.ReadOnly = true;
            this.textBoxDocumentos3.Size = new System.Drawing.Size(186, 20);
            this.textBoxDocumentos3.TabIndex = 18;
            // 
            // buttonDocumentos3
            // 
            this.buttonDocumentos3.Location = new System.Drawing.Point(298, 261);
            this.buttonDocumentos3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDocumentos3.Name = "buttonDocumentos3";
            this.buttonDocumentos3.Size = new System.Drawing.Size(74, 19);
            this.buttonDocumentos3.TabIndex = 17;
            this.buttonDocumentos3.Text = "Selecciona";
            this.buttonDocumentos3.UseVisualStyleBackColor = true;
            this.buttonDocumentos3.Click += new System.EventHandler(this.buttonDocumentos3_Click);
            // 
            // labelNotificaciones
            // 
            this.labelNotificaciones.AutoSize = true;
            this.labelNotificaciones.Location = new System.Drawing.Point(12, 287);
            this.labelNotificaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotificaciones.Name = "labelNotificaciones";
            this.labelNotificaciones.Size = new System.Drawing.Size(74, 13);
            this.labelNotificaciones.TabIndex = 19;
            this.labelNotificaciones.Text = "Notificaciones";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.ButtonColor = System.Drawing.SystemColors.Info;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonSave.Location = new System.Drawing.Point(94, 360);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonSave.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonSave.Size = new System.Drawing.Size(200, 40);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Documento1
            // 
            this.Documento1.FileName = "openFileDialogDocumento1";
            // 
            // Documento2
            // 
            this.Documento2.FileName = "openFileDialogDocumento2";
            // 
            // Documento3
            // 
            this.Documento3.FileName = "openFileDialogDocumento3";
            // 
            // comboBoxComunity
            // 
            this.comboBoxComunity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunity.FormattingEnabled = true;
            this.comboBoxComunity.Location = new System.Drawing.Point(110, 190);
            this.comboBoxComunity.Name = "comboBoxComunity";
            this.comboBoxComunity.Size = new System.Drawing.Size(263, 21);
            this.comboBoxComunity.TabIndex = 22;
            // 
            // listBoxNotificaciones
            // 
            this.listBoxNotificaciones.FormattingEnabled = true;
            this.listBoxNotificaciones.Location = new System.Drawing.Point(110, 284);
            this.listBoxNotificaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxNotificaciones.Name = "listBoxNotificaciones";
            this.listBoxNotificaciones.Size = new System.Drawing.Size(263, 69);
            this.listBoxNotificaciones.TabIndex = 23;
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 410);
            this.Controls.Add(this.listBoxNotificaciones);
            this.Controls.Add(this.comboBoxComunity);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelNotificaciones);
            this.Controls.Add(this.textBoxDocumentos3);
            this.Controls.Add(this.buttonDocumentos3);
            this.Controls.Add(this.textBoxDocumentos2);
            this.Controls.Add(this.buttonDocumentos2);
            this.Controls.Add(this.textBoxDocumentos);
            this.Controls.Add(this.buttonDocumento);
            this.Controls.Add(this.labelDocumentos);
            this.Controls.Add(this.labelComunidad);
            this.Controls.Add(this.textBoxNumeroAsistentes);
            this.Controls.Add(this.labelNumeroAsistentes);
            this.Controls.Add(this.dateTimePickerFechaLimite);
            this.Controls.Add(this.labelFechaLimite);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.labelUbicacion);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelFecha);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEvento";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.FormEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.Label labelFechaLimite;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaLimite;
        private System.Windows.Forms.Label labelNumeroAsistentes;
        private System.Windows.Forms.TextBox textBoxNumeroAsistentes;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.Label labelDocumentos;
        private System.Windows.Forms.Button buttonDocumento;
        private System.Windows.Forms.TextBox textBoxDocumentos;
        private System.Windows.Forms.TextBox textBoxDocumentos2;
        private System.Windows.Forms.Button buttonDocumentos2;
        private System.Windows.Forms.TextBox textBoxDocumentos3;
        private System.Windows.Forms.Button buttonDocumentos3;
        private System.Windows.Forms.Label labelNotificaciones;
        private AppDesktop.Button_WOC buttonSave;
        private System.Windows.Forms.OpenFileDialog Documento1;
        private System.Windows.Forms.OpenFileDialog Documento2;
        private System.Windows.Forms.OpenFileDialog Documento3;
        private System.Windows.Forms.ComboBox comboBoxComunity;
        private System.Windows.Forms.ListBox listBoxNotificaciones;
    }
}