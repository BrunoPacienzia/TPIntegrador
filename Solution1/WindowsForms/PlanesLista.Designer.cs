﻿namespace WindowsForms
{
    partial class PlanesLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            planesDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // planesDataGridView
            // 
            planesDataGridView.AllowUserToOrderColumns = true;
            planesDataGridView.BackgroundColor = SystemColors.GradientInactiveCaption;
            planesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planesDataGridView.GridColor = Color.White;
            planesDataGridView.Location = new Point(21, 18);
            planesDataGridView.Margin = new Padding(2, 1, 2, 1);
            planesDataGridView.MultiSelect = false;
            planesDataGridView.Name = "planesDataGridView";
            planesDataGridView.ReadOnly = true;
            planesDataGridView.RowHeadersWidth = 82;
            planesDataGridView.RowTemplate.Height = 41;
            planesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planesDataGridView.Size = new Size(751, 270);
            planesDataGridView.TabIndex = 0;
            planesDataGridView.CellContentClick += planesDataGridView_CellContentClick;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(691, 300);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(81, 22);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(506, 300);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(81, 22);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(598, 300);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(81, 22);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // PlanesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 402);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(planesDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "PlanesLista";
            Text = "Planes";
            Load += Planes_Load;
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView planesDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
    }
}
