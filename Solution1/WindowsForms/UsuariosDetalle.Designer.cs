namespace WindowsForms
{
    partial class UsuariosDetalle
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
            claveTextBox = new TextBox();
            label7 = new Label();
            emailTextBox = new TextBox();
            label1 = new Label();
            nombreUsuarioTextBox = new TextBox();
            label2 = new Label();
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
            aceptarButton.Location = new Point(100, 229);
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
            cancelarButton.Location = new Point(232, 229);
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
            label6.Size = new Size(0, 15);
            label6.TabIndex = 15;
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(131, 167);
            claveTextBox.Margin = new Padding(2, 1, 2, 1);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.Size = new Size(110, 23);
            claveTextBox.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 92);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 17;
            label7.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(131, 89);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(110, 23);
            emailTextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 126);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombre de Usuario";
            // 
            // nombreUsuarioTextBox
            // 
            nombreUsuarioTextBox.Location = new Point(131, 123);
            nombreUsuarioTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            nombreUsuarioTextBox.Size = new Size(110, 23);
            nombreUsuarioTextBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 175);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 22;
            label2.Text = "Clave";
            // 
            // UsuariosDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 299);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nombreUsuarioTextBox);
            Controls.Add(label7);
            Controls.Add(emailTextBox);
            Controls.Add(label6);
            Controls.Add(claveTextBox);
            Controls.Add(label5);
            Controls.Add(apellidoTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "UsuariosDetalle";
            Text = "Usuario";
            Load += UsuariosDetalle_Load;
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
        private TextBox claveTextBox;
        private Label label7;
        private TextBox emailTextBox;
        private Label label1;
        private TextBox nombreUsuarioTextBox;
        private Label label2;
    }
}