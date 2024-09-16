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
    public partial class ComisionesDetalle : Form
    {

        private Comision comision;

        public Comision Comision
        {
            get { return comision; }
            set
            {
                comision = value;
                this.SetComision();
            }
        }

        public ComisionesDetalle()
        {
            InitializeComponent();
        }



        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            ComisionApiClient client = new ComisionApiClient();

            if (this.ValidateComision())
            {
                this.Comision.Descripcion = descripcionTextBox.Text;
                this.Comision.IdPlan = int.Parse(idPlanTextBox.Text);
                this.Comision.AnioEspecialidad = int.Parse(anioEspecialidadTextBox.Text);

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await ComisionApiClient.UpdateAsync(this.Comision);
                }
                else
                {
                    await ComisionApiClient.AddAsync(this.Comision);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetComision()
        {
            this.descripcionTextBox.Text = this.Comision.Descripcion;
            this.idPlanTextBox.Text = this.Comision.IdPlan.ToString();
            this.anioEspecialidadTextBox.Text = this.Comision.AnioEspecialidad.ToString();

        }

        private bool ValidateComision()
        {
            bool isValid = true;


            if (this.anioEspecialidadTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(anioEspecialidadTextBox, "Requerido");
            }


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "Requerido");
            }

            if (this.idPlanTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idPlanTextBox, "Requerido");
            }

            return isValid;
        }

        private void anioEspecialidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void idPlanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
