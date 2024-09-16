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
            button1 = new Button();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(737, 22);
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
            Materias.Location = new Point(12, 26);
            Materias.Name = "Materias";
            Materias.Size = new Size(75, 23);
            Materias.TabIndex = 4;
            Materias.Text = "Materias";
            Materias.UseVisualStyleBackColor = true;
            Materias.Click += Materias_Click;
            // 
            // Planes
            // 
            Planes.Location = new Point(12, 87);
            Planes.Name = "Planes";
            Planes.Size = new Size(75, 23);
            Planes.TabIndex = 6;
            Planes.Text = "Planes";
            Planes.UseVisualStyleBackColor = true;
            Planes.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 142);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Persona";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(button1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private Button Materias;
        private Button Planes;
        private Button button1;
    }
}



