﻿namespace WindowsForms
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
            PersonasButton.Location = new Point(12, 175);
            PersonasButton.Name = "PersonasButton";
            PersonasButton.Size = new Size(89, 23);
            PersonasButton.TabIndex = 8;
            PersonasButton.Text = "Persona";
            PersonasButton.UseVisualStyleBackColor = true;
            PersonasButton.Click += personasButton_Click;
            // 
            // comisionesButton
            // 
            comisionesButton.Location = new Point(12, 128);
            comisionesButton.Name = "comisionesButton";
            comisionesButton.Size = new Size(89, 23);
            comisionesButton.TabIndex = 8;
            comisionesButton.Text = "Comisiones";
            comisionesButton.UseVisualStyleBackColor = true;
            comisionesButton.Click += comisiones_Click;
            // 
            // especialidadButton
            // 
            especialidadButton.Location = new Point(12, 222);
            especialidadButton.Name = "especialidadButton";
            especialidadButton.Size = new Size(89, 23);
            especialidadButton.TabIndex = 10;
            especialidadButton.Text = "Especialidad";
            especialidadButton.UseVisualStyleBackColor = true;
            especialidadButton.Click += especialidadButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(especialidadButton);
            Controls.Add(PersonasButton);
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
    }
}



