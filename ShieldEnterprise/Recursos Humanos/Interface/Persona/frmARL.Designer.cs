namespace Recursos_Humanos.Interface.Persona
{
    partial class frmARL
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnbus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnelim = new System.Windows.Forms.Button();
            this.btnmodi = new System.Windows.Forms.Button();
            this.txtarl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(235, 183);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(271, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el Id para realizar cambios";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(276, 144);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(111, 27);
            this.txtid.TabIndex = 6;
            // 
            // btnbus
            // 
            this.btnbus.Location = new System.Drawing.Point(393, 144);
            this.btnbus.Name = "btnbus";
            this.btnbus.Size = new System.Drawing.Size(42, 30);
            this.btnbus.TabIndex = 7;
            this.btnbus.Text = "......";
            this.btnbus.UseVisualStyleBackColor = true;
            this.btnbus.Click += new System.EventHandler(this.btnbus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnelim);
            this.groupBox1.Controls.Add(this.btnmodi);
            this.groupBox1.Controls.Add(this.txtarl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnbus);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARL";
            // 
            // btnelim
            // 
            this.btnelim.Location = new System.Drawing.Point(351, 228);
            this.btnelim.Name = "btnelim";
            this.btnelim.Size = new System.Drawing.Size(98, 30);
            this.btnelim.TabIndex = 11;
            this.btnelim.Text = "Eliminar";
            this.btnelim.UseVisualStyleBackColor = true;
            this.btnelim.Click += new System.EventHandler(this.btnelim_Click);
            // 
            // btnmodi
            // 
            this.btnmodi.Location = new System.Drawing.Point(247, 228);
            this.btnmodi.Name = "btnmodi";
            this.btnmodi.Size = new System.Drawing.Size(98, 30);
            this.btnmodi.TabIndex = 10;
            this.btnmodi.Text = "Modificar";
            this.btnmodi.UseVisualStyleBackColor = true;
            this.btnmodi.Click += new System.EventHandler(this.btnmodi_Click);
            // 
            // txtarl
            // 
            this.txtarl.Location = new System.Drawing.Point(301, 187);
            this.txtarl.Name = "txtarl";
            this.txtarl.Size = new System.Drawing.Size(148, 27);
            this.txtarl.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "ARL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ARL";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Atras";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmARL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmARL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmARL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnbus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtarl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnelim;
        private System.Windows.Forms.Button btnmodi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}