using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Domain.Model;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MateriasDetalle : Form
    {
        private Materia materia;

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                this.SetMateria();
            }
        }
        public MateriasDetalle()
        {
            InitializeComponent();
        }


        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            MateriaApiClient client = new MateriaApiClient();

            if (this.ValidateMateria())
            {
                this.Materia.Nombre = nombreTextBox.Text;
                this.Materia.Descripcion = descripcionTextBox.Text;
                this.Materia.IdPlan = int.Parse(idPlanTextBox.Text);
                this.Materia.HSSemanales = int.Parse(hsSemanalesTextBox.Text); 
                this.Materia.HSTotales = int.Parse(hsTotalesTextBox.Text); ;

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await MateriaApiClient.UpdateAsync(this.Materia);
                }
                else
                {
                    await MateriaApiClient.AddAsync(this.Materia);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetMateria()
        {
            this.nombreTextBox.Text = this.Materia.Nombre;
            this.descripcionTextBox.Text = this.Materia.Descripcion;
            this.idPlanTextBox.Text = this.Materia.IdPlan.ToString();
            this.hsSemanalesTextBox.Text = this.Materia.HSSemanales.ToString();
            this.hsTotalesTextBox.Text = this.Materia.HSTotales.ToString(); 

        }

        private bool ValidateMateria()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "Requerido");
            }


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "Requerido");
            }


            if (this.hsSemanalesTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(hsSemanalesTextBox, "Requerido");
            }

            if (this.hsTotalesTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(hsTotalesTextBox, "Requerido");
            }

            if (this.idPlanTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idPlanTextBox, "Requerido");
            }

            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
