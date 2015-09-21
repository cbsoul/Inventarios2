using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conrado.DAO;
namespace Conrado.Views
{
    public partial class CatalogoForm : Form
    {
        private int id;
        
       public CatalogoForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void CatalogoForm_Load(object sender, EventArgs e)
        {
            DgvCatalogos.DefaultCellStyle.BackColor = Color.LightGray;
            DgvCatalogos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            DgvCatalogos.Font = new Font("Century Gothic ", 9, FontStyle.Regular);

            if (id == 1)
            {
                consultaAseguradora();
                lblCatalogo.Text = "Aseguradoras";
                this.Text = "Catálogo de Aseguradoras";
            }
            else if (id == 2)
            {
                consultaAutoridad();
                lblCatalogo.Text = "Autoridad";
                this.Text = "Catálogo de Autoridades";
            }
            else if (id == 3)
            {
                consultaColores();
                lblCatalogo.Text = "Colores";
                this.Text = "Catálogo de Colores";
            }
            else if (id == 4)
            {
                consultaCorralon();
                lblCatalogo.Text = "Corralón";
                this.Text = "Catálogo de Corralones";
            }
            else if (id == 5)
            {
                consultaEmpresa();
                lblCatalogo.Text = "Empresas y/o Municipios";
                this.Text = "Catálogo de Empresas y/o Municipios";
            }
            else if (id == 6)
            {
                consultaEncargado();
                lblCatalogo.Text = "Encargado";
                this.Text = "Catálogo de Encargados";
            }
            else if (id == 7)
            {
                consultaMotivos();
                lblCatalogo.Text = "Motivos";
                this.Text = "Catálogo de Motivos";
            }
            else if (id == 8)
            {
                consultaTipoDePago();
                lblCatalogo.Text = "Tipos De Pago";
                this.Text = "Catálogo de Tipos de Pago";
            }
            else if (id == 9) 
            {
                consultaVehiculos();
                lblCatalogo.Text = "Vehículos";
                this.Text = "Catálogo de Vehículos";
            }
        }
        // Consulta de catálogos
        public void consultaAseguradora()
        {
            AseguradoraDAO Aseguradora_DAO = new AseguradoraDAO();

            try
            {
                DataTable dt = Aseguradora_DAO.LoadAseguradoras();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaAutoridad()
        {
            AutoridadDAO Autoridad_DAO = new AutoridadDAO();

            try
            {
                DataTable dt = Autoridad_DAO.LoadAutoridad();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaColores()
        {
            ColoresDAO Colores_DAO = new ColoresDAO();

            try
            {
                DataTable dt = Colores_DAO.LoadColores();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaCorralon()
        {
            CorralonDAO Corralon_DAO = new CorralonDAO();

            try
            {
                DataTable dt = Corralon_DAO.LoadCorralon();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaEmpresa()
        {
            EmpresaDAO Empresa_DAO = new EmpresaDAO();

            try
            {
                DataTable dt = Empresa_DAO.LoadEmpresa();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaEncargado()
        {
            EncargadoDAO Encargado_DAO = new EncargadoDAO();

            try
            {
                DataTable dt = Encargado_DAO.LoadEncargado();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaMotivos()
        {
            MotivosDAO Motivos_DAO = new MotivosDAO();

            try
            {
                DataTable dt = Motivos_DAO.LoadMotivo();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaTipoDePago()
        {
            TipoDePagoDAO TipoPago_DAO = new TipoDePagoDAO();

            try
            {
                DataTable dt = TipoPago_DAO.LoadTipoDePago();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void consultaVehiculos()
        {
            VehiculosDAO Vehiculos_DAO = new VehiculosDAO();

            try
            {
                DataTable dt = Vehiculos_DAO.LoadVehiculos();
                DgvCatalogos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        //Nuevo
        public void disposeNew(object Source, EventArgs args)
        {
            if (id == 1)
            {
                consultaAseguradora();
                
            }
            else if (id == 2)
            {
                consultaAutoridad();
                
            }
            else if (id == 3)
            {
                consultaColores();
                
            }
            else if (id == 4)
            {
                consultaCorralon();
                
            }
            else if (id == 5)
            {
                consultaEmpresa();
                
            }
            else if (id == 6)
            {
                consultaEncargado();
                
            }
            else if (id == 7)
            {
                consultaMotivos();
               
            }
            else if (id == 8)
            {
                consultaTipoDePago();
                
            }
            else if (id == 9)
            {
                consultaVehiculos();
                
            }
        }
        

        private void btnNew_Click(object sender, EventArgs e)
        {
            int Id = 0;
            if (lblCatalogo.Text == "Aseguradoras")
            {
                id = 1;
            }
            else if (lblCatalogo.Text == "Autoridad")
            {
                id = 2;
            }
            else if (lblCatalogo.Text == "Colores")
            {
                id = 3;
            }
            else if (lblCatalogo.Text == "Corralón")
            {
                id = 4;
            }
            else if (lblCatalogo.Text == "Empresas y/o Municipios")
            {
                id = 5;
            }
            else if (lblCatalogo.Text == "Encargado")
            {
                id = 6;
            }
            else if (lblCatalogo.Text == "Motivos")
            {
                id = 7;
            }
            else if (lblCatalogo.Text == "Tipos De Pago")
            {
                id = 8;
            }
            else if (lblCatalogo.Text == "Vehículos")
            {
                id = 9;
            }

            NewUpdateCatalogo frmNewCat = new NewUpdateCatalogo(Id,id);
            frmNewCat.MdiParent = this.MdiParent;
            frmNewCat.StartPosition = FormStartPosition.CenterScreen;
            frmNewCat.Show();
            frmNewCat.Disposed += new EventHandler(disposeNew);
        }
        //update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int fila = DgvCatalogos.CurrentCell.RowIndex;
            String valor = DgvCatalogos.Rows[fila].Cells[0].Value.ToString();
            int Id = Int32.Parse(valor);
            NewUpdateCatalogo frmNewCat = new NewUpdateCatalogo(Id,id);
            frmNewCat.MdiParent = this.MdiParent;
            frmNewCat.StartPosition = FormStartPosition.CenterScreen;
            frmNewCat.Show();
            frmNewCat.Disposed += new EventHandler(disposeNew);
        }
    }
}
