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
            this.components = new System.ComponentModel.Container();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.labelHora = new System.Windows.Forms.Label();
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
            this.Documento1 = new System.Windows.Forms.OpenFileDialog();
            this.Documento2 = new System.Windows.Forms.OpenFileDialog();
            this.Documento3 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxComunity = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxNotificaciones = new System.Windows.Forms.ListBox();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new AppDesktop.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(13, 14);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(47, 17);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(147, 14);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(349, 22);
            this.dateTimePickerFecha.TabIndex = 1;
            this.dateTimePickerFecha.Value = new System.DateTime(2020, 2, 20, 11, 23, 48, 0);
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Location = new System.Drawing.Point(13, 46);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(70, 17);
            this.labelUbicacion.TabIndex = 2;
            this.labelUbicacion.Text = "Ubicacion";
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Location = new System.Drawing.Point(147, 42);
            this.textBoxUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUbicacion.Multiline = true;
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(349, 99);
            this.textBoxUbicacion.TabIndex = 3;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(13, 146);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(39, 17);
            this.labelHora.TabIndex = 4;
            this.labelHora.Text = "Hora";
            // 
            // labelFechaLimite
            // 
            this.labelFechaLimite.AutoSize = true;
            this.labelFechaLimite.Location = new System.Drawing.Point(13, 183);
            this.labelFechaLimite.Name = "labelFechaLimite";
            this.labelFechaLimite.Size = new System.Drawing.Size(88, 17);
            this.labelFechaLimite.TabIndex = 6;
            this.labelFechaLimite.Text = "Fecha Limite";
            // 
            // dateTimePickerFechaLimite
            // 
            this.dateTimePickerFechaLimite.Location = new System.Drawing.Point(147, 178);
            this.dateTimePickerFechaLimite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaLimite.Name = "dateTimePickerFechaLimite";
            this.dateTimePickerFechaLimite.Size = new System.Drawing.Size(349, 22);
            this.dateTimePickerFechaLimite.TabIndex = 7;
            // 
            // labelNumeroAsistentes
            // 
            this.labelNumeroAsistentes.AutoSize = true;
            this.labelNumeroAsistentes.Location = new System.Drawing.Point(13, 210);
            this.labelNumeroAsistentes.Name = "labelNumeroAsistentes";
            this.labelNumeroAsistentes.Size = new System.Drawing.Size(127, 17);
            this.labelNumeroAsistentes.TabIndex = 8;
            this.labelNumeroAsistentes.Text = "Numero Asistentes";
            // 
            // textBoxNumeroAsistentes
            // 
            this.textBoxNumeroAsistentes.Location = new System.Drawing.Point(147, 206);
            this.textBoxNumeroAsistentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumeroAsistentes.Name = "textBoxNumeroAsistentes";
            this.textBoxNumeroAsistentes.Size = new System.Drawing.Size(131, 22);
            this.textBoxNumeroAsistentes.TabIndex = 9;
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Location = new System.Drawing.Point(13, 238);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(79, 17);
            this.labelComunidad.TabIndex = 10;
            this.labelComunidad.Text = "Comunidad";
            // 
            // labelDocumentos
            // 
            this.labelDocumentos.AutoSize = true;
            this.labelDocumentos.Location = new System.Drawing.Point(13, 265);
            this.labelDocumentos.Name = "labelDocumentos";
            this.labelDocumentos.Size = new System.Drawing.Size(87, 17);
            this.labelDocumentos.TabIndex = 12;
            this.labelDocumentos.Text = "Documentos";
            // 
            // buttonDocumento
            // 
            this.buttonDocumento.Location = new System.Drawing.Point(397, 265);
            this.buttonDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDocumento.Name = "buttonDocumento";
            this.buttonDocumento.Size = new System.Drawing.Size(99, 23);
            this.buttonDocumento.TabIndex = 14;
            this.buttonDocumento.Text = "Selecciona";
            this.buttonDocumento.UseVisualStyleBackColor = true;
            this.buttonDocumento.Click += new System.EventHandler(this.buttonDocumento_Click);
            // 
            // textBoxDocumentos
            // 
            this.textBoxDocumentos.Location = new System.Drawing.Point(147, 265);
            this.textBoxDocumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDocumentos.Name = "textBoxDocumentos";
            this.textBoxDocumentos.ReadOnly = true;
            this.textBoxDocumentos.Size = new System.Drawing.Size(247, 22);
            this.textBoxDocumentos.TabIndex = 13;
            // 
            // textBoxDocumentos2
            // 
            this.textBoxDocumentos2.Location = new System.Drawing.Point(147, 293);
            this.textBoxDocumentos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDocumentos2.Name = "textBoxDocumentos2";
            this.textBoxDocumentos2.ReadOnly = true;
            this.textBoxDocumentos2.Size = new System.Drawing.Size(247, 22);
            this.textBoxDocumentos2.TabIndex = 15;
            // 
            // buttonDocumentos2
            // 
            this.buttonDocumentos2.Location = new System.Drawing.Point(397, 293);
            this.buttonDocumentos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDocumentos2.Name = "buttonDocumentos2";
            this.buttonDocumentos2.Size = new System.Drawing.Size(99, 23);
            this.buttonDocumentos2.TabIndex = 16;
            this.buttonDocumentos2.Text = "Selecciona";
            this.buttonDocumentos2.UseVisualStyleBackColor = true;
            this.buttonDocumentos2.Click += new System.EventHandler(this.buttonDocumentos2_Click);
            // 
            // textBoxDocumentos3
            // 
            this.textBoxDocumentos3.Location = new System.Drawing.Point(147, 321);
            this.textBoxDocumentos3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDocumentos3.Name = "textBoxDocumentos3";
            this.textBoxDocumentos3.ReadOnly = true;
            this.textBoxDocumentos3.Size = new System.Drawing.Size(247, 22);
            this.textBoxDocumentos3.TabIndex = 17;
            // 
            // buttonDocumentos3
            // 
            this.buttonDocumentos3.Location = new System.Drawing.Point(397, 321);
            this.buttonDocumentos3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDocumentos3.Name = "buttonDocumentos3";
            this.buttonDocumentos3.Size = new System.Drawing.Size(99, 23);
            this.buttonDocumentos3.TabIndex = 18;
            this.buttonDocumentos3.Text = "Selecciona";
            this.buttonDocumentos3.UseVisualStyleBackColor = true;
            this.buttonDocumentos3.Click += new System.EventHandler(this.buttonDocumentos3_Click);
            // 
            // labelNotificaciones
            // 
            this.labelNotificaciones.AutoSize = true;
            this.labelNotificaciones.Location = new System.Drawing.Point(16, 353);
            this.labelNotificaciones.Name = "labelNotificaciones";
            this.labelNotificaciones.Size = new System.Drawing.Size(96, 17);
            this.labelNotificaciones.TabIndex = 19;
            this.labelNotificaciones.Text = "Notificaciones";
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
            this.comboBoxComunity.Location = new System.Drawing.Point(147, 234);
            this.comboBoxComunity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxComunity.Name = "comboBoxComunity";
            this.comboBoxComunity.Size = new System.Drawing.Size(349, 24);
            this.comboBoxComunity.TabIndex = 11;
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(Chrysallis.comunidades);
            // 
            // listBoxNotificaciones
            // 
            this.listBoxNotificaciones.FormattingEnabled = true;
            this.listBoxNotificaciones.ItemHeight = 16;
            this.listBoxNotificaciones.Location = new System.Drawing.Point(147, 350);
            this.listBoxNotificaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxNotificaciones.Name = "listBoxNotificaciones";
            this.listBoxNotificaciones.Size = new System.Drawing.Size(349, 84);
            this.listBoxNotificaciones.TabIndex = 20;
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(147, 146);
            this.dateTimePickerHora.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(115, 22);
            this.dateTimePickerHora.TabIndex = 5;
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
            this.buttonSave.Location = new System.Drawing.Point(125, 443);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonSave.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonSave.Size = new System.Drawing.Size(267, 49);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.TextColor = System.Drawing.Color.Black;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 505);
            this.Controls.Add(this.dateTimePickerHora);
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
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.labelUbicacion);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelFecha);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEvento";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.FormEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.Label labelHora;
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
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.ComboBox comboBoxComunity;
        private System.Windows.Forms.ListBox listBoxNotificaciones;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
    }
}