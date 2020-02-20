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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagedComboBoxIdiomas = new ComboxExtended.ImagedComboBox();
            this.buttonEntrar = new AppDesktop.Button_WOC();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(57, 222);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(229, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(57, 273);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(229, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(52, 185);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(234, 25);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Usuari";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(52, 245);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(234, 25);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Contrasenya";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // imagedComboBoxIdiomas
            // 
            this.imagedComboBoxIdiomas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.imagedComboBoxIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagedComboBoxIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imagedComboBoxIdiomas.FormattingEnabled = true;
            this.imagedComboBoxIdiomas.Location = new System.Drawing.Point(234, 376);
            this.imagedComboBoxIdiomas.Name = "imagedComboBoxIdiomas";
            this.imagedComboBoxIdiomas.Size = new System.Drawing.Size(121, 21);
            this.imagedComboBoxIdiomas.TabIndex = 10;
            this.imagedComboBoxIdiomas.SelectedIndexChanged += new System.EventHandler(this.imagedComboBoxIdiomas_SelectedIndexChanged);
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
            // pictureBoxShow
            // 
            this.pictureBoxShow.Image = global::Chrysallis.Properties.Resources.ojo;
            this.pictureBoxShow.Location = new System.Drawing.Point(291, 273);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(23, 19);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 11;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 403);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.imagedComboBoxIdiomas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private AppDesktop.Button_WOC buttonEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComboxExtended.ImagedComboBox imagedComboBoxIdiomas;
        private System.Windows.Forms.PictureBox pictureBoxShow;
    }
}

