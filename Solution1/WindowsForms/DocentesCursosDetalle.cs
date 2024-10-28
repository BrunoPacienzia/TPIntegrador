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
    public partial class DocentesCursosDetalle : Form
    {

        private DocenteCurso docenteCurso;

        public DocenteCurso DocenteCurso
        {
            get { return docenteCurso; }
            set
            {
                docenteCurso = value;
                this.SetDocenteCurso();
            }
        }

        public DocentesCursosDetalle()
        {
            InitializeComponent();
        }



        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            DocenteCursoApiClient client = new DocenteCursoApiClient();

            if (this.ValidateDocenteCurso())
            {
                this.DocenteCurso.IdCurso = int.Parse(idCursoTextBox.Text);
                this.DocenteCurso.IdDocente = int.Parse(idDocenteTextBox.Text);
                this.DocenteCurso.TipoCargo = cargoTextBox.Text;

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await DocenteCursoApiClient.UpdateAsync(this.DocenteCurso);
                }
                else
                {
                    await DocenteCursoApiClient.AddAsync(this.DocenteCurso);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDocenteCurso()
        {

            this.idCursoTextBox.Text = this.DocenteCurso.IdCurso.ToString();
            this.idDocenteTextBox.Text = this.DocenteCurso.IdDocente.ToString();
            this.cargoTextBox.Text = this.DocenteCurso.TipoCargo;

        }

        private bool ValidateDocenteCurso()
        {
            bool isValid = true;


            if (this.idDocenteTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idDocenteTextBox, "Requerido");
            }

            if (this.idCursoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idCursoTextBox, "Requerido");
            }


            if (this.cargoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(cargoTextBox, "Requerido");
            }

            return isValid;
        }

        private void idDocenteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void idCursoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
