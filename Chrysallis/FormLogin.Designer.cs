﻿namespace Chrysallis
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
            this.imagedComboBoxIdiomas = new ComboxExtended.ImagedComboBox();
            this.buttonEntrar = new AppDesktop.Button_WOC();
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
            this.labelUsuario.Location = new System.Drawing.Point(133, 194);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 25);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenya.Location = new System.Drawing.Point(113, 245);
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
            // imagedComboBoxIdiomas
            // 
            this.imagedComboBoxIdiomas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.imagedComboBoxIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagedComboBoxIdiomas.FormattingEnabled = true;
            this.imagedComboBoxIdiomas.Location = new System.Drawing.Point(216, 370);
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
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 403);
            this.Controls.Add(this.imagedComboBoxIdiomas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelContrasenya);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.textBoxUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
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
        private ComboxExtended.ImagedComboBox imagedComboBoxIdiomas;
    }
}

