namespace sistema_modelo
{
    partial class TablaModelo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaModelo));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txttamanio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.npisos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nasiento = new System.Windows.Forms.NumericUpDown();
            this.btnbuscarmodelo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModeloB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(74, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(204, 20);
            this.txtnombre.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Tamaño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Asientos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "Editar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 182);
            this.dataGridView1.TabIndex = 81;
            // 
            // txttamanio
            // 
            this.txttamanio.Location = new System.Drawing.Point(74, 90);
            this.txttamanio.Name = "txttamanio";
            this.txttamanio.Size = new System.Drawing.Size(204, 20);
            this.txttamanio.TabIndex = 95;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.npisos);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nasiento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txttamanio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 184);
            this.panel1.TabIndex = 96;
            // 
            // npisos
            // 
            this.npisos.Location = new System.Drawing.Point(74, 154);
            this.npisos.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.npisos.Name = "npisos";
            this.npisos.Size = new System.Drawing.Size(204, 20);
            this.npisos.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Pisos:";
            // 
            // nasiento
            // 
            this.nasiento.Location = new System.Drawing.Point(74, 124);
            this.nasiento.Name = "nasiento";
            this.nasiento.Size = new System.Drawing.Size(204, 20);
            this.nasiento.TabIndex = 96;
            // 
            // btnbuscarmodelo
            // 
            this.btnbuscarmodelo.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarmodelo.Image")));
            this.btnbuscarmodelo.Location = new System.Drawing.Point(795, 14);
            this.btnbuscarmodelo.Name = "btnbuscarmodelo";
            this.btnbuscarmodelo.Size = new System.Drawing.Size(40, 28);
            this.btnbuscarmodelo.TabIndex = 120;
            this.btnbuscarmodelo.UseVisualStyleBackColor = true;
            this.btnbuscarmodelo.Click += new System.EventHandler(this.btnbuscarmodelo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(160, 6);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(35, 34);
            this.btncancelar.TabIndex = 134;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(124, 6);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(30, 33);
            this.btneliminar.TabIndex = 133;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(50, 6);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(31, 33);
            this.btneditar.TabIndex = 132;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = ((System.Drawing.Image)(resources.GetObject("btnañadir.Image")));
            this.btnañadir.Location = new System.Drawing.Point(12, 6);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(32, 33);
            this.btnañadir.TabIndex = 131;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(87, 6);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(31, 33);
            this.btnguardar.TabIndex = 130;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 155;
            this.label6.Text = "ID";
            // 
            // txtIDB
            // 
            this.txtIDB.Location = new System.Drawing.Point(382, 19);
            this.txtIDB.Name = "txtIDB";
            this.txtIDB.Size = new System.Drawing.Size(146, 20);
            this.txtIDB.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 158;
            this.label1.Text = "Modelo";
            // 
            // txtModeloB
            // 
            this.txtModeloB.Location = new System.Drawing.Point(623, 19);
            this.txtModeloB.Name = "txtModeloB";
            this.txtModeloB.Size = new System.Drawing.Size(126, 20);
            this.txtModeloB.TabIndex = 159;
            // 
            // TablaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 257);
            this.Controls.Add(this.txtModeloB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnbuscarmodelo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla Modelo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TablaModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttamanio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnbuscarmodelo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.NumericUpDown nasiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModeloB;
        private System.Windows.Forms.NumericUpDown npisos;
        private System.Windows.Forms.Label label7;
    }
}