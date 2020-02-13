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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCatalan = new System.Windows.Forms.Button();
            this.buttonIngles = new System.Windows.Forms.Button();
            this.buttonEntrar = new AppDesktop.Button_WOC();
            this.buttonSpanish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chrysallis.Properties.Resources.logo4;
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCatalan
            // 
            this.buttonCatalan.Location = new System.Drawing.Point(271, 368);
            this.buttonCatalan.Name = "buttonCatalan";
            this.buttonCatalan.Size = new System.Drawing.Size(75, 23);
            this.buttonCatalan.TabIndex = 7;
            this.buttonCatalan.Text = "Catalan";
            this.buttonCatalan.UseVisualStyleBackColor = true;
            this.buttonCatalan.Click += new System.EventHandler(this.buttonCatalan_Click);
            // 
            // buttonIngles
            // 
            this.buttonIngles.Location = new System.Drawing.Point(190, 368);
            this.buttonIngles.Name = "buttonIngles";
            this.buttonIngles.Size = new System.Drawing.Size(75, 23);
            this.buttonIngles.TabIndex = 8;
            this.buttonIngles.Text = "Ingles";
            this.buttonIngles.UseVisualStyleBackColor = true;
            this.buttonIngles.Click += new System.EventHandler(this.buttonIngles_Click);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEntrar.BorderColor = System.Drawing.Color.Black;
            this.buttonEntrar.ButtonColor = System.Drawing.SystemColors.Info;
            this.buttonEntrar.FlatAppearance.BorderSize = 0;
            this.buttonEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonEntrar.Location = new System.Drawing.Point(114, 310);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonEntrar.OnHoverButtonColor = System.Drawing.Color.Azure;
            this.buttonEntrar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonEntrar.Size = new System.Drawing.Size(117, 40);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.TextColor = System.Drawing.Color.Black;
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonSpanish
            // 
            this.buttonSpanish.Location = new System.Drawing.Point(109, 368);
            this.buttonSpanish.Name = "buttonSpanish";
            this.buttonSpanish.Size = new System.Drawing.Size(75, 23);
            this.buttonSpanish.TabIndex = 9;
            this.buttonSpanish.Text = "Castellano";
            this.buttonSpanish.UseVisualStyleBackColor = true;
            this.buttonSpanish.Click += new System.EventHandler(this.buttonSpanish_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 403);
            this.Controls.Add(this.buttonSpanish);
            this.Controls.Add(this.buttonIngles);
            this.Controls.Add(this.buttonCatalan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelContrasenya);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.textBoxUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasenya;
        private AppDesktop.Button_WOC buttonEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCatalan;
        private System.Windows.Forms.Button buttonIngles;
        private System.Windows.Forms.Button buttonSpanish;
    }
}

