namespace Recursos_Humanos.Interface.Persona
{
    partial class frmEvaluarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvaluarPersona));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncomenzar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.txtdoc);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtid1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Persona";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(397, 89);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.ReadOnly = true;
            this.txtapellido.Size = new System.Drawing.Size(151, 23);
            this.txtapellido.TabIndex = 8;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(397, 59);
            this.txtnom.Name = "txtnom";
            this.txtnom.ReadOnly = true;
            this.txtnom.Size = new System.Drawing.Size(151, 23);
            this.txtnom.TabIndex = 7;
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(397, 26);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.ReadOnly = true;
            this.txtdoc.Size = new System.Drawing.Size(151, 23);
            this.txtdoc.TabIndex = 6;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(67, 89);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar ";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtid1
            // 
            this.txtid1.Location = new System.Drawing.Point(57, 53);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(100, 23);
            this.txtid1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Id de la Persona a evaluar ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instrucciones ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(552, 302);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btncomenzar
            // 
            this.btncomenzar.Location = new System.Drawing.Point(423, 482);
            this.btncomenzar.Name = "btncomenzar";
            this.btncomenzar.Size = new System.Drawing.Size(123, 44);
            this.btncomenzar.TabIndex = 9;
            this.btncomenzar.Text = "Comenzar ";
            this.btncomenzar.UseVisualStyleBackColor = true;
            this.btncomenzar.Click += new System.EventHandler(this.btncomenzar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mostrar Registro Evaluados ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEvaluarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncomenzar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEvaluarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncomenzar;
        private System.Windows.Forms.Button button1;
    }
}