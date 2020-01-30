namespace CuadernosDigitales.Forms
{
    partial class NuevoCuaderno
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
            this.nombreCuadernoTextBox = new System.Windows.Forms.TextBox();
            this.nombreCuadernoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.agregarCategoriaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nuevoCuadernoPanel = new System.Windows.Forms.Panel();
            this.LabelMinimoYMaximoDeCaracteresPorCategoria = new System.Windows.Forms.Label();
            this.LabelMinimoYMaximoCaracteresParaNombre = new System.Windows.Forms.Label();
            this.idPantallaLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorSeleccionadoPanel = new System.Windows.Forms.Panel();
            this.coloresPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.deepSkyBlueButton = new System.Windows.Forms.Button();
            this.deepPinkButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.grayButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.cabezaPanel = new System.Windows.Forms.Panel();
            this.closeNuevoCuadernoButton = new System.Windows.Forms.Button();
            this.nuevoCuadernoLabel = new System.Windows.Forms.Label();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.crearCuadernoButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.nuevoCuadernoPanel.SuspendLayout();
            this.coloresPanel.SuspendLayout();
            this.cabezaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreCuadernoTextBox
            // 
            this.nombreCuadernoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoTextBox.Location = new System.Drawing.Point(177, 92);
            this.nombreCuadernoTextBox.MaxLength = 25;
            this.nombreCuadernoTextBox.Name = "nombreCuadernoTextBox";
            this.nombreCuadernoTextBox.Size = new System.Drawing.Size(456, 26);
            this.nombreCuadernoTextBox.TabIndex = 0;
            // 
            // nombreCuadernoLabel
            // 
            this.nombreCuadernoLabel.AutoSize = true;
            this.nombreCuadernoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoLabel.Location = new System.Drawing.Point(46, 99);
            this.nombreCuadernoLabel.Name = "nombreCuadernoLabel";
            this.nombreCuadernoLabel.Size = new System.Drawing.Size(88, 20);
            this.nombreCuadernoLabel.TabIndex = 2;
            this.nombreCuadernoLabel.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATEGORIAS:";
            // 
            // agregarCategoriaButton
            // 
            this.agregarCategoriaButton.BackColor = System.Drawing.Color.Green;
            this.agregarCategoriaButton.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarCategoriaButton.Location = new System.Drawing.Point(135, 172);
            this.agregarCategoriaButton.Name = "agregarCategoriaButton";
            this.agregarCategoriaButton.Size = new System.Drawing.Size(27, 27);
            this.agregarCategoriaButton.TabIndex = 5;
            this.agregarCategoriaButton.Text = "+";
            this.agregarCategoriaButton.UseVisualStyleBackColor = false;
            this.agregarCategoriaButton.Click += new System.EventHandler(this.AgregarCategoriaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "(max 9)";
            // 
            // nuevoCuadernoPanel
            // 
            this.nuevoCuadernoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.nuevoCuadernoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nuevoCuadernoPanel.Controls.Add(this.LabelMinimoYMaximoDeCaracteresPorCategoria);
            this.nuevoCuadernoPanel.Controls.Add(this.LabelMinimoYMaximoCaracteresParaNombre);
            this.nuevoCuadernoPanel.Controls.Add(this.idPantallaLabel);
            this.nuevoCuadernoPanel.Controls.Add(this.flowLayoutPanel1);
            this.nuevoCuadernoPanel.Controls.Add(this.colorSeleccionadoPanel);
            this.nuevoCuadernoPanel.Controls.Add(this.coloresPanel);
            this.nuevoCuadernoPanel.Controls.Add(this.cabezaPanel);
            this.nuevoCuadernoPanel.Controls.Add(this.closeAppButton);
            this.nuevoCuadernoPanel.Controls.Add(this.crearCuadernoButton);
            this.nuevoCuadernoPanel.Controls.Add(this.colorLabel);
            this.nuevoCuadernoPanel.Controls.Add(this.agregarCategoriaButton);
            this.nuevoCuadernoPanel.Controls.Add(this.label2);
            this.nuevoCuadernoPanel.Controls.Add(this.nombreCuadernoLabel);
            this.nuevoCuadernoPanel.Controls.Add(this.label1);
            this.nuevoCuadernoPanel.Controls.Add(this.nombreCuadernoTextBox);
            this.nuevoCuadernoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nuevoCuadernoPanel.ForeColor = System.Drawing.Color.Black;
            this.nuevoCuadernoPanel.Location = new System.Drawing.Point(0, 0);
            this.nuevoCuadernoPanel.Name = "nuevoCuadernoPanel";
            this.nuevoCuadernoPanel.Size = new System.Drawing.Size(696, 471);
            this.nuevoCuadernoPanel.TabIndex = 9;
            // 
            // LabelMinimoYMaximoDeCaracteresPorCategoria
            // 
            this.LabelMinimoYMaximoDeCaracteresPorCategoria.AutoSize = true;
            this.LabelMinimoYMaximoDeCaracteresPorCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelMinimoYMaximoDeCaracteresPorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinimoYMaximoDeCaracteresPorCategoria.Location = new System.Drawing.Point(174, 277);
            this.LabelMinimoYMaximoDeCaracteresPorCategoria.Name = "LabelMinimoYMaximoDeCaracteresPorCategoria";
            this.LabelMinimoYMaximoDeCaracteresPorCategoria.Size = new System.Drawing.Size(359, 17);
            this.LabelMinimoYMaximoDeCaracteresPorCategoria.TabIndex = 27;
            this.LabelMinimoYMaximoDeCaracteresPorCategoria.Text = "NOTA: Minimo 3 a Maximo 45 Caracteres por categoria.";
            // 
            // LabelMinimoYMaximoCaracteresParaNombre
            // 
            this.LabelMinimoYMaximoCaracteresParaNombre.AutoSize = true;
            this.LabelMinimoYMaximoCaracteresParaNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelMinimoYMaximoCaracteresParaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinimoYMaximoCaracteresParaNombre.Location = new System.Drawing.Point(174, 121);
            this.LabelMinimoYMaximoCaracteresParaNombre.Name = "LabelMinimoYMaximoCaracteresParaNombre";
            this.LabelMinimoYMaximoCaracteresParaNombre.Size = new System.Drawing.Size(369, 17);
            this.LabelMinimoYMaximoCaracteresParaNombre.TabIndex = 26;
            this.LabelMinimoYMaximoCaracteresParaNombre.Text = "NOTA: Minimo 3 a Maximo 45 caracteres para el nombre.";
            // 
            // idPantallaLabel
            // 
            this.idPantallaLabel.AutoSize = true;
            this.idPantallaLabel.ForeColor = System.Drawing.Color.Black;
            this.idPantallaLabel.Location = new System.Drawing.Point(11, 448);
            this.idPantallaLabel.Name = "idPantallaLabel";
            this.idPantallaLabel.Size = new System.Drawing.Size(106, 13);
            this.idPantallaLabel.TabIndex = 25;
            this.idPantallaLabel.Text = "ID PANTALLA: 0021";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(177, 172);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 102);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // colorSeleccionadoPanel
            // 
            this.colorSeleccionadoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSeleccionadoPanel.Location = new System.Drawing.Point(177, 302);
            this.colorSeleccionadoPanel.Name = "colorSeleccionadoPanel";
            this.colorSeleccionadoPanel.Size = new System.Drawing.Size(26, 24);
            this.colorSeleccionadoPanel.TabIndex = 16;
            // 
            // coloresPanel
            // 
            this.coloresPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coloresPanel.Controls.Add(this.greenButton);
            this.coloresPanel.Controls.Add(this.redButton);
            this.coloresPanel.Controls.Add(this.orangeButton);
            this.coloresPanel.Controls.Add(this.yellowButton);
            this.coloresPanel.Controls.Add(this.blueButton);
            this.coloresPanel.Controls.Add(this.deepSkyBlueButton);
            this.coloresPanel.Controls.Add(this.deepPinkButton);
            this.coloresPanel.Controls.Add(this.pinkButton);
            this.coloresPanel.Controls.Add(this.purpleButton);
            this.coloresPanel.Controls.Add(this.whiteButton);
            this.coloresPanel.Controls.Add(this.grayButton);
            this.coloresPanel.Controls.Add(this.blackButton);
            this.coloresPanel.Location = new System.Drawing.Point(213, 302);
            this.coloresPanel.Name = "coloresPanel";
            this.coloresPanel.Size = new System.Drawing.Size(148, 111);
            this.coloresPanel.TabIndex = 10;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(3, 3);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(30, 30);
            this.greenButton.TabIndex = 0;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.ForeColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(39, 3);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(30, 30);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.Orange;
            this.orangeButton.Location = new System.Drawing.Point(75, 3);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(30, 30);
            this.orangeButton.TabIndex = 2;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(111, 3);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(30, 30);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(3, 39);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(30, 30);
            this.blueButton.TabIndex = 4;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // deepSkyBlueButton
            // 
            this.deepSkyBlueButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deepSkyBlueButton.Location = new System.Drawing.Point(39, 39);
            this.deepSkyBlueButton.Name = "deepSkyBlueButton";
            this.deepSkyBlueButton.Size = new System.Drawing.Size(30, 30);
            this.deepSkyBlueButton.TabIndex = 7;
            this.deepSkyBlueButton.UseVisualStyleBackColor = false;
            this.deepSkyBlueButton.Click += new System.EventHandler(this.DeepSkyBlueButton_Click);
            // 
            // deepPinkButton
            // 
            this.deepPinkButton.BackColor = System.Drawing.Color.DeepPink;
            this.deepPinkButton.Location = new System.Drawing.Point(75, 39);
            this.deepPinkButton.Name = "deepPinkButton";
            this.deepPinkButton.Size = new System.Drawing.Size(30, 30);
            this.deepPinkButton.TabIndex = 10;
            this.deepPinkButton.UseVisualStyleBackColor = false;
            this.deepPinkButton.Click += new System.EventHandler(this.DeepPinkButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.Pink;
            this.pinkButton.Location = new System.Drawing.Point(111, 39);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(30, 30);
            this.pinkButton.TabIndex = 6;
            this.pinkButton.UseVisualStyleBackColor = false;
            this.pinkButton.Click += new System.EventHandler(this.PinkButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.Purple;
            this.purpleButton.Location = new System.Drawing.Point(3, 75);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(30, 30);
            this.purpleButton.TabIndex = 5;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(39, 75);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(30, 30);
            this.whiteButton.TabIndex = 8;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // grayButton
            // 
            this.grayButton.BackColor = System.Drawing.Color.Gray;
            this.grayButton.Location = new System.Drawing.Point(75, 75);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(30, 30);
            this.grayButton.TabIndex = 9;
            this.grayButton.UseVisualStyleBackColor = false;
            this.grayButton.Click += new System.EventHandler(this.GrayButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.Location = new System.Drawing.Point(111, 75);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(30, 30);
            this.blackButton.TabIndex = 11;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.BlackButton_Click);
            // 
            // cabezaPanel
            // 
            this.cabezaPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.cabezaPanel.Controls.Add(this.closeNuevoCuadernoButton);
            this.cabezaPanel.Controls.Add(this.nuevoCuadernoLabel);
            this.cabezaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabezaPanel.Location = new System.Drawing.Point(0, 0);
            this.cabezaPanel.Name = "cabezaPanel";
            this.cabezaPanel.Size = new System.Drawing.Size(694, 46);
            this.cabezaPanel.TabIndex = 14;
            this.cabezaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CabezaPanel_MouseDown);
            // 
            // closeNuevoCuadernoButton
            // 
            this.closeNuevoCuadernoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeNuevoCuadernoButton.BackColor = System.Drawing.Color.Red;
            this.closeNuevoCuadernoButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeNuevoCuadernoButton.FlatAppearance.BorderSize = 2;
            this.closeNuevoCuadernoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeNuevoCuadernoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeNuevoCuadernoButton.Location = new System.Drawing.Point(650, 12);
            this.closeNuevoCuadernoButton.Name = "closeNuevoCuadernoButton";
            this.closeNuevoCuadernoButton.Size = new System.Drawing.Size(32, 23);
            this.closeNuevoCuadernoButton.TabIndex = 0;
            this.closeNuevoCuadernoButton.Text = "X";
            this.closeNuevoCuadernoButton.UseVisualStyleBackColor = false;
            this.closeNuevoCuadernoButton.Click += new System.EventHandler(this.CloseNuevoCuadernoButton_Click);
            // 
            // nuevoCuadernoLabel
            // 
            this.nuevoCuadernoLabel.AutoSize = true;
            this.nuevoCuadernoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCuadernoLabel.Location = new System.Drawing.Point(265, 9);
            this.nuevoCuadernoLabel.Name = "nuevoCuadernoLabel";
            this.nuevoCuadernoLabel.Size = new System.Drawing.Size(275, 31);
            this.nuevoCuadernoLabel.TabIndex = 1;
            this.nuevoCuadernoLabel.Text = "NUEVO CUADERNO";
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderSize = 2;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeAppButton.Location = new System.Drawing.Point(651, 12);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(32, 23);
            this.closeAppButton.TabIndex = 13;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = false;
            // 
            // crearCuadernoButton
            // 
            this.crearCuadernoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crearCuadernoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.crearCuadernoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.crearCuadernoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearCuadernoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearCuadernoButton.ForeColor = System.Drawing.Color.LightGray;
            this.crearCuadernoButton.Location = new System.Drawing.Point(438, 424);
            this.crearCuadernoButton.Name = "crearCuadernoButton";
            this.crearCuadernoButton.Size = new System.Drawing.Size(244, 34);
            this.crearCuadernoButton.TabIndex = 12;
            this.crearCuadernoButton.Text = "CREAR NUEVO CUADERNO";
            this.crearCuadernoButton.UseVisualStyleBackColor = false;
            this.crearCuadernoButton.Click += new System.EventHandler(this.CrearCuadernoButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(65, 307);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(69, 20);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "COLOR:";
            // 
            // NuevoCuaderno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 471);
            this.Controls.Add(this.nuevoCuadernoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoCuaderno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cuaderno";
            this.Load += new System.EventHandler(this.NuevoCuaderno_Load);
            this.nuevoCuadernoPanel.ResumeLayout(false);
            this.nuevoCuadernoPanel.PerformLayout();
            this.coloresPanel.ResumeLayout(false);
            this.cabezaPanel.ResumeLayout(false);
            this.cabezaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nombreCuadernoTextBox;
        private System.Windows.Forms.Label nombreCuadernoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button agregarCategoriaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel nuevoCuadernoPanel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.FlowLayoutPanel coloresPanel;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button deepSkyBlueButton;
        private System.Windows.Forms.Button deepPinkButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button grayButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button crearCuadernoButton;
        private System.Windows.Forms.Panel colorSeleccionadoPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel cabezaPanel;
        private System.Windows.Forms.Button closeNuevoCuadernoButton;
        private System.Windows.Forms.Label nuevoCuadernoLabel;
        private System.Windows.Forms.Button closeAppButton;
        public System.Windows.Forms.Label idPantallaLabel;
        private System.Windows.Forms.Label LabelMinimoYMaximoDeCaracteresPorCategoria;
        private System.Windows.Forms.Label LabelMinimoYMaximoCaracteresParaNombre;
    }
}