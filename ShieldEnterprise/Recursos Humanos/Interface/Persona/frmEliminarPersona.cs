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

namespace Recursos_Humanos.Interface
{
    public partial class frmEliminarPersona : Form
    {
        public frmEliminarPersona()
        {
            InitializeComponent();
        }

        int Id = 0;
        private void btnSerach_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim() == "")
                {
                    MessageBox.Show("Digite un Id para eliminar en el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    ClPersona searchId = new ClPersona();
                    List<EPersona> listReceptId = new List<EPersona>();

                    Id = int.Parse(txtId.Text);
                    listReceptId = searchId.mtdBuscarIdPersona(Id);

                    lblDoc.Text = listReceptId[0].Documento.ToString();
                 lblNom.Text = listReceptId[0].Nombre.ToString();
                    lblApe.Text = listReceptId[0].Apellido.ToString();
                }     
            }

            catch (Exception)
            {
                MessageBox.Show("El Id no se encuentra en la base de datos", "◄ ALERTA | ShieldTech Team ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
                      
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "" )
            {
                MessageBox.Show("Digite un Id para eliminar en el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    if (MessageBox.Show("Esta a punto de eliminar un registro, desea continuar?", "◄ ALERTA | ShieldTech Team ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        ClPersona D = new ClPersona();
                        string Sql = "Delete from Persona where IdPersona =" + Id + "";
                        D.mtdDeletePersona(Sql);

                        MessageBox.Show("El Registro ha sido eliminado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }                
        }
    }
}
