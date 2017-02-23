using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursos_Humanos.Interface.Persona
{
    public partial class frmEvaluarOrientacion : Form
    {
        public frmEvaluarOrientacion()
        {
            InitializeComponent();
            

        }

        int a1 = 0;
        int a2 = 0;
        int a3 = 0;
        int a4 = 0;
        int a5 = 0;
      


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnsig_Click(object sender, EventArgs e)
        {
            if (c1.Checked == true || c2.Checked == true || c3.Checked == true || c4.Checked == true || c5.Checked == true)

            {
                if (ca1.Checked == true || ca2.Checked == true || ca3.Checked == true || ca4.Checked == true || ca5.Checked == true)
                {

                    if (cb1.Checked == true || cb2.Checked == true || cb3.Checked == true || cb4.Checked == true || cb5.Checked == true)
                    {

                        frmEvaluarCalidad d = new frmEvaluarCalidad(a1, a2, a3, a4, a5);
                        d.txtid.Text = txtid.Text;
                        d.txtdoc.Text = txtdoc.Text;
                        d.txtapell.Text = txtapell.Text;
                        d.txtnom.Text = txtnom.Text;
                        d.Show();
                        this.Hide();



                    }

                }

            }
            
            else 
            {
                MessageBox.Show("Complete los campos ");
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmEvaluarPersona  d = new frmEvaluarPersona();
            d.Show();
            this.Hide(); 
        }

        private void btnguar_Click(object sender, EventArgs e)
        {
            if (c1.Checked== true || ca1.Checked==true || cb1.Checked==true )
            {
                a1 += 1;

            }
            if (c2.Checked==true || ca2.Checked== true || cb2.Checked==true )
            {
                a2 += 2;
            }
            if (c3.Checked==true || ca3.Checked==true || cb3.Checked==true )
            {
                a3 += 3;

            }
            if (c4.Checked==true || ca4.Checked== true || cb4.Checked==true)
            {
                a4 += 4; 

            }
            if (c5.Checked==true || ca5.Checked==true || cb5.Checked==true)
            {
                a5 += 5;  
            }






        }

        private void frmEvaluarOrientacion_Load(object sender, EventArgs e)
        {

        }
    }
}
