
namespace WindowsForms
{
    partial class MateriasDetalle
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
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            planLabel = new Label();
            hsSemanalesTextBox = new TextBox();
            hsTotalesTextBox = new TextBox();
            descripcionTextBox = new TextBox();
            planComboBoxInput = new ComboBox();
            planBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(131, 21);
            nombreTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(110, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(24, 24);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 92);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "HsTotales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "HsSemanales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Descripcion";
            // 
            // planLabel
            // 
            planLabel.AutoSize = true;
            planLabel.Location = new Point(24, 157);
            planLabel.Margin = new Padding(2, 0, 2, 0);
            planLabel.Name = "planLabel";
            planLabel.Size = new Size(30, 15);
            planLabel.TabIndex = 7;
            planLabel.Text = "Plan";
            // 
            // hsSemanalesTextBox
            // 
            hsSemanalesTextBox.Location = new Point(131, 55);
            hsSemanalesTextBox.Margin = new Padding(2, 1, 2, 1);
            hsSemanalesTextBox.Name = "hsSemanalesTextBox";
            hsSemanalesTextBox.Size = new Size(110, 23);
            hsSemanalesTextBox.TabIndex = 8;
            hsSemanalesTextBox.KeyPress += hsSemanalesTextBox_KeyPress;
            // 
            // hsTotalesTextBox
            // 
            hsTotalesTextBox.Location = new Point(131, 89);
            hsTotalesTextBox.Margin = new Padding(2, 1, 2, 1);
            hsTotalesTextBox.Name = "hsTotalesTextBox";
            hsTotalesTextBox.Size = new Size(110, 23);
            hsTotalesTextBox.TabIndex = 9;
            hsTotalesTextBox.KeyPress += hsTotalesTextBox_KeyPress;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(131, 124);
            descripcionTextBox.Margin = new Padding(2, 1, 2, 1);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(110, 23);
            descripcionTextBox.TabIndex = 10;
            // 
            // planComboBoxInput
            // 
            planComboBoxInput.DataSource = planBindingSource;
            planComboBoxInput.FormattingEnabled = true;
            planComboBoxInput.Location = new Point(131, 157);
            planComboBoxInput.Name = "planComboBoxInput";
            planComboBoxInput.Size = new Size(121, 23);
            planComboBoxInput.TabIndex = 16;
            // 
            // planBindingSource
            // 
            planBindingSource.DataSource = typeof(Domain.Model.Plan);
            // 
            // MateriasDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 244);
            Controls.Add(planComboBoxInput);
            Controls.Add(descripcionTextBox);
            Controls.Add(hsTotalesTextBox);
            Controls.Add(hsSemanalesTextBox);
            Controls.Add(planLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MateriasDetalle";
            Text = "Materia";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)planBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label planLabel;
        private TextBox descripcionTextBox;
        private TextBox hsTotalesTextBox;
        private TextBox hsSemanalesTextBox;
        private ComboBox planComboBoxInput;
        private BindingSource planBindingSource;
    }
}