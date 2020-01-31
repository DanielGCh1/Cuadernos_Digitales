namespace CuadernosDigitales.Forms
{
    partial class NotasMenu
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
            this.nuevaNotaButton = new System.Windows.Forms.Button();
            this.notasMenuPanel = new System.Windows.Forms.Panel();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.LabelFiltro = new System.Windows.Forms.Label();
            this.idPantallaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriasPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.verOcultasButton = new System.Windows.Forms.Button();
            this.notasContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buscaNotaButton = new System.Windows.Forms.Button();
            this.buscarCuadernoTextBox = new System.Windows.Forms.TextBox();
            this.verNotasButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regresarButton = new System.Windows.Forms.Button();
            this.nombreCuadernoLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.ErrorProviderFiltro = new System.Windows.Forms.ErrorProvider(this.components);
            this.notasMenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevaNotaButton
            // 
            this.nuevaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nuevaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.nuevaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaNotaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.nuevaNotaButton.Location = new System.Drawing.Point(13, 49);
            this.nuevaNotaButton.Name = "nuevaNotaButton";
            this.nuevaNotaButton.Size = new System.Drawing.Size(96, 29);
            this.nuevaNotaButton.TabIndex = 3;
            this.nuevaNotaButton.Text = "NUEVA NOTA";
            this.nuevaNotaButton.UseVisualStyleBackColor = false;
            this.nuevaNotaButton.Click += new System.EventHandler(this.NuevaNotaButton_Click);
            // 
            // notasMenuPanel
            // 
            this.notasMenuPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.notasMenuPanel.Controls.Add(this.FiltroComboBox);
            this.notasMenuPanel.Controls.Add(this.LabelFiltro);
            this.notasMenuPanel.Controls.Add(this.idPantallaLabel);
            this.notasMenuPanel.Controls.Add(this.label1);
            this.notasMenuPanel.Controls.Add(this.categoriasPanel);
            this.notasMenuPanel.Controls.Add(this.verOcultasButton);
            this.notasMenuPanel.Controls.Add(this.notasContainer);
            this.notasMenuPanel.Controls.Add(this.buscaNotaButton);
            this.notasMenuPanel.Controls.Add(this.buscarCuadernoTextBox);
            this.notasMenuPanel.Controls.Add(this.nuevaNotaButton);
            this.notasMenuPanel.Controls.Add(this.verNotasButton);
            this.notasMenuPanel.Controls.Add(this.eliminarButton);
            this.notasMenuPanel.Controls.Add(this.panel1);
            this.notasMenuPanel.Controls.Add(this.cancelarButton);
            this.notasMenuPanel.ForeColor = System.Drawing.Color.Black;
            this.notasMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.notasMenuPanel.Name = "notasMenuPanel";
            this.notasMenuPanel.Size = new System.Drawing.Size(800, 533);
            this.notasMenuPanel.TabIndex = 4;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FiltroComboBox.Items.AddRange(new object[] {
            "NOMBRE",
            "CATEGORIA"});
            this.FiltroComboBox.Location = new System.Drawing.Point(348, 50);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(132, 28);
            this.FiltroComboBox.TabIndex = 29;
            // 
            // LabelFiltro
            // 
            this.LabelFiltro.AutoSize = true;
            this.LabelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltro.Location = new System.Drawing.Point(272, 58);
            this.LabelFiltro.Name = "LabelFiltro";
            this.LabelFiltro.Size = new System.Drawing.Size(70, 20);
            this.LabelFiltro.TabIndex = 28;
            this.LabelFiltro.Text = "FILTRO:";
            // 
            // idPantallaLabel
            // 
            this.idPantallaLabel.AutoSize = true;
            this.idPantallaLabel.ForeColor = System.Drawing.Color.Black;
            this.idPantallaLabel.Location = new System.Drawing.Point(17, 517);
            this.idPantallaLabel.Name = "idPantallaLabel";
            this.idPantallaLabel.Size = new System.Drawing.Size(100, 13);
            this.idPantallaLabel.TabIndex = 23;
            this.idPantallaLabel.Text = "ID PANTALLA: 003";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "CATEGORIAS:";
            // 
            // categoriasPanel
            // 
            this.categoriasPanel.BackColor = System.Drawing.Color.White;
            this.categoriasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoriasPanel.Location = new System.Drawing.Point(13, 107);
            this.categoriasPanel.Name = "categoriasPanel";
            this.categoriasPanel.Size = new System.Drawing.Size(775, 40);
            this.categoriasPanel.TabIndex = 17;
            this.categoriasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.categoriasPanel_Paint);
            // 
            // verOcultasButton
            // 
            this.verOcultasButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verOcultasButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.verOcultasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.verOcultasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verOcultasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verOcultasButton.ForeColor = System.Drawing.Color.LightGray;
            this.verOcultasButton.Location = new System.Drawing.Point(129, 49);
            this.verOcultasButton.Name = "verOcultasButton";
            this.verOcultasButton.Size = new System.Drawing.Size(137, 29);
            this.verOcultasButton.TabIndex = 14;
            this.verOcultasButton.Text = "VER OCULTAS";
            this.verOcultasButton.UseVisualStyleBackColor = false;
            this.verOcultasButton.Click += new System.EventHandler(this.VerOcultasButton_Click);
            // 
            // notasContainer
            // 
            this.notasContainer.AutoScroll = true;
            this.notasContainer.Location = new System.Drawing.Point(13, 154);
            this.notasContainer.Name = "notasContainer";
            this.notasContainer.Size = new System.Drawing.Size(776, 360);
            this.notasContainer.TabIndex = 11;
            // 
            // buscaNotaButton
            // 
            this.buscaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buscaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buscaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaNotaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.buscaNotaButton.Location = new System.Drawing.Point(688, 49);
            this.buscaNotaButton.Name = "buscaNotaButton";
            this.buscaNotaButton.Size = new System.Drawing.Size(66, 27);
            this.buscaNotaButton.TabIndex = 7;
            this.buscaNotaButton.Text = "BUSCAR";
            this.buscaNotaButton.UseVisualStyleBackColor = false;
            this.buscaNotaButton.Click += new System.EventHandler(this.BuscaNotaButton_Click);
            // 
            // buscarCuadernoTextBox
            // 
            this.buscarCuadernoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCuadernoTextBox.Location = new System.Drawing.Point(497, 51);
            this.buscarCuadernoTextBox.Name = "buscarCuadernoTextBox";
            this.buscarCuadernoTextBox.Size = new System.Drawing.Size(185, 26);
            this.buscarCuadernoTextBox.TabIndex = 6;
            // 
            // verNotasButton
            // 
            this.verNotasButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verNotasButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.verNotasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.verNotasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verNotasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verNotasButton.ForeColor = System.Drawing.Color.LightGray;
            this.verNotasButton.Location = new System.Drawing.Point(13, 49);
            this.verNotasButton.Name = "verNotasButton";
            this.verNotasButton.Size = new System.Drawing.Size(201, 28);
            this.verNotasButton.TabIndex = 13;
            this.verNotasButton.Text = "VER TODAS LAS NOTAS";
            this.verNotasButton.UseVisualStyleBackColor = false;
            this.verNotasButton.Visible = false;
            this.verNotasButton.Click += new System.EventHandler(this.VerNotasButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.ForeColor = System.Drawing.Color.LightGray;
            this.eliminarButton.Location = new System.Drawing.Point(13, 48);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(68, 28);
            this.eliminarButton.TabIndex = 15;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Visible = false;
            this.eliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.regresarButton);
            this.panel1.Controls.Add(this.nombreCuadernoLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 18;
            // 
            // regresarButton
            // 
            this.regresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresarButton.Image = global::CuadernosDigitales.Properties.Resources.back;
            this.regresarButton.Location = new System.Drawing.Point(2, 2);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(79, 28);
            this.regresarButton.TabIndex = 12;
            this.regresarButton.Text = "Regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            this.regresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // nombreCuadernoLabel
            // 
            this.nombreCuadernoLabel.AutoSize = true;
            this.nombreCuadernoLabel.BackColor = System.Drawing.Color.Silver;
            this.nombreCuadernoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoLabel.Location = new System.Drawing.Point(298, 5);
            this.nombreCuadernoLabel.Name = "nombreCuadernoLabel";
            this.nombreCuadernoLabel.Size = new System.Drawing.Size(276, 25);
            this.nombreCuadernoLabel.TabIndex = 8;
            this.nombreCuadernoLabel.Text = "NOMBRE DEL CUADERNO";
            this.nombreCuadernoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.Color.LightGray;
            this.cancelarButton.Location = new System.Drawing.Point(87, 49);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(84, 29);
            this.cancelarButton.TabIndex = 16;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Visible = false;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ErrorProviderFiltro
            // 
            this.ErrorProviderFiltro.ContainerControl = this;
            // 
            // NotasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.notasMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuadernoAbierto";
            this.Load += new System.EventHandler(this.NotasMenu_Load);
            this.notasMenuPanel.ResumeLayout(false);
            this.notasMenuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nuevaNotaButton;
        private System.Windows.Forms.Panel notasMenuPanel;
        private System.Windows.Forms.Button buscaNotaButton;
        private System.Windows.Forms.TextBox buscarCuadernoTextBox;
        private System.Windows.Forms.Label nombreCuadernoLabel;
        private System.Windows.Forms.FlowLayoutPanel notasContainer;
        private System.Windows.Forms.Button verNotasButton;
        private System.Windows.Forms.Button verOcultasButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.FlowLayoutPanel categoriasPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button regresarButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label idPantallaLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label LabelFiltro;
        private System.Windows.Forms.ErrorProvider ErrorProviderFiltro;
    }
}