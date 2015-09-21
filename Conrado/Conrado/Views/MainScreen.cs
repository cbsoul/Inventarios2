using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conrado.Views;

namespace Conrado
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrarAplicacion();
        }
              
        private void cerrarAplicacion()
        {
            Application.Exit();
        }
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarAplicacion();
        }
        //ABOUT
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDeScreen screen = new AcercaDeScreen();
            screen.MdiParent = this;
            screen.StartPosition = FormStartPosition.CenterScreen;
            screen.Show();
        }
        //CATÁLOGOS
        private void aseguradoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 1;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }

        private void autoridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id =2;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }
        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 3;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }
        private void corralónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 4;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }

        private void empresaOMunicipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 5;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }

        private void encargadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 6;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }

        private void motivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 7;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }

        private void tiposDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 8;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 9;
            CatalogoForm frmCat = new CatalogoForm(id);
            frmCat.MdiParent = this;
            frmCat.StartPosition = FormStartPosition.CenterScreen;
            frmCat.Show();
        }
       
        //VENTANAS
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void cerrarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
        }
        //INVENTARIOS
        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 1;
            InventariosForm frmConEntradas = new InventariosForm(id);
            frmConEntradas.MdiParent = this;

            frmConEntradas.Show();
        }
        //ARCHIVO
        private void nuevaEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            NewESForm frmNewEntradas = new NewESForm();
            frmNewEntradas.MdiParent = this;
            frmNewEntradas.StartPosition = FormStartPosition.CenterScreen;
            frmNewEntradas.Show();
        }

        
    }
}
