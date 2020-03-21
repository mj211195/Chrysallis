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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento));
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
            this.listBoxNotificacionesBase = new System.Windows.Forms.ListBox();
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
            this.listBoxNotificacionesSelec = new System.Windows.Forms.ListBox();
            this.bindingSourceNotificacionesGuardar = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAñadirNot = new System.Windows.Forms.Button();
            this.buttonEliminarNot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNotificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNotificacionesGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(8, 203);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.AllowDrop = true;
            this.dateTimePickerFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(112, 203);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(308, 20);
            this.dateTimePickerFecha.TabIndex = 1;
            this.dateTimePickerFecha.Value = new System.DateTime(2020, 2, 20, 11, 23, 48, 0);
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Location = new System.Drawing.Point(8, 232);
            this.labelUbicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(55, 13);
            this.labelUbicacion.TabIndex = 2;
            this.labelUbicacion.Text = "Ubicacion";
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Location = new System.Drawing.Point(112, 229);
            this.textBoxUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUbicacion.MaxLength = 150;
            this.textBoxUbicacion.Multiline = true;
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(308, 69);
            this.textBoxUbicacion.TabIndex = 3;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(8, 305);
            this.labelHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(30, 13);
            this.labelHora.TabIndex = 4;
            this.labelHora.Text = "Hora";
            // 
            // labelFechaLimite
            // 
            this.labelFechaLimite.AutoSize = true;
            this.labelFechaLimite.Location = new System.Drawing.Point(8, 335);
            this.labelFechaLimite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaLimite.Name = "labelFechaLimite";
            this.labelFechaLimite.Size = new System.Drawing.Size(67, 13);
            this.labelFechaLimite.TabIndex = 6;
            this.labelFechaLimite.Text = "Fecha Limite";
            // 
            // dateTimePickerFechaLimite
            // 
            this.dateTimePickerFechaLimite.Location = new System.Drawing.Point(112, 331);
            this.dateTimePickerFechaLimite.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFechaLimite.Name = "dateTimePickerFechaLimite";
            this.dateTimePickerFechaLimite.Size = new System.Drawing.Size(308, 20);
            this.dateTimePickerFechaLimite.TabIndex = 7;
            // 
            // labelNumeroAsistentes
            // 
            this.labelNumeroAsistentes.AutoSize = true;
            this.labelNumeroAsistentes.Location = new System.Drawing.Point(8, 357);
            this.labelNumeroAsistentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroAsistentes.Name = "labelNumeroAsistentes";
            this.labelNumeroAsistentes.Size = new System.Drawing.Size(78, 13);
            this.labelNumeroAsistentes.TabIndex = 8;
            this.labelNumeroAsistentes.Text = "Max Asistentes";
            // 
            // textBoxNumeroAsistentes
            // 
            this.textBoxNumeroAsistentes.Location = new System.Drawing.Point(112, 353);
            this.textBoxNumeroAsistentes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeroAsistentes.MaxLength = 8;
            this.textBoxNumeroAsistentes.Name = "textBoxNumeroAsistentes";
            this.textBoxNumeroAsistentes.Size = new System.Drawing.Size(144, 20);
            this.textBoxNumeroAsistentes.TabIndex = 9;
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Location = new System.Drawing.Point(8, 379);
            this.labelComunidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(60, 13);
            this.labelComunidad.TabIndex = 10;
            this.labelComunidad.Text = "Comunidad";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(8, 180);
            this.labelImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(42, 13);
            this.labelImagen.TabIndex = 12;
            this.labelImagen.Text = "Imagen";
            // 
            // buttonDocumento
            // 
            this.buttonDocumento.Location = new System.Drawing.Point(344, 179);
            this.buttonDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDocumento.Name = "buttonDocumento";
            this.buttonDocumento.Size = new System.Drawing.Size(75, 19);
            this.buttonDocumento.TabIndex = 31;
            this.buttonDocumento.Text = "Seleccionar";
            this.buttonDocumento.Click += new System.EventHandler(this.buttonDocumento_Click);
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(112, 180);
            this.textBoxImagen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.ReadOnly = true;
            this.textBoxImagen.Size = new System.Drawing.Size(228, 20);
            this.textBoxImagen.TabIndex = 13;
            // 
            // labelNotificaciones
            // 
            this.labelNotificaciones.AutoSize = true;
            this.labelNotificaciones.Location = new System.Drawing.Point(8, 520);
            this.labelNotificaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotificaciones.Name = "labelNotificaciones";
            this.labelNotificaciones.Size = new System.Drawing.Size(102, 13);
            this.labelNotificaciones.TabIndex = 19;
            this.labelNotificaciones.Text = "Notificaciones (dias)";
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
            this.comboBoxComunity.Location = new System.Drawing.Point(112, 377);
            this.comboBoxComunity.Name = "comboBoxComunity";
            this.comboBoxComunity.Size = new System.Drawing.Size(308, 21);
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
            // listBoxNotificacionesBase
            // 
            this.listBoxNotificacionesBase.DataSource = this.bindingSourceNotificaciones;
            this.listBoxNotificacionesBase.DisplayMember = "antelacion";
            this.listBoxNotificacionesBase.FormattingEnabled = true;
            this.listBoxNotificacionesBase.Location = new System.Drawing.Point(112, 520);
            this.listBoxNotificacionesBase.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxNotificacionesBase.Name = "listBoxNotificacionesBase";
            this.listBoxNotificacionesBase.Size = new System.Drawing.Size(106, 95);
            this.listBoxNotificacionesBase.TabIndex = 20;
            this.listBoxNotificacionesBase.ValueMember = "id";
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(112, 305);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(132, 20);
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
            this.buttonSave.Location = new System.Drawing.Point(102, 626);
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
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(8, 15);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 22;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(8, 41);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 23;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(112, 15);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.MaxLength = 50;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(308, 20);
            this.textBoxNombre.TabIndex = 24;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(112, 41);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescripcion.MaxLength = 300;
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(308, 135);
            this.textBoxDescripcion.TabIndex = 25;
            // 
            // labelDocumentos
            // 
            this.labelDocumentos.AutoSize = true;
            this.labelDocumentos.Location = new System.Drawing.Point(8, 403);
            this.labelDocumentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDocumentos.Name = "labelDocumentos";
            this.labelDocumentos.Size = new System.Drawing.Size(67, 13);
            this.labelDocumentos.TabIndex = 26;
            this.labelDocumentos.Text = "Documentos";
            // 
            // listBoxDocumentos
            // 
            this.listBoxDocumentos.DataSource = this.bindingSourceDocumentos;
            this.listBoxDocumentos.DisplayMember = "nombre";
            this.listBoxDocumentos.FormattingEnabled = true;
            this.listBoxDocumentos.Location = new System.Drawing.Point(112, 403);
            this.listBoxDocumentos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDocumentos.Name = "listBoxDocumentos";
            this.listBoxDocumentos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDocumentos.Size = new System.Drawing.Size(308, 82);
            this.listBoxDocumentos.TabIndex = 27;
            this.listBoxDocumentos.ValueMember = "id";
            // 
            // bindingSourceDocumentos
            // 
            this.bindingSourceDocumentos.DataSource = typeof(Chrysallis.documentos);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(112, 490);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(93, 26);
            this.buttonNuevo.TabIndex = 28;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(220, 489);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(89, 27);
            this.buttonEliminar.TabIndex = 29;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(326, 489);
            this.buttonVer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(94, 27);
            this.buttonVer.TabIndex = 30;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // openFileDialogDocumentos
            // 
            this.openFileDialogDocumentos.FileName = "openFileDialogDocumentos";
            // 
            // listBoxNotificacionesSelec
            // 
            this.listBoxNotificacionesSelec.DataSource = this.bindingSourceNotificacionesGuardar;
            this.listBoxNotificacionesSelec.DisplayMember = "antelacion";
            this.listBoxNotificacionesSelec.FormattingEnabled = true;
            this.listBoxNotificacionesSelec.Location = new System.Drawing.Point(314, 520);
            this.listBoxNotificacionesSelec.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxNotificacionesSelec.Name = "listBoxNotificacionesSelec";
            this.listBoxNotificacionesSelec.Size = new System.Drawing.Size(106, 95);
            this.listBoxNotificacionesSelec.TabIndex = 32;
            this.listBoxNotificacionesSelec.ValueMember = "id";
            // 
            // bindingSourceNotificacionesGuardar
            // 
            this.bindingSourceNotificacionesGuardar.DataSource = typeof(Chrysallis.notificaciones);
            // 
            // buttonAñadirNot
            // 
            this.buttonAñadirNot.Location = new System.Drawing.Point(230, 534);
            this.buttonAñadirNot.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAñadirNot.Name = "buttonAñadirNot";
            this.buttonAñadirNot.Size = new System.Drawing.Size(73, 19);
            this.buttonAñadirNot.TabIndex = 33;
            this.buttonAñadirNot.Text = "Añadir >>";
            this.buttonAñadirNot.UseVisualStyleBackColor = true;
            this.buttonAñadirNot.Click += new System.EventHandler(this.buttonAñadirNot_Click);
            // 
            // buttonEliminarNot
            // 
            this.buttonEliminarNot.Location = new System.Drawing.Point(230, 572);
            this.buttonEliminarNot.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarNot.Name = "buttonEliminarNot";
            this.buttonEliminarNot.Size = new System.Drawing.Size(73, 19);
            this.buttonEliminarNot.TabIndex = 34;
            this.buttonEliminarNot.Text = "<< Eliminar";
            this.buttonEliminarNot.UseVisualStyleBackColor = true;
            this.buttonEliminarNot.Click += new System.EventHandler(this.buttonEliminarNot_Click);
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 675);
            this.Controls.Add(this.buttonEliminarNot);
            this.Controls.Add(this.buttonAñadirNot);
            this.Controls.Add(this.listBoxNotificacionesSelec);
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
            this.Controls.Add(this.listBoxNotificacionesBase);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEvento";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.FormEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNotificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNotificacionesGuardar)).EndInit();
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
        private System.Windows.Forms.ListBox listBoxNotificacionesBase;
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
        private System.Windows.Forms.ListBox listBoxNotificacionesSelec;
        private System.Windows.Forms.Button buttonAñadirNot;
        private System.Windows.Forms.Button buttonEliminarNot;
        private System.Windows.Forms.BindingSource bindingSourceNotificacionesGuardar;
    }
}