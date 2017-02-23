namespace SG_SST_modulorecursos.Vista
{
    partial class frmListarPersonal
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnver = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbfiltrar = new System.Windows.Forms.ComboBox();
            this.txtpalabra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvpersonal = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Controls.Add(this.btnver);
            this.groupBox1.Controls.Add(this.btnfiltrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbfiltrar);
            this.groupBox1.Controls.Add(this.txtpalabra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvpersonal);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar y Filtrar Personal";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(32, 96);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(189, 48);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "Registrar Personal";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(800, 69);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(112, 32);
            this.btnver.TabIndex = 6;
            this.btnver.Text = "Ver Datos ";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(655, 69);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(112, 32);
            this.btnfiltrar.TabIndex = 5;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palabra Clave:";
            // 
            // cmbfiltrar
            // 
            this.cmbfiltrar.FormattingEnabled = true;
            this.cmbfiltrar.Items.AddRange(new object[] {
            "Documento",
            "Nombre",
            "Apellido",
            "Telefono",
            "Email",
            "Direccion ",
            "GrupoSanguineo"});
            this.cmbfiltrar.Location = new System.Drawing.Point(124, 61);
            this.cmbfiltrar.Name = "cmbfiltrar";
            this.cmbfiltrar.Size = new System.Drawing.Size(154, 29);
            this.cmbfiltrar.TabIndex = 3;
            // 
            // txtpalabra
            // 
            this.txtpalabra.Location = new System.Drawing.Point(441, 69);
            this.txtpalabra.Name = "txtpalabra";
            this.txtpalabra.Size = new System.Drawing.Size(192, 27);
            this.txtpalabra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por: ";
            // 
            // dgvpersonal
            // 
            this.dgvpersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonal.Location = new System.Drawing.Point(32, 150);
            this.dgvpersonal.Name = "dgvpersonal";
            this.dgvpersonal.Size = new System.Drawing.Size(893, 206);
            this.dgvpersonal.TabIndex = 0;
            // 
            // frmListarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 648);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListarPersonal";
            this.Text = "Lista Personal";
            this.Load += new System.EventHandler(this.frmListarPersonal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvpersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbfiltrar;
        private System.Windows.Forms.TextBox txtpalabra;
    }
}