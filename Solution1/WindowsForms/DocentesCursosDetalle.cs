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
        IEnumerable<Persona> docentes = [];
        IEnumerable<Curso> cursos = [];

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
            LoadTiposPlanes();
        }

        private async void LoadTiposPlanes()
        {
            IEnumerable<Persona> docentes = await PersonaApiClient.GetAllAsync();
            this.docentes = docentes;
            this.docenteComboBoxInput.DataSource = docentes;
            this.docenteComboBoxInput.DisplayMember = "Legajo";
            this.docenteComboBoxInput.ValueMember = "Id";
            this.docenteComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;

            IEnumerable<Curso> cursos = await CursoApiClient.GetAllAsync();
            this.cursos = cursos;
            this.cursoComboBoxInput.DataSource = cursos;
            this.cursoComboBoxInput.DisplayMember = "Descripcion";
            this.cursoComboBoxInput.ValueMember = "Id";
            this.cursoComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            DocenteCursoApiClient client = new DocenteCursoApiClient();

            if (this.ValidateDocenteCurso())
            {
                this.DocenteCurso.TipoCargo = cargoTextBox.Text;

                var selectedDocenteId = (int)this.docenteComboBoxInput.SelectedValue;

                this.DocenteCurso.Docente = (Persona)this.docentes.FirstOrDefault(p => p.Id == selectedDocenteId);

                var selectedCursoId = (int)this.cursoComboBoxInput.SelectedValue;

                this.DocenteCurso.Curso = (Curso)this.cursos.FirstOrDefault(p => p.Id == selectedCursoId);
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
            this.cargoTextBox.Text = this.DocenteCurso.TipoCargo;

            if (this.docenteCurso.Docente != null)
            {
                this.docenteComboBoxInput.SelectedIndex = this.docenteCurso.Docente.Id;
            }

            if (this.docenteCurso.Curso != null)
            {
                this.cursoComboBoxInput.SelectedIndex = this.docenteCurso.Curso.Id;
            }
        }

        private bool ValidateDocenteCurso()
        {
            bool isValid = true;



            if (this.docenteComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(docenteComboBoxInput, "Requerido");
            }


            if (this.cursoComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(cursoComboBoxInput, "Requerido");
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
