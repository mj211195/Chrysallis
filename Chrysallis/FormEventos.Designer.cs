namespace Chrysallis
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
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.buttonAgregarEvento = new AppDesktop.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.Size = new System.Drawing.Size(529, 362);
            this.dataGridViewEventos.TabIndex = 0;
            // 
            // buttonAgregarEvento
            // 
            this.buttonAgregarEvento.AutoSize = true;
            this.buttonAgregarEvento.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarEvento.BorderColor = System.Drawing.Color.Black;
            this.buttonAgregarEvento.ButtonColor = System.Drawing.SystemColors.Info;
            this.buttonAgregarEvento.FlatAppearance.BorderSize = 0;
            this.buttonAgregarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarEvento.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonAgregarEvento.Location = new System.Drawing.Point(171, 381);
            this.buttonAgregarEvento.Name = "buttonAgregarEvento";
            this.buttonAgregarEvento.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonAgregarEvento.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonAgregarEvento.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonAgregarEvento.Size = new System.Drawing.Size(200, 40);
            this.buttonAgregarEvento.TabIndex = 10;
            this.buttonAgregarEvento.Text = "Agregar evento";
            this.buttonAgregarEvento.TextColor = System.Drawing.Color.Black;
            this.buttonAgregarEvento.UseVisualStyleBackColor = false;
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 432);
            this.Controls.Add(this.buttonAgregarEvento);
            this.Controls.Add(this.dataGridViewEventos);
            this.Name = "FormEventos";
            this.Text = "FormEventos";
            this.Load += new System.EventHandler(this.FormEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private AppDesktop.Button_WOC buttonAgregarEvento;
    }
}