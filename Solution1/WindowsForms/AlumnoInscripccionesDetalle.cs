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
    public partial class AlumnoInscripccionesDetalle : Form
    {
        IEnumerable<Persona> alumnos = [];
        IEnumerable<Curso> cursos = [];
        public AlumnoInscripccionesDetalle()
        {
            InitializeComponent();
            LoadTiposPlanes();
        }

        private AlumnoInscripccion alumnoInscripccion;

        public AlumnoInscripccion AlumnoInscripccion
        {
            get { return alumnoInscripccion; }
            set
            {
                alumnoInscripccion = value;
                this.SetAlumnoInscripccion();
            }
        }

        private async void LoadTiposPlanes()
        {
            IEnumerable<Persona> alumnos = await PersonaApiClient.GetAllAsync();
            this.alumnos = alumnos;
            this.alumnoComboBoxInput.DataSource = alumnos;
            this.alumnoComboBoxInput.DisplayMember = "Legajo";
            this.alumnoComboBoxInput.ValueMember = "PersonaId";
            this.alumnoComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;

            IEnumerable<Curso> cursos = await CursoApiClient.GetAllAsync();
            this.cursos = cursos;
            this.cursoComboBoxInput.DataSource = cursos;
            this.cursoComboBoxInput.DisplayMember = "Descripcion";
            this.cursoComboBoxInput.ValueMember = "CursoId";
            this.cursoComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            AlumnoInscripccionApiClient client = new AlumnoInscripccionApiClient();

            if (this.ValidateAlumnoInscripccion())
            {
                this.AlumnoInscripccion.Condicion = condicionTextBox.Text;
                this.AlumnoInscripccion.Nota = 0;

                var selectedAlumnoId = (int)this.alumnoComboBoxInput.SelectedValue;

                this.AlumnoInscripccion.Alumno = (Persona)this.alumnos.FirstOrDefault(p => p.PersonaId == selectedAlumnoId);

                var selectedCursoId = (int)this.cursoComboBoxInput.SelectedValue;

                this.AlumnoInscripccion.Curso = (Curso)this.cursos.FirstOrDefault(p => p.CursoId == selectedCursoId);


                if (this.EditMode)
                {
                    await AlumnoInscripccionApiClient.UpdateAsync(this.AlumnoInscripccion);
                }
                else
                {
                    await AlumnoInscripccionApiClient.AddAsync(this.AlumnoInscripccion);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAlumnoInscripccion()
        {
            this.condicionTextBox.Text = this.AlumnoInscripccion.Condicion;

            if (this.alumnoInscripccion.Alumno != null)
            {
                this.alumnoComboBoxInput.SelectedIndex = this.alumnoInscripccion.Alumno.PersonaId;
            }

            if (this.alumnoInscripccion.Curso != null)
            {
                this.cursoComboBoxInput.SelectedIndex = this.alumnoInscripccion.Curso.CursoId;
            }
        }

        private bool ValidateAlumnoInscripccion()
        {
            bool isValid = true;

            errorProvider.SetError(condicionTextBox, string.Empty);

            if (this.condicionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(condicionTextBox, "Requerido");
            }



            if (this.alumnoComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(alumnoComboBoxInput, "Requerido");
            }


            if (this.cursoComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(cursoComboBoxInput, "Requerido");
            }


            return isValid;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
