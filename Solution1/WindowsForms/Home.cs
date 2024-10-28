﻿using System;
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
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void planes_Click(object sender, EventArgs e)
        {
            PlanesLista childForm = new PlanesLista();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PersonasLista childForm = new PersonasLista();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void comisiones_Click(object sender, EventArgs e)
        {
            ComisionesLista childForm = new ComisionesLista();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CursosLista childForm = new CursosLista();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();

        }
    }
}
