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
    public partial class AlumnoInscripcionesDetalle : Form
    {
        IEnumerable<Persona> alumnos = [];
        IEnumerable<Curso> cursos = [];
        public AlumnoInscripcionesDetalle()
        {
            InitializeComponent();
            LoadTiposPlanes();
        }

        private AlumnoInscripcion alumnoInscripccion;

        public AlumnoInscripcion AlumnoInscripcion
        {
            get { return alumnoInscripccion; }
            set
            {
                alumnoInscripccion = value;
                this.SetAlumnoInscripcion();
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
            AlumnoInscripcionApiClient client = new AlumnoInscripcionApiClient();

            if (this.ValidateAlumnoInscripcion())
            {
                this.AlumnoInscripcion.Condicion = condicionTextBox.Text;
                this.AlumnoInscripcion.Nota = 0;

                var selectedAlumnoId = (int)this.alumnoComboBoxInput.SelectedValue;

                this.AlumnoInscripcion.Alumno = (Persona)this.alumnos.FirstOrDefault(p => p.PersonaId == selectedAlumnoId);

                var selectedCursoId = (int)this.cursoComboBoxInput.SelectedValue;

                this.AlumnoInscripcion.Curso = (Curso)this.cursos.FirstOrDefault(p => p.CursoId == selectedCursoId);


                if (this.EditMode)
                {
                    await AlumnoInscripcionApiClient.UpdateAsync(this.AlumnoInscripcion);
                }
                else
                {
                    await AlumnoInscripcionApiClient.AddAsync(this.AlumnoInscripcion);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAlumnoInscripcion()
        {
            this.condicionTextBox.Text = this.AlumnoInscripcion.Condicion;

            if (this.alumnoInscripccion.Alumno != null)
            {
                this.alumnoComboBoxInput.SelectedIndex = this.alumnoInscripccion.Alumno.PersonaId;
            }

            if (this.alumnoInscripccion.Curso != null)
            {
                this.cursoComboBoxInput.SelectedIndex = this.alumnoInscripccion.Curso.CursoId;
            }
        }

        private bool ValidateAlumnoInscripcion()
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
