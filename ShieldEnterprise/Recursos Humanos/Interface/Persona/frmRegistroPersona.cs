using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recursos_Humanos.Data;
using Recursos_Humanos.Entity;
using Recursos_Humanos.Interface;
using Recursos_Humanos.Interface.Persona;

namespace Recursos_Humanos
{
    public partial class frmRegistroPersona : Form
    {
        public frmRegistroPersona()
        {
            InitializeComponent();
        }

        private void frmRegistroPersona_Load(object sender, EventArgs e)
        {
            txtDocumento.Focus();
            ClArl objarp = new ClArl();
            cmbarl.DataSource = objarp.mtdlistararl(); 
            cmbarl.ValueMember = "IdArl";
            cmbarl.DisplayMember = "ARL";




        }

        ClPersona R = new ClPersona();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtTelefono.Text.Trim() == "" || txtEmail.Text.Trim() == "" || cmbarl.Text.Trim()=="")
            {
                MessageBox.Show("Faltan algunos campos por completar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }

            else
            {
                EPersona persona = new EPersona();

                persona.Documento = txtDocumento.Text;
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Direccion = txtDireccion.Text;
                persona.Telefono = txtTelefono.Text;
                persona.Email = txtEmail.Text;
                persona.ARL = (cmbarl.SelectedValue.ToString());

                string sql = "insert into Persona (Documento, Nombre, Apellido, Direccion, Telefono, Email, IdArl) values ('" + persona.Documento + "', '" + persona.Nombre + "', '" + persona.Apellido + "', '" + persona.Direccion + "', '" + persona.Telefono + "', '" + persona.Email + "', '" + persona.ARL + "')";
                R.mtdRegistrar(sql);

                MessageBox.Show("Registro guardado exitosamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }

            txtDocumento.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
        
        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            frmListarPersona lista = new frmListarPersona();
            this.Hide();
            lista.Show();
          
            if (lista.IsDisposed == true)
            {
                frmModifPersona nlista = new frmModifPersona();
                nlista.Show();
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmARL d = new frmARL();
            d.Show();
            this.Hide(); 
        }
    }
}
