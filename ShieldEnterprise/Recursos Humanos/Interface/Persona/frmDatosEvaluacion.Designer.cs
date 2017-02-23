namespace Recursos_Humanos.Interface.Persona
{
    partial class frmDatosEvaluacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnmos = new System.Windows.Forms.Button();
            this.txtpuntaje = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnmos);
            this.groupBox1.Controls.Add(this.txtpuntaje);
            this.groupBox1.Controls.Add(this.txtape);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.txtdoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado Evaluacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(134, 32);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(133, 23);
            this.txtid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id";
            // 
            // btnmos
            // 
            this.btnmos.Location = new System.Drawing.Point(175, 232);
            this.btnmos.Name = "btnmos";
            this.btnmos.Size = new System.Drawing.Size(92, 44);
            this.btnmos.TabIndex = 8;
            this.btnmos.Text = "Mostrar Resultado ";
            this.btnmos.UseVisualStyleBackColor = true;
            this.btnmos.Click += new System.EventHandler(this.btnmos_Click);
            // 
            // txtpuntaje
            // 
            this.txtpuntaje.Location = new System.Drawing.Point(134, 180);
            this.txtpuntaje.Name = "txtpuntaje";
            this.txtpuntaje.ReadOnly = true;
            this.txtpuntaje.Size = new System.Drawing.Size(133, 23);
            this.txtpuntaje.TabIndex = 7;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(134, 142);
            this.txtape.Name = "txtape";
            this.txtape.ReadOnly = true;
            this.txtape.Size = new System.Drawing.Size(133, 23);
            this.txtape.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(134, 106);
            this.txtnom.Name = "txtnom";
            this.txtnom.ReadOnly = true;
            this.txtnom.Size = new System.Drawing.Size(133, 23);
            this.txtnom.TabIndex = 5;
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(134, 69);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.ReadOnly = true;
            this.txtdoc.Size = new System.Drawing.Size(133, 23);
            this.txtdoc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puntaje ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento";
            // 
            // frmDatosEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 305);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatosEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtpuntaje;
        public System.Windows.Forms.TextBox txtape;
        public System.Windows.Forms.TextBox txtnom;
        public System.Windows.Forms.TextBox txtdoc;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button1;
    }
}