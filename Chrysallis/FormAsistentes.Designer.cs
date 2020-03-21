namespace Chrysallis
{
    partial class FormAsistentes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourceAsistentes = new System.Windows.Forms.BindingSource(this.components);
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idsocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuantosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAsistentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsocioDataGridViewTextBoxColumn,
            this.nombre,
            this.cuantosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceAsistentes;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 703);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSourceAsistentes
            // 
            this.bindingSourceAsistentes.DataSource = typeof(Chrysallis.asistir);
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataSource = typeof(Chrysallis.eventos);
            // 
            // idsocioDataGridViewTextBoxColumn
            // 
            this.idsocioDataGridViewTextBoxColumn.DataPropertyName = "id_socio";
            this.idsocioDataGridViewTextBoxColumn.HeaderText = "id_socio";
            this.idsocioDataGridViewTextBoxColumn.Name = "idsocioDataGridViewTextBoxColumn";
            this.idsocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cuantosDataGridViewTextBoxColumn
            // 
            this.cuantosDataGridViewTextBoxColumn.DataPropertyName = "cuantos";
            this.cuantosDataGridViewTextBoxColumn.HeaderText = "cuantos";
            this.cuantosDataGridViewTextBoxColumn.Name = "cuantosDataGridViewTextBoxColumn";
            this.cuantosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormAsistentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAsistentes";
            this.Text = "FormAsistentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAsistentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceAsistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuantosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventosBindingSource;
    }
}