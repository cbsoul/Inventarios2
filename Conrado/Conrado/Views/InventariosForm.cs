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
    public partial class InventariosForm : Form
    {
        private int id;

        public InventariosForm(int id)
        {
            InitializeComponent();
            this.id = id;
            this.Text = "Inventario Entradas";
        }
        private void InventariosForm_Load(object sender, EventArgs e)
        {
            DgvInventarios.DefaultCellStyle.BackColor = Color.LightGray;
            DgvInventarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            DgvInventarios.Font = new Font("Century Gothic ", 9, FontStyle.Regular);

            if (id == 1)
            {
                consultaEntradas();
            }
            else if (id == 2)
            {

            }
            else if (id == 3)
            {
                
            }
            else
            {

            }
        }

        public void consultaEntradas()
        {
            EntradasDAO Entradas_DAO = new EntradasDAO();

            try
            {
                DataTable dt = Entradas_DAO.LoadEntradas();
                DgvInventarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
