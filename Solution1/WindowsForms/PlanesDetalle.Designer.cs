
namespace WindowsForms
{
    partial class PlanesDetalle
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
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            especialidadLabel = new Label();
            label3 = new Label();
            descripcionTextBox = new TextBox();
            especialidadComboBoxInput = new ComboBox();
            especialidadBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(24, 24);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(0, 15);
            nombreLabel.TabIndex = 1;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(226, 197);
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
            cancelarButton.Location = new Point(327, 197);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Location = new Point(24, 38);
            especialidadLabel.Margin = new Padding(2, 0, 2, 0);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new Size(72, 15);
            especialidadLabel.TabIndex = 4;
            especialidadLabel.Text = "Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 87);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Descripcion";
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(125, 84);
            descripcionTextBox.Margin = new Padding(2, 1, 2, 1);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(110, 23);
            descripcionTextBox.TabIndex = 10;
            // 
            // especialidadComboBoxInput
            // 
            especialidadComboBoxInput.DataSource = especialidadBindingSource;
            especialidadComboBoxInput.FormattingEnabled = true;
            especialidadComboBoxInput.Location = new Point(125, 35);
            especialidadComboBoxInput.Name = "especialidadComboBoxInput";
            especialidadComboBoxInput.Size = new Size(121, 23);
            especialidadComboBoxInput.TabIndex = 15;
            // 
            // especialidadBindingSource
            // 
            especialidadBindingSource.DataSource = typeof(Domain.Model.Especialidad);
            // 
            // PlanesDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 244);
            Controls.Add(especialidadComboBoxInput);
            Controls.Add(descripcionTextBox);
            Controls.Add(label3);
            Controls.Add(especialidadLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "PlanesDetalle";
            Text = "Plan";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label especialidadLabel;
        private Label label3;
        private TextBox descripcionTextBox;
        private ComboBox especialidadComboBoxInput;
        private BindingSource especialidadBindingSource;
    }
}