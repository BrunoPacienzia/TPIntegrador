﻿using Domain.Model;
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

        private AlumnoInscripcion alumnoInscripcion;

        public AlumnoInscripcion AlumnoInscripcion
        {
            get { return alumnoInscripcion; }
            set
            {
                alumnoInscripcion = value;
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
                this.AlumnoInscripcion.Condicion = "Cursando";
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


            if (this.alumnoInscripcion.Alumno != null)
            {
                this.alumnoComboBoxInput.SelectedValue = this.alumnoInscripcion.Alumno.PersonaId;
            }

            if (this.alumnoInscripcion.Curso != null)
            {
                this.cursoComboBoxInput.SelectedValue = this.alumnoInscripcion.Curso.CursoId;
            }

            if (EditMode)
            {
                this.alumnoComboBoxInput.Enabled = false;
                this.cursoComboBoxInput.Enabled = false ;
            }
        }

        private bool ValidateAlumnoInscripcion()
        {
            bool isValid = true;


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
