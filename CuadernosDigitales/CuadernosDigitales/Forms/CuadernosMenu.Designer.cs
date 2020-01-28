namespace CuadernosDigitales.Forms
{
    partial class CuadernosMenu
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
            this.nuevoCuadernoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buscarCuadernoTextBox = new System.Windows.Forms.TextBox();
            this.inicioPanel = new System.Windows.Forms.Panel();
            this.idPantallaLabel = new System.Windows.Forms.Label();
            this.cuadernosContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buscaNotaButton = new System.Windows.Forms.Button();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.atrasButton = new System.Windows.Forms.Button();
            this.LabelFiltro = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.ErrorProviderFiltro = new System.Windows.Forms.ErrorProvider(this.components);
            this.inicioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoCuadernoButton
            // 
            this.nuevoCuadernoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nuevoCuadernoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.nuevoCuadernoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoCuadernoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCuadernoButton.ForeColor = System.Drawing.Color.LightGray;
            this.nuevoCuadernoButton.Location = new System.Drawing.Point(15, 13);
            this.nuevoCuadernoButton.Name = "nuevoCuadernoButton";
            this.nuevoCuadernoButton.Size = new System.Drawing.Size(165, 34);
            this.nuevoCuadernoButton.TabIndex = 0;
            this.nuevoCuadernoButton.Text = "NUEVO CUADERNO";
            this.nuevoCuadernoButton.UseVisualStyleBackColor = false;
            this.nuevoCuadernoButton.Click += new System.EventHandler(this.NuevoCuadernoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(816, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buscarCuadernoTextBox
            // 
            this.buscarCuadernoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarCuadernoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCuadernoTextBox.Location = new System.Drawing.Point(965, 18);
            this.buscarCuadernoTextBox.Name = "buscarCuadernoTextBox";
            this.buscarCuadernoTextBox.Size = new System.Drawing.Size(202, 24);
            this.buscarCuadernoTextBox.TabIndex = 4;
            // 
            // inicioPanel
            // 
            this.inicioPanel.BackColor = System.Drawing.Color.White;
            this.inicioPanel.Controls.Add(this.FiltroComboBox);
            this.inicioPanel.Controls.Add(this.LabelFiltro);
            this.inicioPanel.Controls.Add(this.nuevoCuadernoButton);
            this.inicioPanel.Controls.Add(this.idPantallaLabel);
            this.inicioPanel.Controls.Add(this.cuadernosContainer);
            this.inicioPanel.Controls.Add(this.buscaNotaButton);
            this.inicioPanel.Controls.Add(this.buscarTextBox);
            this.inicioPanel.Controls.Add(this.button2);
            this.inicioPanel.Controls.Add(this.buscarCuadernoTextBox);
            this.inicioPanel.Controls.Add(this.eliminarButton);
            this.inicioPanel.Controls.Add(this.atrasButton);
            this.inicioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicioPanel.Location = new System.Drawing.Point(0, 0);
            this.inicioPanel.Name = "inicioPanel";
            this.inicioPanel.Size = new System.Drawing.Size(800, 545);
            this.inicioPanel.TabIndex = 5;
            // 
            // idPantallaLabel
            // 
            this.idPantallaLabel.AutoSize = true;
            this.idPantallaLabel.ForeColor = System.Drawing.Color.Black;
            this.idPantallaLabel.Location = new System.Drawing.Point(18, 518);
            this.idPantallaLabel.Name = "idPantallaLabel";
            this.idPantallaLabel.Size = new System.Drawing.Size(100, 13);
            this.idPantallaLabel.TabIndex = 22;
            this.idPantallaLabel.Text = "ID PANTALLA: 002";
            // 
            // cuadernosContainer
            // 
            this.cuadernosContainer.AutoScroll = true;
            this.cuadernosContainer.BackColor = System.Drawing.Color.White;
            this.cuadernosContainer.Location = new System.Drawing.Point(15, 69);
            this.cuadernosContainer.Margin = new System.Windows.Forms.Padding(15);
            this.cuadernosContainer.Name = "cuadernosContainer";
            this.cuadernosContainer.Size = new System.Drawing.Size(770, 441);
            this.cuadernosContainer.TabIndex = 10;
            // 
            // buscaNotaButton
            // 
            this.buscaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buscaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buscaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaNotaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.buscaNotaButton.Location = new System.Drawing.Point(697, 12);
            this.buscaNotaButton.Name = "buscaNotaButton";
            this.buscaNotaButton.Size = new System.Drawing.Size(88, 34);
            this.buscaNotaButton.TabIndex = 9;
            this.buscaNotaButton.Text = "BUSCAR";
            this.buscaNotaButton.UseVisualStyleBackColor = false;
            this.buscaNotaButton.Click += new System.EventHandler(this.BuscaNotaButton_Click);
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTextBox.Location = new System.Drawing.Point(523, 22);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(168, 24);
            this.buscarTextBox.TabIndex = 8;
            this.buscarTextBox.TextChanged += new System.EventHandler(this.BuscarTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(1173, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.ForeColor = System.Drawing.Color.LightGray;
            this.eliminarButton.Location = new System.Drawing.Point(186, 13);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(92, 34);
            this.eliminarButton.TabIndex = 12;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Visible = false;
            this.eliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // atrasButton
            // 
            this.atrasButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.atrasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.atrasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atrasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atrasButton.ForeColor = System.Drawing.Color.LightGray;
            this.atrasButton.Location = new System.Drawing.Point(21, 13);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(85, 34);
            this.atrasButton.TabIndex = 13;
            this.atrasButton.Text = "ATRAS";
            this.atrasButton.UseVisualStyleBackColor = false;
            this.atrasButton.Visible = false;
            this.atrasButton.Click += new System.EventHandler(this.AtrasButton_Click);
            // 
            // LabelFiltro
            // 
            this.LabelFiltro.AutoSize = true;
            this.LabelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltro.Location = new System.Drawing.Point(284, 22);
            this.LabelFiltro.Name = "LabelFiltro";
            this.LabelFiltro.Size = new System.Drawing.Size(70, 20);
            this.LabelFiltro.TabIndex = 27;
            this.LabelFiltro.Text = "FILTRO:";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FiltroComboBox.Items.AddRange(new object[] {
            "NOMBRE",
            "CATEGORIA"});
            this.FiltroComboBox.Location = new System.Drawing.Point(351, 18);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(132, 28);
            this.FiltroComboBox.TabIndex = 28;
            // 
            // ErrorProviderFiltro
            // 
            this.ErrorProviderFiltro.ContainerControl = this;
            // 
            // Cuadernos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.inicioPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuadernos";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Cuadernos_Load);
            this.inicioPanel.ResumeLayout(false);
            this.inicioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevoCuadernoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox buscarCuadernoTextBox;
        private System.Windows.Forms.Panel inicioPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buscaNotaButton;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.FlowLayoutPanel cuadernosContainer;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button atrasButton;
        public System.Windows.Forms.Label idPantallaLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label LabelFiltro;
        private System.Windows.Forms.ErrorProvider ErrorProviderFiltro;
    }
}