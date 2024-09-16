using Domain.Model;

namespace WindowsForms
{
    public partial class PlanesLista : Form
    {
        public PlanesLista()
        {
            InitializeComponent();
        }


        private void Planes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            PlanesDetalle materiaDetalle = new PlanesDetalle();

            Plan materiaNuevo = new Plan();

            materiaDetalle.Plan = materiaNuevo;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            PlanesDetalle materiaDetalle = new PlanesDetalle();

            int id;

            id = this.SelectedItem().Id;

            Plan plan = await PlanApiClient.GetAsync(id);

            materiaDetalle.EditMode = true;
            materiaDetalle.Plan = plan;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await PlanApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            PlanApiClient client = new PlanApiClient();

            this.planesDataGridView.DataSource = null;
            this.planesDataGridView.DataSource = await PlanApiClient.GetAllAsync();

            if (this.planesDataGridView.Rows.Count > 0)
            {
                this.planesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Plan SelectedItem()
        {
            Plan plan;

            plan = (Plan)planesDataGridView.SelectedRows[0].DataBoundItem;

            return plan;
        }

        private void planesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
