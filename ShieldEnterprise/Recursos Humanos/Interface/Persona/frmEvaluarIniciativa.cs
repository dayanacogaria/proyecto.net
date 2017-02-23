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
    public partial class frmEvaluarIniciativa : Form
    {
        public frmEvaluarIniciativa(int a1, int a2, int a3, int a4, int a5)
        {
            InitializeComponent();
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
            this.a5 = a5;
            this.a5 = a5;
           
        }
        int a1 = 0;
        int a2 = 0;
        int a3 = 0;
        int a4 = 0;
        int a5 = 0;



        private void btnsig_Click(object sender, EventArgs e)
        {
            if (c1.Checked == true || c2.Checked == true || c3.Checked == true || c4.Checked == true || c5.Checked == true )
            {
                if (ca1.Checked == true || ca2.Checked == true || ca3.Checked == true || ca4.Checked == true || ca5.Checked == true )
                {
                    if (cb1.Checked == true || cb2.Checked == true || cb3.Checked == true || cb4.Checked == true || cb5.Checked == true )
                    {
                        if (cc1.Checked == true || cc2.Checked == true || cc3.Checked == true || cc4.Checked == true || cc5.Checked == true)
                        {
                            frmEvaluarTrabajo d = new frmEvaluarTrabajo(a1,a2,a3,a4,a5);
                            d.txtid.Text = txtid.Text; 
                            d.txtdoc.Text = txtdoc.Text;
                            d.txtapell.Text = txtapell.Text;
                            d.txtnom.Text = txtnom.Text;
                            d.Show();
                            this.Hide();
                        }

                    }

                }
               

            }
            else
            {
                MessageBox.Show("Complete los campos");
            }

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    frmEvaluarRelacion d = new frmEvaluarRelacion();
        //    d.Show();
        //    this.Hide(); 
        //}

        private void btnguar_Click(object sender, EventArgs e)
        {
            if (c1.Checked == true || ca1.Checked == true || cb1.Checked == true || cc1.Checked==true)
            {
                a1 += 1;

            }
            if (c2.Checked == true || ca2.Checked == true || cb2.Checked == true || cc2.Checked==true)
            {
                a2 += 2;
            }
            if (c3.Checked == true || ca3.Checked == true || cb3.Checked == true || cc3.Checked==true)
            {
                a3 += 3;

            }
            if (c4.Checked == true || ca4.Checked == true || cb4.Checked == true || cb1.Checked==true)
            {
                a4 += 4;

            }
            if (c5.Checked == true || ca5.Checked == true || cb5.Checked == true || cc5.Checked==true )
            {
                a5 += 5;
            }




        }

        private void frmEvaluarIniciativa_Load(object sender, EventArgs e)
        {

        }
    }
}
