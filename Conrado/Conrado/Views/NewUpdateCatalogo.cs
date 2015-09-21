using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conrado.DAO;
using Conrado.DTO;

namespace Conrado.Views
{
    public partial class NewUpdateCatalogo : Form
    {
        private int id;
        private int Id;
        

        public NewUpdateCatalogo(int Id,int id)
        {
            InitializeComponent();
            this.id = id;
            this.Id = Id;
            
        }

        private void NewUpdateCatalogo_Load(object sender, EventArgs e)
        {
            //Nuevo
            if (Id == 0)
            {
                if (id == 1)
                {
                    Label1.Text = "Aseguradora: ";
                    this.Text = "Nueva Aseguradora";
                }
                else if (id == 2)
                {
                    Label1.Text = "Autoridad: ";
                    this.Text = "Nueva Autoridad";
                }
                else if (id == 3)
                {
                    Label1.Text = "Color: ";
                    this.Text = "Nuevo Color";
                }
                else if (id == 4)
                {
                    Label1.Text = "Corralón: ";
                    this.Text = "Nuevo Corralón";
                }
                else if (id == 5)
                {
                    Label1.Text = "Empresa: ";
                    this.Text = "Nueva Empresa";
                }
                else if (id == 6)
                {
                    Label1.Text = "Encargado: ";
                    this.Text = "Nuevo Encargado";
                }
                else if (id == 7)
                {
                    Label1.Text = "Motivo: ";
                    this.Text = "Nuevo Motivo";
                }
                else if (id == 8)
                {
                    Label1.Text = "Tipo de Pago: ";
                    this.Text = "Nuevo Tipo de Pago";
                }
                else if (id == 9)
                {
                    Label1.Text = "Vehículo: ";
                    this.Text = "Nuevo Vehículo";
                }
                
            }
            //Actualizar
            else
            {
                if (id == 1)
                {

                }
                else if (id == 2)
                {

                }
                else if (id == 3)
                {

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NuevoBTN_Click(object sender, EventArgs e)
        {
            //Nuevo
            if (Id == 0)
            {


                if (id == 1)
                {
                    
                }
                else if (id == 2)
                {

                }
                else if (id == 3)
                {
                    newColor();
                    this.Dispose();
                }

            }
            //Actualizar
            else
            {
                if (id == 1)
                {

                }
                else if (id == 2)
                {

                }
                else if (id == 3)
                {

                }
            }
        }

        public void newColor()
        {
            ColoresDTO proy_dto = new ColoresDTO();
            proy_dto.color = txtNuevo.Text;
            try
            {
                ColoresDAO Colores_DAO = new ColoresDAO();
                Colores_DAO.newColor(proy_dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
