namespace WindowsForms
{
    partial class RegistrarNotaDetalle
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
            components = new System.ComponentModel.Container();
            notaTextBox = new TextBox();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            notaLabel = new Label();
            label6 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // notaTextBox
            // 
            notaTextBox.Location = new Point(131, 21);
            notaTextBox.Margin = new Padding(2, 1, 2, 1);
            notaTextBox.Name = "notaTextBox";
            notaTextBox.Size = new Size(110, 23);
            notaTextBox.TabIndex = 0;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(62, 90);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(81, 22);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(160, 90);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new Point(24, 29);
            notaLabel.Margin = new Padding(2, 0, 2, 0);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new Size(33, 15);
            notaLabel.TabIndex = 13;
            notaLabel.Text = "Nota";
            notaLabel.Click += label5_Click;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 21;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // RegistrarNotaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 132);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(notaLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(notaTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "RegistrarNotaDetalle";
            Text = "AlumnoInscripcion";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox notaTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label notaLabel;
        private Label label6;
        private Label label2;
    }
}