namespace Chrysallis
{
    partial class FormValoraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValoraciones));
            this.dataGridViewValoraciones = new System.Windows.Forms.DataGridView();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.valoracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceValoraciones = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceValoraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewValoraciones
            // 
            this.dataGridViewValoraciones.AutoGenerateColumns = false;
            this.dataGridViewValoraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValoraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valoracionDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.dataGridViewValoraciones.DataSource = this.bindingSourceValoraciones;
            this.dataGridViewValoraciones.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewValoraciones.Name = "dataGridViewValoraciones";
            this.dataGridViewValoraciones.ReadOnly = true;
            this.dataGridViewValoraciones.RowTemplate.Height = 24;
            this.dataGridViewValoraciones.Size = new System.Drawing.Size(791, 446);
            this.dataGridViewValoraciones.TabIndex = 0;
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromedio.Location = new System.Drawing.Point(12, 461);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(96, 25);
            this.labelPromedio.TabIndex = 2;
            this.labelPromedio.Text = "Mitjana:";
            // 
            // valoracionDataGridViewTextBoxColumn
            // 
            this.valoracionDataGridViewTextBoxColumn.DataPropertyName = "valoracion";
            this.valoracionDataGridViewTextBoxColumn.HeaderText = "valoracion";
            this.valoracionDataGridViewTextBoxColumn.Name = "valoracionDataGridViewTextBoxColumn";
            this.valoracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn.Width = 1000;
            // 
            // bindingSourceValoraciones
            // 
            this.bindingSourceValoraciones.DataSource = typeof(Chrysallis.asistir);
            // 
            // FormValoraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 494);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.dataGridViewValoraciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormValoraciones";
            this.Text = "Valoraciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceValoraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewValoraciones;
        private System.Windows.Forms.BindingSource bindingSourceValoraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelPromedio;
    }
}