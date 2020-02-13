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
            this.dataGridViewSocios = new System.Windows.Forms.DataGridView();
            this.buttonAgregarSocio = new AppDesktop.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSocios
            // 
            this.dataGridViewSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSocios.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewSocios.Name = "dataGridViewSocios";
            this.dataGridViewSocios.Size = new System.Drawing.Size(595, 344);
            this.dataGridViewSocios.TabIndex = 0;
            // 
            // buttonAgregarSocio
            // 
            this.buttonAgregarSocio.AutoSize = true;
            this.buttonAgregarSocio.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarSocio.BorderColor = System.Drawing.Color.Black;
            this.buttonAgregarSocio.ButtonColor = System.Drawing.SystemColors.Info;
            this.buttonAgregarSocio.FlatAppearance.BorderSize = 0;
            this.buttonAgregarSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarSocio.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonAgregarSocio.Location = new System.Drawing.Point(200, 372);
            this.buttonAgregarSocio.Name = "buttonAgregarSocio";
            this.buttonAgregarSocio.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonAgregarSocio.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonAgregarSocio.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonAgregarSocio.Size = new System.Drawing.Size(200, 40);
            this.buttonAgregarSocio.TabIndex = 9;
            this.buttonAgregarSocio.Text = "Agregar socio";
            this.buttonAgregarSocio.TextColor = System.Drawing.Color.Black;
            this.buttonAgregarSocio.UseVisualStyleBackColor = false;
            // 
            // FormSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 424);
            this.Controls.Add(this.buttonAgregarSocio);
            this.Controls.Add(this.dataGridViewSocios);
            this.Name = "FormSocios";
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.FormSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSocios;
        private AppDesktop.Button_WOC buttonAgregarSocio;
    }
}