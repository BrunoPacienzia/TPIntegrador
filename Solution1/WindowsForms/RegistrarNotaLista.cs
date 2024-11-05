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
    public partial class RegistrarNotaLista : Form
    {
        public RegistrarNotaLista()
        {
            InitializeComponent();
        }

        private void AlumnoInscripciones_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            RegistrarNotaDetalle registrarNotaDetalle = new RegistrarNotaDetalle();

            int id;

            id = this.SelectedItem().AlumnoInscripcionId;

            AlumnoInscripcion alumnoInscripccion = await AlumnoInscripcionApiClient.GetAsync(id);

            registrarNotaDetalle.EditMode = true;
            registrarNotaDetalle.AlumnoInscripcion = alumnoInscripccion;

            registrarNotaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }


        private async void GetAllAndLoad()
        {
            AlumnoInscripcionApiClient client = new AlumnoInscripcionApiClient();

            this.alumnoInscripccionesDataGridView.DataSource = null;
            IEnumerable<AlumnoInscripcion> alumnosEncontrados = await AlumnoInscripcionApiClient.GetAllAsync();

            this.alumnoInscripccionesDataGridView.DataSource = alumnosEncontrados.Where(a =>  a.Nota == 0).ToList();

            if (this.alumnoInscripccionesDataGridView.Rows.Count > 0)
            {
                this.alumnoInscripccionesDataGridView.Rows[0].Selected = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.modificarButton.Enabled = false;
            }
        }

        private AlumnoInscripcion SelectedItem()
        {
            AlumnoInscripcion alumnoInscripccion;

            alumnoInscripccion = (AlumnoInscripcion)alumnoInscripccionesDataGridView.SelectedRows[0].DataBoundItem;

            return alumnoInscripccion;
        }

    }
}
