namespace Chrysallis
{
    partial class FormSocios
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
            this.dataGridViewSocios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administradorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idiomaDefectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idcomunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSocios = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAgregarSocio = new AppDesktop.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSocios
            // 
            this.dataGridViewSocios.AllowUserToAddRows = false;
            this.dataGridViewSocios.AutoGenerateColumns = false;
            this.dataGridViewSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.administradorDataGridViewCheckBoxColumn,
            this.idiomaDefectoDataGridViewTextBoxColumn,
            this.estatalDataGridViewTextBoxColumn,
            this.idcomunidadDataGridViewTextBoxColumn,
            this.comunidad});
            this.dataGridViewSocios.DataSource = this.bindingSourceSocios;
            this.dataGridViewSocios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSocios.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSocios.Name = "dataGridViewSocios";
            this.dataGridViewSocios.ReadOnly = true;
            this.dataGridViewSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSocios.Size = new System.Drawing.Size(820, 438);
            this.dataGridViewSocios.TabIndex = 0;
            this.dataGridViewSocios.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewSocios_UserDeletingRow);
            this.dataGridViewSocios.DoubleClick += new System.EventHandler(this.dataGridViewSocios_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // administradorDataGridViewCheckBoxColumn
            // 
            this.administradorDataGridViewCheckBoxColumn.DataPropertyName = "administrador";
            this.administradorDataGridViewCheckBoxColumn.HeaderText = "administrador";
            this.administradorDataGridViewCheckBoxColumn.Name = "administradorDataGridViewCheckBoxColumn";
            this.administradorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idiomaDefectoDataGridViewTextBoxColumn
            // 
            this.idiomaDefectoDataGridViewTextBoxColumn.DataPropertyName = "idiomaDefecto";
            this.idiomaDefectoDataGridViewTextBoxColumn.HeaderText = "idiomaDefecto";
            this.idiomaDefectoDataGridViewTextBoxColumn.Name = "idiomaDefectoDataGridViewTextBoxColumn";
            this.idiomaDefectoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idiomaDefectoDataGridViewTextBoxColumn.Visible = false;
            // 
            // estatalDataGridViewTextBoxColumn
            // 
            this.estatalDataGridViewTextBoxColumn.DataPropertyName = "estatal";
            this.estatalDataGridViewTextBoxColumn.HeaderText = "estatal";
            this.estatalDataGridViewTextBoxColumn.Name = "estatalDataGridViewTextBoxColumn";
            this.estatalDataGridViewTextBoxColumn.ReadOnly = true;
            this.estatalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estatalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idcomunidadDataGridViewTextBoxColumn
            // 
            this.idcomunidadDataGridViewTextBoxColumn.DataPropertyName = "id_comunidad";
            this.idcomunidadDataGridViewTextBoxColumn.HeaderText = "id_comunidad";
            this.idcomunidadDataGridViewTextBoxColumn.Name = "idcomunidadDataGridViewTextBoxColumn";
            this.idcomunidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomunidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // comunidad
            // 
            this.comunidad.HeaderText = "Comunidad";
            this.comunidad.Name = "comunidad";
            this.comunidad.ReadOnly = true;
            // 
            // bindingSourceSocios
            // 
            this.bindingSourceSocios.DataSource = typeof(Chrysallis.socios);
            // 
            // buttonAgregarSocio
            // 
            this.buttonAgregarSocio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAgregarSocio.AutoSize = true;
            this.buttonAgregarSocio.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarSocio.BorderColor = System.Drawing.Color.Black;
            this.buttonAgregarSocio.ButtonColor = System.Drawing.SystemColors.Info;
            this.buttonAgregarSocio.FlatAppearance.BorderSize = 0;
            this.buttonAgregarSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarSocio.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonAgregarSocio.Location = new System.Drawing.Point(299, 444);
            this.buttonAgregarSocio.Name = "buttonAgregarSocio";
            this.buttonAgregarSocio.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonAgregarSocio.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonAgregarSocio.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonAgregarSocio.Size = new System.Drawing.Size(200, 40);
            this.buttonAgregarSocio.TabIndex = 9;
            this.buttonAgregarSocio.Text = "Agregar socio";
            this.buttonAgregarSocio.TextColor = System.Drawing.Color.Black;
            this.buttonAgregarSocio.UseVisualStyleBackColor = false;
            this.buttonAgregarSocio.Click += new System.EventHandler(this.buttonAgregarSocio_Click);
            // 
            // FormSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 496);
            this.Controls.Add(this.buttonAgregarSocio);
            this.Controls.Add(this.dataGridViewSocios);
            this.Name = "FormSocios";
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.FormSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AppDesktop.Button_WOC buttonAgregarSocio;
        private System.Windows.Forms.BindingSource bindingSourceSocios;
        private System.Windows.Forms.DataGridView dataGridViewSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn administradorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaDefectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estatalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunidad;
    }
}