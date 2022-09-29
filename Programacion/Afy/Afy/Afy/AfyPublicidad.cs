using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afy
{
    public partial class AfyPublicidad : Form
    {
        public AfyPublicidad()
        {
            InitializeComponent();
            
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void chAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAgregar.Checked == true)
            {
                cbConsultar.Enabled = false;
                cbEliminar.Enabled = false;
                pb1.Visible = true;
                lblMostrar.Visible = true;
                btnAgregar.Visible = true;
                btnExaminar.Visible = true;
                lblMostrar.Visible = true;

            } else
            {
                cbConsultar.Enabled = true;
                cbEliminar.Enabled = true;
                pb1.Visible = false;
                btnAgregar.Visible = false;
                btnExaminar.Visible = false;
                lblMostrar.Visible = false;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void cbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConsultar.Checked == true)
            {
                cbAgregar.Enabled = false;
                cbEliminar.Enabled = false;
            }
            else
            {
                cbAgregar.Enabled = true;
                cbEliminar.Enabled = true;
            }
        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminar.Checked == true)
            {
                cbAgregar.Enabled = false;
                cbConsultar.Enabled = false;
            }
            else
            {
                cbAgregar.Enabled = true;
                cbConsultar.Enabled = true;
            }
        }

        private void AfyPublicidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AfyPublicidad_Load(object sender, EventArgs e)
        {
            
        }
    }
}
