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
            this.labelImagen = new System.Windows.Forms.Label();
            this.buttonDocumento = new System.Windows.Forms.Button();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.labelNotificaciones = new System.Windows.Forms.Label();
            this.openFileDialogImagen = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxComunity = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.notificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceNotificaciones = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxNotificaciones = new System.Windows.Forms.ListBox();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new AppDesktop.Button_WOC();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDocumentos = new System.Windows.Forms.Label();
            this.listBoxDocumentos = new System.Windows.Forms.ListBox();
            this.bindingSourceDocumentos = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            this.openFileDialogDocumentos = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNotificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(11, 250);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(47, 17);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(150, 250);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(409, 22);
            this.dateTimePickerFecha.TabIndex = 1;
            this.dateTimePickerFecha.Value = new System.DateTime(2020, 2, 20, 11, 23, 48, 0);
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Location = new System.Drawing.Point(11, 286);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(70, 17);
            this.labelUbicacion.TabIndex = 2;
            this.labelUbicacion.Text = "Ubicacion";
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Location = new System.Drawing.Point(150, 282);
            this.textBoxUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUbicacion.Multiline = true;
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(409, 84);
            this.textBoxUbicacion.TabIndex = 3;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(11, 375);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(39, 17);
            this.labelHora.TabIndex = 4;
            this.labelHora.Text = "Hora";
            // 
            // labelFechaLimite
            // 
            this.labelFechaLimite.AutoSize = true;
            this.labelFechaLimite.Location = new System.Drawing.Point(11, 412);
            this.labelFechaLimite.Name = "labelFechaLimite";
            this.labelFechaLimite.Size = new System.Drawing.Size(88, 17);
            this.labelFechaLimite.TabIndex = 6;
            this.labelFechaLimite.Text = "Fecha Limite";
            // 
            // dateTimePickerFechaLimite
            // 
            this.dateTimePickerFechaLimite.Location = new System.Drawing.Point(150, 407);
            this.dateTimePickerFechaLimite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaLimite.Name = "dateTimePickerFechaLimite";
            this.dateTimePickerFechaLimite.Size = new System.Drawing.Size(409, 22);
            this.dateTimePickerFechaLimite.TabIndex = 7;
            // 
            // labelNumeroAsistentes
            // 
            this.labelNumeroAsistentes.AutoSize = true;
            this.labelNumeroAsistentes.Location = new System.Drawing.Point(11, 439);
            this.labelNumeroAsistentes.Name = "labelNumeroAsistentes";
            this.labelNumeroAsistentes.Size = new System.Drawing.Size(127, 17);
            this.labelNumeroAsistentes.TabIndex = 8;
            this.labelNumeroAsistentes.Text = "Numero Asistentes";
            // 
            // textBoxNumeroAsistentes
            // 
            this.textBoxNumeroAsistentes.Location = new System.Drawing.Point(150, 435);
            this.textBoxNumeroAsistentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumeroAsistentes.Name = "textBoxNumeroAsistentes";
            this.textBoxNumeroAsistentes.Size = new System.Drawing.Size(191, 22);
            this.textBoxNumeroAsistentes.TabIndex = 9;
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Location = new System.Drawing.Point(11, 467);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(79, 17);
            this.labelComunidad.TabIndex = 10;
            this.labelComunidad.Text = "Comunidad";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(11, 219);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(54, 17);
            this.labelImagen.TabIndex = 12;
            this.labelImagen.Text = "Imagen";
            // 
            // buttonDocumento
            // 
            this.buttonDocumento.Location = new System.Drawing.Point(459, 218);
            this.buttonDocumento.Name = "buttonDocumento";
            this.buttonDocumento.Size = new System.Drawing.Size(100, 23);
            this.buttonDocumento.TabIndex = 31;
            this.buttonDocumento.Text = "Seleccionar";
            this.buttonDocumento.Click += new System.EventHandler(this.buttonDocumento_Click);
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(150, 219);
            this.textBoxImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.ReadOnly = true;
            this.textBoxImagen.Size = new System.Drawing.Size(303, 22);
            this.textBoxImagen.TabIndex = 13;
            // 
            // labelNotificaciones
            // 
            this.labelNotificaciones.AutoSize = true;
            this.labelNotificaciones.Location = new System.Drawing.Point(14, 643);
            this.labelNotificaciones.Name = "labelNotificaciones";
            this.labelNotificaciones.Size = new System.Drawing.Size(96, 17);
            this.labelNotificaciones.TabIndex = 19;
            this.labelNotificaciones.Text = "Notificaciones";
            // 
            // openFileDialogImagen
            // 
            this.openFileDialogImagen.FileName = "openFileDialogImagen";
            // 
            // comboBoxComunity
            // 
            this.comboBoxComunity.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunity.DisplayMember = "nombre";
            this.comboBoxComunity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunity.FormattingEnabled = true;
            this.comboBoxComunity.Location = new System.Drawing.Point(150, 463);
            this.comboBoxComunity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxComunity.Name = "comboBoxComunity";
            this.comboBoxComunity.Size = new System.Drawing.Size(409, 24);
            this.comboBoxComunity.TabIndex = 11;
            this.comboBoxComunity.ValueMember = "id";
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(Chrysallis.comunidades);
            // 
            // notificacionesBindingSource
            // 
            this.notificacionesBindingSource.DataSource = typeof(Chrysallis.notificaciones);
            // 
            // bindingSourceNotificaciones
            // 
            this.bindingSourceNotificaciones.DataSource = typeof(Chrysallis.notificaciones);
            // 
            // listBoxNotificaciones
            // 
            this.listBoxNotificaciones.DataSource = this.bindingSourceNotificaciones;
            this.listBoxNotificaciones.DisplayMember = "antelacion";
            this.listBoxNotificaciones.FormattingEnabled = true;
            this.listBoxNotificaciones.ItemHeight = 16;
            this.listBoxNotificaciones.Location = new System.Drawing.Point(150, 640);
            this.listBoxNotificaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxNotificaciones.Name = "listBoxNotificaciones";
            this.listBoxNotificaciones.Size = new System.Drawing.Size(409, 84);
            this.listBoxNotificaciones.TabIndex = 20;
            this.listBoxNotificaciones.ValueMember = "id";
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(150, 375);
            this.dateTimePickerHora.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(175, 22);
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
            this.buttonSave.Location = new System.Drawing.Point(123, 733);
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
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(11, 18);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 22;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(11, 50);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcion.TabIndex = 23;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(150, 18);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(409, 22);
            this.textBoxNombre.TabIndex = 24;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(150, 50);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescripcion.MaxLength = 500;
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(409, 165);
            this.textBoxDescripcion.TabIndex = 25;
            // 
            // labelDocumentos
            // 
            this.labelDocumentos.AutoSize = true;
            this.labelDocumentos.Location = new System.Drawing.Point(11, 496);
            this.labelDocumentos.Name = "labelDocumentos";
            this.labelDocumentos.Size = new System.Drawing.Size(87, 17);
            this.labelDocumentos.TabIndex = 26;
            this.labelDocumentos.Text = "Documentos";
            // 
            // listBoxDocumentos
            // 
            this.listBoxDocumentos.DataSource = this.bindingSourceDocumentos;
            this.listBoxDocumentos.DisplayMember = "nombre";
            this.listBoxDocumentos.FormattingEnabled = true;
            this.listBoxDocumentos.ItemHeight = 16;
            this.listBoxDocumentos.Location = new System.Drawing.Point(150, 496);
            this.listBoxDocumentos.Name = "listBoxDocumentos";
            this.listBoxDocumentos.Size = new System.Drawing.Size(409, 100);
            this.listBoxDocumentos.TabIndex = 27;
            this.listBoxDocumentos.ValueMember = "id";
            // 
            // bindingSourceDocumentos
            // 
            this.bindingSourceDocumentos.DataSource = typeof(Chrysallis.documentos);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(150, 603);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(124, 32);
            this.buttonNuevo.TabIndex = 28;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(294, 602);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(119, 33);
            this.buttonEliminar.TabIndex = 29;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(434, 602);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(125, 33);
            this.buttonVer.TabIndex = 30;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // openFileDialogDocumentos
            // 
            this.openFileDialogDocumentos.FileName = "openFileDialogDocumentos";
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 792);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.listBoxDocumentos);
            this.Controls.Add(this.labelDocumentos);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.listBoxNotificaciones);
            this.Controls.Add(this.comboBoxComunity);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelNotificaciones);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.buttonDocumento);
            this.Controls.Add(this.labelImagen);
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
            ((System.ComponentModel.ISupportInitialize)(this.notificacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNotificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentos)).EndInit();
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
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Button buttonDocumento;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.Label labelNotificaciones;
        private AppDesktop.Button_WOC buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagen;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.ComboBox comboBoxComunity;
        private System.Windows.Forms.ListBox listBoxNotificaciones;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.BindingSource notificacionesBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceNotificaciones;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDocumentos;
        private System.Windows.Forms.ListBox listBoxDocumentos;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocumentos;
        private System.Windows.Forms.BindingSource bindingSourceDocumentos;
    }
}