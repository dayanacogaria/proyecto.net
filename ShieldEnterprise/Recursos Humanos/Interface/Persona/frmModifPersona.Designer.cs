namespace Recursos_Humanos.Interface
{
    partial class frmModifPersona
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
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboarl = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(122, 28);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(100, 20);
            this.txtDoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOCUMENTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboarl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApe);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 326);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Registro";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(80, 280);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 30);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Guardar Cambios";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONO";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(122, 169);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DIRECCION";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(122, 132);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(100, 20);
            this.txtDir.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDO";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(122, 97);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(100, 20);
            this.txtApe.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(122, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnModif);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 84);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "";
            this.groupBox2.Text = "Realizar Cambios";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(47, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ingrese un Id para realizar cambios en el registro";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(153, 44);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Buscar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ARL";
            // 
            // cmboarl
            // 
            this.cmboarl.FormattingEnabled = true;
            this.cmboarl.Location = new System.Drawing.Point(122, 241);
            this.cmboarl.Name = "cmboarl";
            this.cmboarl.Size = new System.Drawing.Size(100, 21);
            this.cmboarl.TabIndex = 14;
            // 
            // frmModifPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmModifPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmModifPersona_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.ComboBox cmboarl;
        private System.Windows.Forms.Label label8;
    }
}