namespace Recursos_Humanos.Interface
{
    partial class frmEliminarPersona
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSerach = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnSerach);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 84);
            this.groupBox2.TabIndex = 1;
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
            this.label7.Location = new System.Drawing.Point(33, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ingrese un Id para eliminar en el registro";
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(153, 44);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(75, 23);
            this.btnSerach.TabIndex = 1;
            this.btnSerach.Text = "Buscar";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(95, 188);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 35);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(130, 147);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(24, 13);
            this.lblApe.TabIndex = 7;
            this.lblApe.Text = "--/--";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(130, 99);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(24, 13);
            this.lblDoc.TabIndex = 8;
            this.lblDoc.Text = "--/--";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(130, 123);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(24, 13);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "--/--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apellido";
            // 
            // frmEliminarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEliminarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}