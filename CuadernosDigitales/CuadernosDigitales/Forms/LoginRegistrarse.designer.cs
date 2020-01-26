namespace CuadernosDigitales.Forms
{
    partial class LoginRegistrarse
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
            this.closeAppButton = new System.Windows.Forms.Button();
            this.cabezaPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.ButtonRegistrar = new System.Windows.Forms.Button();
            this.TextBoxContraseña = new System.Windows.Forms.TextBox();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.TextBoxRepetirContraseña = new System.Windows.Forms.TextBox();
            this.LabelRepetirContraseña = new System.Windows.Forms.Label();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRepetirContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.TextBoxNombreRealUsuario = new System.Windows.Forms.TextBox();
            this.LabelNombreRealUsuario = new System.Windows.Forms.Label();
            this.cabezaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRepetirContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderSize = 2;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeAppButton.Location = new System.Drawing.Point(485, 12);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(32, 23);
            this.closeAppButton.TabIndex = 0;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = false;
            this.closeAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // cabezaPanel
            // 
            this.cabezaPanel.BackColor = System.Drawing.Color.Black;
            this.cabezaPanel.Controls.Add(this.pictureBox1);
            this.cabezaPanel.Controls.Add(this.LabelTitulo);
            this.cabezaPanel.Controls.Add(this.closeAppButton);
            this.cabezaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabezaPanel.Location = new System.Drawing.Point(0, 0);
            this.cabezaPanel.Name = "cabezaPanel";
            this.cabezaPanel.Size = new System.Drawing.Size(529, 162);
            this.cabezaPanel.TabIndex = 1;
            this.cabezaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CabezaPanel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CuadernosDigitales.Properties.Resources.azul;
            this.pictureBox1.Location = new System.Drawing.Point(199, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTitulo.Location = new System.Drawing.Point(164, 125);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(200, 24);
            this.LabelTitulo.TabIndex = 12;
            this.LabelTitulo.Text = "Crear nuevo usuario";
            // 
            // ButtonRegistrar
            // 
            this.ButtonRegistrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegistrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonRegistrar.Location = new System.Drawing.Point(380, 328);
            this.ButtonRegistrar.Name = "ButtonRegistrar";
            this.ButtonRegistrar.Size = new System.Drawing.Size(94, 33);
            this.ButtonRegistrar.TabIndex = 9;
            this.ButtonRegistrar.Text = "Registrar";
            this.ButtonRegistrar.UseVisualStyleBackColor = false;
            this.ButtonRegistrar.Click += new System.EventHandler(this.ButtonRegistrar_Click);
            // 
            // TextBoxContraseña
            // 
            this.TextBoxContraseña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContraseña.Location = new System.Drawing.Point(229, 249);
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            this.TextBoxContraseña.PasswordChar = '*';
            this.TextBoxContraseña.Size = new System.Drawing.Size(141, 23);
            this.TextBoxContraseña.TabIndex = 8;
            this.TextBoxContraseña.Leave += new System.EventHandler(this.TextBoxContraseña_Leave);
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsuario.Location = new System.Drawing.Point(230, 209);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(141, 23);
            this.TextBoxUsuario.TabIndex = 7;
            this.TextBoxUsuario.Leave += new System.EventHandler(this.TextBoxUsuario_Leave);
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraseña.Location = new System.Drawing.Point(89, 249);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(96, 17);
            this.LabelContraseña.TabIndex = 6;
            this.LabelContraseña.Text = "Contraseña:";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(52, 209);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(153, 17);
            this.LabelUsuario.TabIndex = 5;
            this.LabelUsuario.Text = "Nombre de Usuario:";
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancelar.ForeColor = System.Drawing.Color.Red;
            this.ButtonCancelar.Location = new System.Drawing.Point(65, 326);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(94, 33);
            this.ButtonCancelar.TabIndex = 10;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = false;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // TextBoxRepetirContraseña
            // 
            this.TextBoxRepetirContraseña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxRepetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRepetirContraseña.Location = new System.Drawing.Point(229, 293);
            this.TextBoxRepetirContraseña.Name = "TextBoxRepetirContraseña";
            this.TextBoxRepetirContraseña.PasswordChar = '*';
            this.TextBoxRepetirContraseña.Size = new System.Drawing.Size(141, 23);
            this.TextBoxRepetirContraseña.TabIndex = 12;
            this.TextBoxRepetirContraseña.Leave += new System.EventHandler(this.TextBoxRepetirContraseña_Leave);
            // 
            // LabelRepetirContraseña
            // 
            this.LabelRepetirContraseña.AutoSize = true;
            this.LabelRepetirContraseña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelRepetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRepetirContraseña.Location = new System.Drawing.Point(61, 293);
            this.LabelRepetirContraseña.Name = "LabelRepetirContraseña";
            this.LabelRepetirContraseña.Size = new System.Drawing.Size(152, 17);
            this.LabelRepetirContraseña.TabIndex = 11;
            this.LabelRepetirContraseña.Text = "Repetir contraseña:";
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // errorProviderContraseña
            // 
            this.errorProviderContraseña.ContainerControl = this;
            // 
            // errorProviderRepetirContraseña
            // 
            this.errorProviderRepetirContraseña.ContainerControl = this;
            // 
            // TextBoxNombreRealUsuario
            // 
            this.TextBoxNombreRealUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxNombreRealUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNombreRealUsuario.Location = new System.Drawing.Point(230, 175);
            this.TextBoxNombreRealUsuario.Name = "TextBoxNombreRealUsuario";
            this.TextBoxNombreRealUsuario.Size = new System.Drawing.Size(141, 23);
            this.TextBoxNombreRealUsuario.TabIndex = 14;
            // 
            // LabelNombreRealUsuario
            // 
            this.LabelNombreRealUsuario.AutoSize = true;
            this.LabelNombreRealUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelNombreRealUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreRealUsuario.Location = new System.Drawing.Point(52, 175);
            this.LabelNombreRealUsuario.Name = "LabelNombreRealUsuario";
            this.LabelNombreRealUsuario.Size = new System.Drawing.Size(168, 17);
            this.LabelNombreRealUsuario.TabIndex = 13;
            this.LabelNombreRealUsuario.Text = "Nombre Real Usuario:";
            // 
            // LoginRegistrarse
            // 
            this.AcceptButton = this.ButtonRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancelar;
            this.ClientSize = new System.Drawing.Size(529, 373);
            this.Controls.Add(this.TextBoxNombreRealUsuario);
            this.Controls.Add(this.LabelNombreRealUsuario);
            this.Controls.Add(this.TextBoxRepetirContraseña);
            this.Controls.Add(this.LabelRepetirContraseña);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonRegistrar);
            this.Controls.Add(this.TextBoxContraseña);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.LabelContraseña);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.cabezaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadernos Digitales";
            this.cabezaPanel.ResumeLayout(false);
            this.cabezaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRepetirContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Panel cabezaPanel;
        private System.Windows.Forms.Button ButtonRegistrar;
        private System.Windows.Forms.TextBox TextBoxContraseña;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.TextBox TextBoxRepetirContraseña;
        private System.Windows.Forms.Label LabelRepetirContraseña;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.ErrorProvider errorProviderContraseña;
        private System.Windows.Forms.ErrorProvider errorProviderRepetirContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxNombreRealUsuario;
        private System.Windows.Forms.Label LabelNombreRealUsuario;
    }
}

