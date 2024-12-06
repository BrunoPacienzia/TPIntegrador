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
    public partial class Home : Form
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();

            Load();
        }

        private async void Load()
        {
            CursoApiClient client = new CursoApiClient();


            var cursos = await CursoApiClient.GetAllAsync();

            var cursosParaMostrar = cursos.Select(curso => new
            {
                curso.CursoId,
                curso.Descripcion,
                curso.AnioCalendario,
                curso.Cupo,
                ComisionId = curso.Comision?.ComisionId,
                MateriaId = curso.Materia.MateriaId
            }).ToList();

            this.cursosDataGrid.DataSource = cursosParaMostrar;


            PlanApiClient planClient = new PlanApiClient();

            var planes = await PlanApiClient.GetAllAsync();


            var planesParaMostrar = planes.Select(plan => new
            {
                plan.PlanId,
                plan.Descripcion,
                EspecialidadId = plan.Especialidad?.EspecialidadId,

            }).ToList();


            this.planesDataGridView.DataSource = planesParaMostrar;


        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }



        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Materias_Click(object sender, EventArgs e)
        {
            MateriasLista childForm = new MateriasLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void planes_Click(object sender, EventArgs e)
        {
            PlanesLista childForm = new PlanesLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();

        }

        private void personasButton_Click(object sender, EventArgs e)
        {
            PersonasLista childForm = new PersonasLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void comisiones_Click(object sender, EventArgs e)
        {
            ComisionesLista childForm = new ComisionesLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void especialidadButton_Click(object sender, EventArgs e)
        {
            EspecialidadesLista childForm = new EspecialidadesLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void usuarioButton_Click(object sender, EventArgs e)
        {
            UsuariosLista childForm = new UsuariosLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CursosLista childForm = new CursosLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionLista childForm = new AlumnoInscripcionLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void botonDocCu_Click(object sender, EventArgs e)
        {
            DocentesCursosLista childForm = new DocentesCursosLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void registrarNotaBoton_Click(object sender, EventArgs e)
        {
            RegistrarNotaLista childForm = new RegistrarNotaLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void cursoBoton_Click(object sender, EventArgs e)
        {
            CursosLista childForm = new CursosLista();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }

        private void Home_Load_2(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            Load();
        }
    }
}
