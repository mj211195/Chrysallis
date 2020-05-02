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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsistentes));
            this.dataGridViewAsistentes = new System.Windows.Forms.DataGridView();
            this.socios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuantosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAsistentes = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAsistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAsistentes
            // 
            this.dataGridViewAsistentes.AllowUserToAddRows = false;
            this.dataGridViewAsistentes.AllowUserToDeleteRows = false;
            this.dataGridViewAsistentes.AutoGenerateColumns = false;
            this.dataGridViewAsistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.socios,
            this.cuantosDataGridViewTextBoxColumn});
            this.dataGridViewAsistentes.DataSource = this.bindingSourceAsistentes;
            this.dataGridViewAsistentes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAsistentes.Name = "dataGridViewAsistentes";
            this.dataGridViewAsistentes.ReadOnly = true;
            this.dataGridViewAsistentes.RowTemplate.Height = 24;
            this.dataGridViewAsistentes.Size = new System.Drawing.Size(524, 650);
            this.dataGridViewAsistentes.TabIndex = 0;
            this.dataGridViewAsistentes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAsistentes_CellFormatting);
            // 
            // socios
            // 
            this.socios.DataPropertyName = "socios";
            this.socios.HeaderText = "socios";
            this.socios.Name = "socios";
            this.socios.ReadOnly = true;
            // 
            // cuantosDataGridViewTextBoxColumn
            // 
            this.cuantosDataGridViewTextBoxColumn.DataPropertyName = "cuantos";
            this.cuantosDataGridViewTextBoxColumn.HeaderText = "cuantos";
            this.cuantosDataGridViewTextBoxColumn.Name = "cuantosDataGridViewTextBoxColumn";
            this.cuantosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceAsistentes
            // 
            this.bindingSourceAsistentes.DataSource = typeof(Chrysallis.asistir);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "socios";
            this.dataGridViewTextBoxColumn1.HeaderText = "socios";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "socios";
            this.dataGridViewTextBoxColumn2.HeaderText = "socios";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(12, 653);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(72, 25);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total:";
            // 
            // FormAsistentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 687);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dataGridViewAsistentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 750);
            this.MinimumSize = new System.Drawing.Size(540, 726);
            this.Name = "FormAsistentes";
            this.Text = "Asistentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAsistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAsistentes;
        private System.Windows.Forms.BindingSource bindingSourceAsistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn socios;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuantosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label labelTotal;
    }
}