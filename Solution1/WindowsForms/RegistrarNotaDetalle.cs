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
    public partial class RegistrarNotaDetalle : Form
    {
        public RegistrarNotaDetalle()
        {
            InitializeComponent();
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

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            AlumnoInscripccionApiClient client = new AlumnoInscripccionApiClient();

            if (this.ValidateAlumnoInscripccion())
            {
               
                this.AlumnoInscripccion.Nota = 0;


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
            this.notaTextBox.Text = "";

        }

        private bool ValidateAlumnoInscripccion()
        {
            bool isValid = true;

            errorProvider.SetError(notaTextBox, string.Empty);

            if (!this.notaTextBox.Text.All(char.IsDigit))
            {
                isValid = false;
                errorProvider.SetError(notaTextBox, "La nota solo puede contener numeros");
            }
           


            if (this.notaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(notaTextBox, "Requerido");
            }


            return isValid;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}