using System.Drawing;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            cursosDataGrid = new DataGridView();
            cursosLabel = new Label();
            planesLabel = new Label();
            registrarNotaBoton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosDataGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 688);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 18, 0);
            statusStrip.Size = new Size(1159, 22);
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
            Materias.BackColor = SystemColors.ActiveCaption;
            Materias.FlatAppearance.BorderSize = 0;
            Materias.FlatStyle = FlatStyle.Flat;
            Materias.Font = new Font("Microsoft Sans Serif", 11.25F);
            Materias.ForeColor = Color.DarkSlateGray;
            Materias.Location = new Point(33, 252);
            Materias.Margin = new Padding(3, 4, 3, 4);
            Materias.Name = "Materias";
            Materias.Size = new Size(159, 31);
            Materias.TabIndex = 4;
            Materias.Text = "Materias";
            Materias.TextAlign = ContentAlignment.MiddleLeft;
            Materias.UseVisualStyleBackColor = false;
            Materias.Click += Materias_Click;
            // 
            // Planes
            // 
            Planes.BackColor = SystemColors.ActiveCaption;
            Planes.FlatAppearance.BorderSize = 0;
            Planes.FlatStyle = FlatStyle.Flat;
            Planes.Font = new Font("Microsoft Sans Serif", 11.25F);
            Planes.ForeColor = Color.DarkSlateGray;
            Planes.Location = new Point(33, 152);
            Planes.Margin = new Padding(3, 4, 3, 4);
            Planes.Name = "Planes";
            Planes.Size = new Size(159, 31);
            Planes.TabIndex = 6;
            Planes.Text = "Planes";
            Planes.TextAlign = ContentAlignment.MiddleLeft;
            Planes.UseVisualStyleBackColor = false;
            Planes.Click += planes_Click;
            // 
            // PersonasButton
            // 
            PersonasButton.BackColor = SystemColors.ActiveCaption;
            PersonasButton.FlatAppearance.BorderSize = 0;
            PersonasButton.FlatStyle = FlatStyle.Flat;
            PersonasButton.Font = new Font("Microsoft Sans Serif", 11.25F);
            PersonasButton.ForeColor = Color.DarkSlateGray;
            PersonasButton.Location = new Point(33, 201);
            PersonasButton.Margin = new Padding(3, 4, 3, 4);
            PersonasButton.Name = "PersonasButton";
            PersonasButton.Size = new Size(159, 31);
            PersonasButton.TabIndex = 8;
            PersonasButton.Text = "Persona";
            PersonasButton.TextAlign = ContentAlignment.MiddleLeft;
            PersonasButton.UseVisualStyleBackColor = false;
            PersonasButton.Click += personasButton_Click;
            // 
            // comisionesButton
            // 
            comisionesButton.BackColor = SystemColors.ActiveCaption;
            comisionesButton.FlatAppearance.BorderSize = 0;
            comisionesButton.FlatStyle = FlatStyle.Flat;
            comisionesButton.Font = new Font("Microsoft Sans Serif", 11.25F);
            comisionesButton.ForeColor = Color.DarkSlateGray;
            comisionesButton.Location = new Point(33, 302);
            comisionesButton.Margin = new Padding(3, 4, 3, 4);
            comisionesButton.Name = "comisionesButton";
            comisionesButton.Size = new Size(159, 31);
            comisionesButton.TabIndex = 8;
            comisionesButton.Text = "Comisiones";
            comisionesButton.TextAlign = ContentAlignment.MiddleLeft;
            comisionesButton.UseVisualStyleBackColor = false;
            comisionesButton.Click += comisiones_Click;
            // 
            // especialidadButton
            // 
            especialidadButton.BackColor = SystemColors.ActiveCaption;
            especialidadButton.FlatAppearance.BorderSize = 0;
            especialidadButton.FlatStyle = FlatStyle.Flat;
            especialidadButton.Font = new Font("Microsoft Sans Serif", 11.25F);
            especialidadButton.ForeColor = Color.DarkSlateGray;
            especialidadButton.Location = new Point(33, 104);
            especialidadButton.Margin = new Padding(3, 4, 3, 4);
            especialidadButton.Name = "especialidadButton";
            especialidadButton.Size = new Size(159, 31);
            especialidadButton.TabIndex = 10;
            especialidadButton.Text = "Especialidad";
            especialidadButton.TextAlign = ContentAlignment.MiddleLeft;
            especialidadButton.UseVisualStyleBackColor = false;
            especialidadButton.Click += especialidadButton_Click;
            // 
            // usuarioButton
            // 
            usuarioButton.BackColor = SystemColors.ActiveCaption;
            usuarioButton.FlatAppearance.BorderSize = 0;
            usuarioButton.FlatStyle = FlatStyle.Flat;
            usuarioButton.Font = new Font("Microsoft Sans Serif", 11.25F);
            usuarioButton.ForeColor = Color.DarkSlateGray;
            usuarioButton.Location = new Point(33, 455);
            usuarioButton.Margin = new Padding(3, 4, 3, 4);
            usuarioButton.Name = "usuarioButton";
            usuarioButton.Size = new Size(159, 31);
            usuarioButton.TabIndex = 12;
            usuarioButton.Text = "Usuario";
            usuarioButton.TextAlign = ContentAlignment.MiddleLeft;
            usuarioButton.UseVisualStyleBackColor = false;
            usuarioButton.Click += usuarioButton_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(33, 356);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(159, 31);
            button2.TabIndex = 10;
            button2.Text = "Cursos";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(931, 38);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(193, 31);
            button3.TabIndex = 14;
            button3.Text = "Alumnos Inscripcciones";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // botonDocCu
            // 
            botonDocCu.BackColor = SystemColors.ActiveCaption;
            botonDocCu.FlatAppearance.BorderSize = 0;
            botonDocCu.FlatStyle = FlatStyle.Flat;
            botonDocCu.Font = new Font("Microsoft Sans Serif", 11.25F);
            botonDocCu.ForeColor = Color.DarkSlateGray;
            botonDocCu.Location = new Point(33, 407);
            botonDocCu.Margin = new Padding(3, 4, 3, 4);
            botonDocCu.Name = "botonDocCu";
            botonDocCu.Size = new Size(159, 31);
            botonDocCu.TabIndex = 14;
            botonDocCu.Text = "DocenteCurso";
            botonDocCu.TextAlign = ContentAlignment.MiddleLeft;
            botonDocCu.UseVisualStyleBackColor = false;
            botonDocCu.Click += botonDocCu_Click;
            // 
            // planesDataGridView
            // 
            planesDataGridView.AllowUserToOrderColumns = true;
            planesDataGridView.BackgroundColor = SystemColors.GradientInactiveCaption;
            planesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            planesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            planesDataGridView.GridColor = SystemColors.ActiveBorder;
            planesDataGridView.Location = new Point(265, 458);
            planesDataGridView.Margin = new Padding(2, 1, 2, 1);
            planesDataGridView.MultiSelect = false;
            planesDataGridView.Name = "planesDataGridView";
            planesDataGridView.ReadOnly = true;
            planesDataGridView.RowHeadersWidth = 82;
            planesDataGridView.RowTemplate.Height = 41;
            planesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planesDataGridView.Size = new Size(858, 219);
            planesDataGridView.TabIndex = 16;
            // 
            // cursosDataGrid
            // 
            cursosDataGrid.AllowUserToOrderColumns = true;
            cursosDataGrid.BackgroundColor = SystemColors.GradientInactiveCaption;
            cursosDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            cursosDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            cursosDataGrid.GridColor = SystemColors.ActiveBorder;
            cursosDataGrid.Location = new Point(266, 155);
            cursosDataGrid.Margin = new Padding(2, 1, 2, 1);
            cursosDataGrid.MultiSelect = false;
            cursosDataGrid.Name = "cursosDataGrid";
            cursosDataGrid.ReadOnly = true;
            cursosDataGrid.RowHeadersWidth = 82;
            cursosDataGrid.RowTemplate.Height = 41;
            cursosDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDataGrid.Size = new Size(858, 219);
            cursosDataGrid.TabIndex = 17;
            // 
            // cursosLabel
            // 
            cursosLabel.AutoSize = true;
            cursosLabel.BackColor = Color.Transparent;
            cursosLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cursosLabel.ForeColor = Color.DarkSlateGray;
            cursosLabel.Location = new Point(265, 118);
            cursosLabel.Name = "cursosLabel";
            cursosLabel.Size = new Size(89, 29);
            cursosLabel.TabIndex = 19;
            cursosLabel.Text = "Cursos";
            // 
            // planesLabel
            // 
            planesLabel.AutoSize = true;
            planesLabel.BackColor = Color.Transparent;
            planesLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planesLabel.ForeColor = Color.DarkSlateGray;
            planesLabel.Location = new Point(265, 423);
            planesLabel.Name = "planesLabel";
            planesLabel.Size = new Size(87, 29);
            planesLabel.TabIndex = 20;
            planesLabel.Text = "Planes";
            // 
            // registrarNotaBoton
            // 
            registrarNotaBoton.BackColor = SystemColors.ActiveCaption;
            registrarNotaBoton.FlatAppearance.BorderSize = 0;
            registrarNotaBoton.FlatStyle = FlatStyle.Flat;
            registrarNotaBoton.Font = new Font("Microsoft Sans Serif", 11.25F);
            registrarNotaBoton.ForeColor = Color.DarkSlateGray;
            registrarNotaBoton.Location = new Point(765, 38);
            registrarNotaBoton.Margin = new Padding(3, 4, 3, 4);
            registrarNotaBoton.Name = "registrarNotaBoton";
            registrarNotaBoton.Size = new Size(123, 31);
            registrarNotaBoton.TabIndex = 22;
            registrarNotaBoton.Text = "Registrar Nota";
            registrarNotaBoton.TextAlign = ContentAlignment.MiddleLeft;
            registrarNotaBoton.UseVisualStyleBackColor = false;
            registrarNotaBoton.Click += registrarNotaBoton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 24;
            label1.Text = "Entidades";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 662);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(registrarNotaBoton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(cursosDataGrid);
            panel2.Controls.Add(planesLabel);
            panel2.Controls.Add(cursosLabel);
            panel2.Controls.Add(planesDataGridView);
            panel2.Location = new Point(0, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 973);
            panel2.TabIndex = 26;
            panel2.Click += panel2_Click;
            panel2.Paint += panel2_Paint;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1159, 710);
            Controls.Add(especialidadButton);
            Controls.Add(usuarioButton);
            Controls.Add(botonDocCu);
            Controls.Add(PersonasButton);
            Controls.Add(button2);
            Controls.Add(comisionesButton);
            Controls.Add(Planes);
            Controls.Add(Materias);
            Controls.Add(statusStrip);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            IsMdiContainer = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Home";
            Text = "Home";
            TransparencyKey = SystemColors.ControlLightLight;
            Activated += Home_Activated;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private DataGridView cursosDataGrid;
        private Label cursosLabel;
        private Label planesLabel;
        private Button registrarNotaBoton;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}



