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
    public partial class ComisionesLista : Form
    {
        public ComisionesLista()
        {
            InitializeComponent();
        }


        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            ComisionesDetalle comisionDetalle = new ComisionesDetalle();

            Comision comisionNuevo = new Comision();

            comisionDetalle.Comision = comisionNuevo;

            comisionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            ComisionesDetalle comisionDetalle = new ComisionesDetalle();

            int id;

            id = this.SelectedItem().ComisionId;

            Comision comision = await ComisionApiClient.GetAsync(id);

            comisionDetalle.EditMode = true;
            comisionDetalle.Comision = comision;

            comisionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().ComisionId;
            await ComisionApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            ComisionApiClient client = new ComisionApiClient();

            this.comisionesDataGridView.DataSource = null;
            this.comisionesDataGridView.DataSource = await ComisionApiClient.GetAllAsync();

            if (this.comisionesDataGridView.Rows.Count > 0)
            {
                this.comisionesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Comision SelectedItem()
        {
            Comision comision;

            comision = (Comision)comisionesDataGridView.SelectedRows[0].DataBoundItem;

            return comision;
        }

    }
}
