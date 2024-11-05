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
    public partial class PersonasLista : Form
    {
        public PersonasLista()
        {
            InitializeComponent();
        }


        private void Personas_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            PersonasDetalle personaDetalle = new PersonasDetalle();

            Persona personaNuevo = new Persona();

            personaDetalle.Persona = personaNuevo;

            personaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            PersonasDetalle personaDetalle = new PersonasDetalle();

            int id;

            id = this.SelectedItem().PersonaId;

            Persona persona = await PersonaApiClient.GetAsync(id);

            personaDetalle.EditMode = true;
            personaDetalle.Persona = persona;

            personaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().PersonaId;
            await PersonaApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            PersonaApiClient client = new PersonaApiClient();

            this.personasDataGridView.DataSource = null;
            this.personasDataGridView.DataSource = await PersonaApiClient.GetAllAsync();

            if (this.personasDataGridView.Rows.Count > 0)
            {
                this.personasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Persona SelectedItem()
        {
            Persona persona;

            persona = (Persona)personasDataGridView.SelectedRows[0].DataBoundItem;

            return persona;
        }

        private void PersonasLista_Load(object sender, EventArgs e)
        {

        }
    }
}
