namespace Chrysallis
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.button_WOCGestionar = new AppDesktop.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::Chrysallis.Properties.Resources.logo4;
            this.pictureBoxLogo.Location = new System.Drawing.Point(78, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(188, 174);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(57, 222);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(229, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(57, 273);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(229, 20);
            this.textBoxContrasenya.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(136, 194);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 25);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenya.Location = new System.Drawing.Point(117, 245);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(114, 25);
            this.labelContrasenya.TabIndex = 4;
            this.labelContrasenya.Text = "Contraseña";
            // 
            // button_WOCGestionar
            // 
            this.button_WOCGestionar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOCGestionar.BorderColor = System.Drawing.Color.Black;
            this.button_WOCGestionar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOCGestionar.FlatAppearance.BorderSize = 0;
            this.button_WOCGestionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOCGestionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOCGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCGestionar.Font = new System.Drawing.Font("Consolas", 12F);
            this.button_WOCGestionar.Location = new System.Drawing.Point(114, 310);
            this.button_WOCGestionar.Name = "button_WOCGestionar";
            this.button_WOCGestionar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOCGestionar.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.button_WOCGestionar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOCGestionar.Size = new System.Drawing.Size(117, 40);
            this.button_WOCGestionar.TabIndex = 5;
            this.button_WOCGestionar.Text = "Gestionar";
            this.button_WOCGestionar.TextColor = System.Drawing.Color.Black;
            this.button_WOCGestionar.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 383);
            this.Controls.Add(this.button_WOCGestionar);
            this.Controls.Add(this.labelContrasenya);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasenya;
        private AppDesktop.Button_WOC button_WOCGestionar;
    }
}

