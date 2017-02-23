namespace Recursos_Humanos.Interface
{
    partial class frmListarPersona
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
            this.btnListarPersona = new System.Windows.Forms.Button();
            this.dgvListaPersona = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnShowModif = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilCiudad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFillApe = new System.Windows.Forms.TextBox();
            this.txtFilNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilDoc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPersona)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPersona
            // 
            this.btnListarPersona.Location = new System.Drawing.Point(171, 334);
            this.btnListarPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPersona.Name = "btnListarPersona";
            this.btnListarPersona.Size = new System.Drawing.Size(150, 50);
            this.btnListarPersona.TabIndex = 0;
            this.btnListarPersona.Text = "Mostrar Registros";
            this.btnListarPersona.UseVisualStyleBackColor = true;
            this.btnListarPersona.Click += new System.EventHandler(this.btnListarPersona_Click);
            // 
            // dgvListaPersona
            // 
            this.dgvListaPersona.AllowUserToAddRows = false;
            this.dgvListaPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPersona.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListaPersona.Location = new System.Drawing.Point(7, 25);
            this.dgvListaPersona.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaPersona.Name = "dgvListaPersona";
            this.dgvListaPersona.ReadOnly = true;
            this.dgvListaPersona.Size = new System.Drawing.Size(661, 277);
            this.dgvListaPersona.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListaPersona);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(676, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Registrado";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 334);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 50);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Nuevo Registro";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnShowModif
            // 
            this.btnShowModif.Location = new System.Drawing.Point(329, 334);
            this.btnShowModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowModif.Name = "btnShowModif";
            this.btnShowModif.Size = new System.Drawing.Size(150, 50);
            this.btnShowModif.TabIndex = 4;
            this.btnShowModif.Text = "Modificar Registro";
            this.btnShowModif.UseVisualStyleBackColor = true;
            this.btnShowModif.Click += new System.EventHandler(this.btnShowModif_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(487, 334);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 50);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnom);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbFilCiudad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFillApe);
            this.groupBox2.Controls.Add(this.txtFilNom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFilDoc);
            this.groupBox2.Location = new System.Drawing.Point(697, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 310);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda por filtros";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(14, 108);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(82, 22);
            this.txtnom.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(11, 256);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(85, 48);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ARL";
            // 
            // cmbFilCiudad
            // 
            this.cmbFilCiudad.FormattingEnabled = true;
            this.cmbFilCiudad.Location = new System.Drawing.Point(11, 203);
            this.cmbFilCiudad.Name = "cmbFilCiudad";
            this.cmbFilCiudad.Size = new System.Drawing.Size(85, 25);
            this.cmbFilCiudad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // txtFillApe
            // 
            this.txtFillApe.Location = new System.Drawing.Point(11, 155);
            this.txtFillApe.Name = "txtFillApe";
            this.txtFillApe.Size = new System.Drawing.Size(85, 22);
            this.txtFillApe.TabIndex = 4;
            // 
            // txtFilNom
            // 
            this.txtFilNom.AutoSize = true;
            this.txtFilNom.Location = new System.Drawing.Point(11, 87);
            this.txtFilNom.Name = "txtFilNom";
            this.txtFilNom.Size = new System.Drawing.Size(56, 17);
            this.txtFilNom.TabIndex = 3;
            this.txtFilNom.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento";
            // 
            // txtFilDoc
            // 
            this.txtFilDoc.Location = new System.Drawing.Point(11, 61);
            this.txtFilDoc.Name = "txtFilDoc";
            this.txtFilDoc.Size = new System.Drawing.Size(85, 22);
            this.txtFilDoc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Evaluar Persona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnShowModif);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListarPersona);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmListarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPersona)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarPersona;
        private System.Windows.Forms.DataGridView dgvListaPersona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnShowModif;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFilCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFillApe;
        private System.Windows.Forms.Label txtFilNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btnFiltrar;
    }
}