using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class UsuariosDetalle : Form
    {
        public UsuariosDetalle()
        {
            InitializeComponent();
        }

        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                this.SetUsuario();
            }
        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioApiClient client = new UsuarioApiClient();

            if (this.ValidateUsuario())
            {
                this.Usuario.Nombre = nombreTextBox.Text;
                this.Usuario.Apellido = apellidoTextBox.Text;
                this.Usuario.Email = emailTextBox.Text;
                this.Usuario.NombreUsuario = nombreUsuarioTextBox.Text;
                this.Usuario.Clave = claveTextBox.Text;
                //this.Usuario.Habilitado = 


                if (this.EditMode)
                {
                    await UsuarioApiClient.UpdateAsync(this.Usuario);
                }
                else
                {
                    await UsuarioApiClient.AddAsync(this.Usuario);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUsuario()
        {
            this.nombreTextBox.Text = this.Usuario.Nombre;
            this.apellidoTextBox.Text = this.Usuario.Apellido;
            this.emailTextBox.Text = this.Usuario.Email;
            this.nombreUsuarioTextBox.Text = this.Usuario.NombreUsuario;
            this.claveTextBox.Text = this.Usuario.Clave;
            // = this.Usuario.Habilitado;
        }

        private bool ValidateUsuario()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "Requerido");
            }


            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(apellidoTextBox, "Requerido");
            }


            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "Requerido");
            }

            if (this.claveTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(claveTextBox, "Requerido");
            }

            if (this.nombreUsuarioTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreUsuarioTextBox, "Requerido");
            }



            return isValid;
        }

        private void UsuariosDetalle_Load(object sender, EventArgs e)
        {

        }

    }
}
