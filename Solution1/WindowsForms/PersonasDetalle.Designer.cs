namespace WindowsForms
{
    partial class PersonasDetalle
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
            label5 = new Label();
            apellidoTextBox = new TextBox();
            label6 = new Label();
            direccionTextBox = new TextBox();
            label7 = new Label();
            emailTextBox = new TextBox();
            label8 = new Label();
            label1 = new Label();
            legajoTextBox = new TextBox();
            label2 = new Label();
            idPlanTextBox = new TextBox();
            label3 = new Label();
            telefonoTextBox = new TextBox();
            label4 = new Label();
            tipoPersonaTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            aceptarButton.Location = new Point(572, 376);
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
            cancelarButton.Location = new Point(704, 376);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 60);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(131, 57);
            apellidoTextBox.Margin = new Padding(2, 1, 2, 1);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(110, 23);
            apellidoTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 101);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 15;
            label6.Text = "Direccion";
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(131, 98);
            direccionTextBox.Margin = new Padding(2, 1, 2, 1);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(110, 23);
            direccionTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 143);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 17;
            label7.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(131, 140);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(110, 23);
            emailTextBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 187);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 18;
            label8.Text = "Fecha Nacimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 230);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 20;
            label1.Text = "Legajo";
            // 
            // legajoTextBox
            // 
            legajoTextBox.Location = new Point(131, 227);
            legajoTextBox.Margin = new Padding(2, 1, 2, 1);
            legajoTextBox.Name = "legajoTextBox";
            legajoTextBox.Size = new Size(110, 23);
            legajoTextBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 274);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 22;
            label2.Text = "Id Plan";
            // 
            // idPlanTextBox
            // 
            idPlanTextBox.Location = new Point(131, 271);
            idPlanTextBox.Margin = new Padding(2, 1, 2, 1);
            idPlanTextBox.Name = "idPlanTextBox";
            idPlanTextBox.Size = new Size(110, 23);
            idPlanTextBox.TabIndex = 21;
            idPlanTextBox.KeyPress += idPlanTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 321);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 24;
            label3.Text = "Telefono";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(131, 318);
            telefonoTextBox.Margin = new Padding(2, 1, 2, 1);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(110, 23);
            telefonoTextBox.TabIndex = 23;
            telefonoTextBox.KeyPress += telefonoTextBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 369);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 26;
            label4.Text = "Tipo Persona";
            // 
            // tipoPersonaTextBox
            // 
            tipoPersonaTextBox.Location = new Point(131, 366);
            tipoPersonaTextBox.Margin = new Padding(2, 1, 2, 1);
            tipoPersonaTextBox.Name = "tipoPersonaTextBox";
            tipoPersonaTextBox.Size = new Size(110, 23);
            tipoPersonaTextBox.TabIndex = 25;
            tipoPersonaTextBox.KeyPress += tipoPersonaTextBox_KeyPress;
            // 
            // PersonasDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 419);
            Controls.Add(label4);
            Controls.Add(tipoPersonaTextBox);
            Controls.Add(label3);
            Controls.Add(telefonoTextBox);
            Controls.Add(label2);
            Controls.Add(idPlanTextBox);
            Controls.Add(label1);
            Controls.Add(legajoTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(emailTextBox);
            Controls.Add(label6);
            Controls.Add(direccionTextBox);
            Controls.Add(label5);
            Controls.Add(apellidoTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "PersonasDetalle";
            Text = "Persona";
            Load += PersonasDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label label5;
        private TextBox apellidoTextBox;
        private Label label6;
        private TextBox direccionTextBox;
        private Label label7;
        private TextBox emailTextBox;
        private Label label8;
        private Label label1;
        private TextBox legajoTextBox;
        private Label label2;
        private TextBox idPlanTextBox;
        private Label label3;
        private TextBox telefonoTextBox;
        private Label label4;
        private TextBox tipoPersonaTextBox;
    }
}