namespace WindowsForms
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            Materias = new Button();
            Planes = new Button();
            PersonasButton = new Button();
            comisionesButton = new Button();
            especialidadButton = new Button();
            usuarioButton = new Button();
            button2 = new Button();
            button3 = new Button();
            botonDocCu = new Button();
            planesDataGridView = new DataGridView();
            dataGridView1 = new DataGridView();
            cursosLabel = new Label();
            planesLabel = new Label();
            registrarNotaBoton = new Button();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 742);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1173, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Estado";
            // 
            // Materias
            // 
            Materias.Location = new Point(12, 138);
            Materias.Name = "Materias";
            Materias.Size = new Size(89, 23);
            Materias.TabIndex = 4;
            Materias.Text = "Materias";
            Materias.UseVisualStyleBackColor = true;
            Materias.Click += Materias_Click;
            // 
            // Planes
            // 
            Planes.Location = new Point(12, 77);
            Planes.Name = "Planes";
            Planes.Size = new Size(89, 23);
            Planes.TabIndex = 6;
            Planes.Text = "Planes";
            Planes.UseVisualStyleBackColor = true;
            Planes.Click += planes_Click;
            // 
            // PersonasButton
            // 
            PersonasButton.Location = new Point(12, 106);
            PersonasButton.Name = "PersonasButton";
            PersonasButton.Size = new Size(89, 23);
            PersonasButton.TabIndex = 8;
            PersonasButton.Text = "Persona";
            PersonasButton.UseVisualStyleBackColor = true;
            PersonasButton.Click += personasButton_Click;
            // 
            // comisionesButton
            // 
            comisionesButton.Location = new Point(12, 167);
            comisionesButton.Name = "comisionesButton";
            comisionesButton.Size = new Size(89, 23);
            comisionesButton.TabIndex = 8;
            comisionesButton.Text = "Comisiones";
            comisionesButton.UseVisualStyleBackColor = true;
            comisionesButton.Click += comisiones_Click;
            // 
            // especialidadButton
            // 
            especialidadButton.Location = new Point(12, 48);
            especialidadButton.Name = "especialidadButton";
            especialidadButton.Size = new Size(89, 23);
            especialidadButton.TabIndex = 10;
            especialidadButton.Text = "Especialidad";
            especialidadButton.UseVisualStyleBackColor = true;
            especialidadButton.Click += especialidadButton_Click;
            // 
            // usuarioButton
            // 
            usuarioButton.Location = new Point(12, 565);
            usuarioButton.Name = "usuarioButton";
            usuarioButton.Size = new Size(89, 23);
            usuarioButton.TabIndex = 12;
            usuarioButton.Text = "Usuario";
            usuarioButton.UseVisualStyleBackColor = true;
            usuarioButton.Click += usuarioButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 196);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 10;
            button2.Text = "Cursos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(778, 26);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 14;
            button3.Text = "Alumnos Inscripcciones";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // botonDocCu
            // 
            botonDocCu.Location = new Point(12, 225);
            botonDocCu.Name = "botonDocCu";
            botonDocCu.Size = new Size(89, 23);
            botonDocCu.TabIndex = 14;
            botonDocCu.Text = "DocenteCurso";
            botonDocCu.UseVisualStyleBackColor = true;
            botonDocCu.Click += botonDocCu_Click;
            // 
            // planesDataGridView
            // 
            planesDataGridView.AllowUserToOrderColumns = true;
            planesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planesDataGridView.Location = new Point(195, 439);
            planesDataGridView.Margin = new Padding(2, 1, 2, 1);
            planesDataGridView.MultiSelect = false;
            planesDataGridView.Name = "planesDataGridView";
            planesDataGridView.ReadOnly = true;
            planesDataGridView.RowHeadersWidth = 82;
            planesDataGridView.RowTemplate.Height = 41;
            planesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planesDataGridView.Size = new Size(751, 270);
            planesDataGridView.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(195, 116);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(751, 270);
            dataGridView1.TabIndex = 17;
            // 
            // cursosLabel
            // 
            cursosLabel.AutoSize = true;
            cursosLabel.Location = new Point(195, 86);
            cursosLabel.Name = "cursosLabel";
            cursosLabel.Size = new Size(43, 15);
            cursosLabel.TabIndex = 19;
            cursosLabel.Text = "Cursos";
            // 
            // planesLabel
            // 
            planesLabel.AutoSize = true;
            planesLabel.Location = new Point(195, 412);
            planesLabel.Name = "planesLabel";
            planesLabel.Size = new Size(41, 15);
            planesLabel.TabIndex = 20;
            planesLabel.Text = "Planes";
            // 
            // registrarNotaBoton
            // 
            registrarNotaBoton.Location = new Point(649, 26);
            registrarNotaBoton.Name = "registrarNotaBoton";
            registrarNotaBoton.Size = new Size(108, 23);
            registrarNotaBoton.TabIndex = 22;
            registrarNotaBoton.Text = "Registrar Nota";
            registrarNotaBoton.UseVisualStyleBackColor = true;
            registrarNotaBoton.Click += registrarNotaBoton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 764);
            Controls.Add(registrarNotaBoton);
            Controls.Add(planesLabel);
            Controls.Add(cursosLabel);
            Controls.Add(dataGridView1);
            Controls.Add(planesDataGridView);
            Controls.Add(button3);
            Controls.Add(botonDocCu);
            Controls.Add(usuarioButton);
            Controls.Add(especialidadButton);
            Controls.Add(PersonasButton);
            Controls.Add(button2);
            Controls.Add(comisionesButton);
            Controls.Add(Planes);
            Controls.Add(Materias);
            Controls.Add(statusStrip);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private Button Materias;
        private Button Planes;
        private Button comisionesButton;
        private Button PersonasButton;
        private Button especialidadButton;
        private Button usuarioButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button botonDocCu;
        private DataGridView planesDataGridView;
        private DataGridView dataGridView1;
        private Label cursosLabel;
        private Label planesLabel;
        private Button registrarNotaBoton;
    }
}



