namespace Chrysallis
{
    partial class FormMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdministrarEventos = new AppDesktop.Button_WOC();
            this.buttonAdministrarSocios = new AppDesktop.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chrysallis.Properties.Resources.logo4;
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdministrarEventos
            // 
            this.buttonAdministrarEventos.AutoSize = true;
            this.buttonAdministrarEventos.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdministrarEventos.BorderColor = System.Drawing.Color.Black;
            this.buttonAdministrarEventos.ButtonColor = System.Drawing.SystemColors.Info;
            this.buttonAdministrarEventos.FlatAppearance.BorderSize = 0;
            this.buttonAdministrarEventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAdministrarEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAdministrarEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdministrarEventos.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonAdministrarEventos.Location = new System.Drawing.Point(75, 268);
            this.buttonAdministrarEventos.Name = "buttonAdministrarEventos";
            this.buttonAdministrarEventos.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonAdministrarEventos.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonAdministrarEventos.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonAdministrarEventos.Size = new System.Drawing.Size(240, 40);
            this.buttonAdministrarEventos.TabIndex = 8;
            this.buttonAdministrarEventos.Text = "Administrar eventos";
            this.buttonAdministrarEventos.TextColor = System.Drawing.Color.Black;
            this.buttonAdministrarEventos.UseVisualStyleBackColor = false;
            this.buttonAdministrarEventos.Click += new System.EventHandler(this.buttonAdministrarEventos_Click);
            // 
            // buttonAdministrarSocios
            // 
            this.buttonAdministrarSocios.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdministrarSocios.BorderColor = System.Drawing.Color.Black;
            this.buttonAdministrarSocios.ButtonColor = System.Drawing.SystemColors.Info;
            this.buttonAdministrarSocios.FlatAppearance.BorderSize = 0;
            this.buttonAdministrarSocios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAdministrarSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAdministrarSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdministrarSocios.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonAdministrarSocios.Location = new System.Drawing.Point(75, 222);
            this.buttonAdministrarSocios.Name = "buttonAdministrarSocios";
            this.buttonAdministrarSocios.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonAdministrarSocios.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonAdministrarSocios.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonAdministrarSocios.Size = new System.Drawing.Size(240, 40);
            this.buttonAdministrarSocios.TabIndex = 7;
            this.buttonAdministrarSocios.Text = "Administrar socios";
            this.buttonAdministrarSocios.TextColor = System.Drawing.Color.Black;
            this.buttonAdministrarSocios.UseVisualStyleBackColor = false;
            this.buttonAdministrarSocios.Click += new System.EventHandler(this.buttonAdministrarSocios_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 401);
            this.Controls.Add(this.buttonAdministrarEventos);
            this.Controls.Add(this.buttonAdministrarSocios);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menú";
            this.Activated += new System.EventHandler(this.FormMenu_Activated);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private AppDesktop.Button_WOC buttonAdministrarSocios;
        private AppDesktop.Button_WOC buttonAdministrarEventos;
    }
}