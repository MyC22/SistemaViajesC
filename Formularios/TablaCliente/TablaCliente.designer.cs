namespace sistema_de_viajes
{
    partial class TablaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaCliente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lapellido = new System.Windows.Forms.Label();
            this.ldni = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtnacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.ldireccion = new System.Windows.Forms.Label();
            this.lruc = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdempresa = new System.Windows.Forms.RadioButton();
            this.rdpersona = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lnacimiento = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.txtdni = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lrucB = new System.Windows.Forms.Label();
            this.txtrucB = new System.Windows.Forms.MaskedTextBox();
            this.txtdniB = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.LdniB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(318, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 377);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Celular:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(81, 156);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(157, 20);
            this.txtapellido.TabIndex = 39;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(81, 123);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(157, 20);
            this.txtnombre.TabIndex = 38;
            // 
            // lapellido
            // 
            this.lapellido.AutoSize = true;
            this.lapellido.Location = new System.Drawing.Point(23, 159);
            this.lapellido.Name = "lapellido";
            this.lapellido.Size = new System.Drawing.Size(52, 13);
            this.lapellido.TabIndex = 32;
            this.lapellido.Text = "Apellidos:";
            // 
            // ldni
            // 
            this.ldni.AutoSize = true;
            this.ldni.Location = new System.Drawing.Point(46, 192);
            this.ldni.Name = "ldni";
            this.ldni.Size = new System.Drawing.Size(29, 13);
            this.ldni.TabIndex = 31;
            this.ldni.Text = "DNI:";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(28, 126);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(47, 13);
            this.lnombre.TabIndex = 30;
            this.lnombre.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtnacimiento);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Controls.Add(this.ldireccion);
            this.panel1.Controls.Add(this.lruc);
            this.panel1.Controls.Add(this.txtruc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lnacimiento);
            this.panel1.Controls.Add(this.txtcelular);
            this.panel1.Controls.Add(this.txtdni);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtcorreo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lnombre);
            this.panel1.Controls.Add(this.ldni);
            this.panel1.Controls.Add(this.lapellido);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtapellido);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 377);
            this.panel1.TabIndex = 55;
            // 
            // dtnacimiento
            // 
            this.dtnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnacimiento.Location = new System.Drawing.Point(81, 287);
            this.dtnacimiento.Name = "dtnacimiento";
            this.dtnacimiento.Size = new System.Drawing.Size(157, 20);
            this.dtnacimiento.TabIndex = 133;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(81, 189);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(157, 20);
            this.txtdireccion.TabIndex = 132;
            // 
            // ldireccion
            // 
            this.ldireccion.AutoSize = true;
            this.ldireccion.Location = new System.Drawing.Point(20, 192);
            this.ldireccion.Name = "ldireccion";
            this.ldireccion.Size = new System.Drawing.Size(55, 13);
            this.ldireccion.TabIndex = 131;
            this.ldireccion.Text = "Direccion:";
            // 
            // lruc
            // 
            this.lruc.AutoSize = true;
            this.lruc.Location = new System.Drawing.Point(42, 159);
            this.lruc.Name = "lruc";
            this.lruc.Size = new System.Drawing.Size(33, 13);
            this.lruc.TabIndex = 130;
            this.lruc.Text = "RUC:";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(81, 156);
            this.txtruc.Mask = "99999999999";
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(157, 20);
            this.txtruc.TabIndex = 127;
            this.txtruc.ValidatingType = typeof(int);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdempresa);
            this.panel2.Controls.Add(this.rdpersona);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 38);
            this.panel2.TabIndex = 129;
            // 
            // rdempresa
            // 
            this.rdempresa.AutoSize = true;
            this.rdempresa.Location = new System.Drawing.Point(131, 8);
            this.rdempresa.Name = "rdempresa";
            this.rdempresa.Size = new System.Drawing.Size(66, 17);
            this.rdempresa.TabIndex = 60;
            this.rdempresa.TabStop = true;
            this.rdempresa.Text = "Empresa";
            this.rdempresa.UseVisualStyleBackColor = true;
            this.rdempresa.CheckedChanged += new System.EventHandler(this.rdempresa_CheckedChanged);
            // 
            // rdpersona
            // 
            this.rdpersona.AutoSize = true;
            this.rdpersona.Location = new System.Drawing.Point(61, 8);
            this.rdpersona.Name = "rdpersona";
            this.rdpersona.Size = new System.Drawing.Size(64, 17);
            this.rdpersona.TabIndex = 59;
            this.rdpersona.TabStop = true;
            this.rdpersona.Text = "Persona";
            this.rdpersona.UseVisualStyleBackColor = true;
            this.rdpersona.CheckedChanged += new System.EventHandler(this.rdpersona_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tipo:";
            // 
            // lnacimiento
            // 
            this.lnacimiento.AutoSize = true;
            this.lnacimiento.Location = new System.Drawing.Point(12, 291);
            this.lnacimiento.Name = "lnacimiento";
            this.lnacimiento.Size = new System.Drawing.Size(63, 13);
            this.lnacimiento.TabIndex = 127;
            this.lnacimiento.Text = "Nacimiento:";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(81, 255);
            this.txtcelular.Mask = "999999999";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(157, 20);
            this.txtcelular.TabIndex = 126;
            this.txtcelular.ValidatingType = typeof(int);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(81, 189);
            this.txtdni.Mask = "99999999";
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(157, 20);
            this.txtdni.TabIndex = 125;
            this.txtdni.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label8.Location = new System.Drawing.Point(24, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 124;
            this.label8.Text = "Cliente";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(81, 222);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(157, 20);
            this.txtcorreo.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Correo:";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(160, 12);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(35, 34);
            this.btncancelar.TabIndex = 132;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(124, 12);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(30, 33);
            this.btneliminar.TabIndex = 131;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(50, 12);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(31, 33);
            this.btneditar.TabIndex = 130;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = ((System.Drawing.Image)(resources.GetObject("btnañadir.Image")));
            this.btnañadir.Location = new System.Drawing.Point(12, 12);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(32, 33);
            this.btnañadir.TabIndex = 129;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(87, 12);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(31, 33);
            this.btnguardar.TabIndex = 128;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lrucB);
            this.panel3.Controls.Add(this.txtrucB);
            this.panel3.Controls.Add(this.txtdniB);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.LdniB);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtnombrecliente);
            this.panel3.Controls.Add(this.btBuscar);
            this.panel3.Location = new System.Drawing.Point(318, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 52);
            this.panel3.TabIndex = 141;
            // 
            // lrucB
            // 
            this.lrucB.AutoSize = true;
            this.lrucB.Location = new System.Drawing.Point(527, 16);
            this.lrucB.Name = "lrucB";
            this.lrucB.Size = new System.Drawing.Size(33, 13);
            this.lrucB.TabIndex = 134;
            this.lrucB.Text = "RUC:";
            // 
            // txtrucB
            // 
            this.txtrucB.Location = new System.Drawing.Point(562, 13);
            this.txtrucB.Mask = "99999999999";
            this.txtrucB.Name = "txtrucB";
            this.txtrucB.Size = new System.Drawing.Size(142, 20);
            this.txtrucB.TabIndex = 134;
            this.txtrucB.ValidatingType = typeof(int);
            // 
            // txtdniB
            // 
            this.txtdniB.Location = new System.Drawing.Point(562, 13);
            this.txtdniB.Mask = "99999999";
            this.txtdniB.Name = "txtdniB";
            this.txtdniB.Size = new System.Drawing.Size(142, 20);
            this.txtdniB.TabIndex = 134;
            this.txtdniB.ValidatingType = typeof(int);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radioButton2);
            this.panel4.Controls.Add(this.radioButton1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(13, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 38);
            this.panel4.TabIndex = 134;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(131, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 60;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Empresa";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(61, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 59;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Persona";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tipo:";
            // 
            // LdniB
            // 
            this.LdniB.AutoSize = true;
            this.LdniB.Location = new System.Drawing.Point(527, 15);
            this.LdniB.Name = "LdniB";
            this.LdniB.Size = new System.Drawing.Size(29, 13);
            this.LdniB.TabIndex = 16;
            this.LdniB.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(308, 12);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(199, 20);
            this.txtnombrecliente.TabIndex = 14;
            // 
            // btBuscar
            // 
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(726, 7);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(40, 28);
            this.btBuscar.TabIndex = 132;
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // TablaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 458);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.SeleecionarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lapellido;
        private System.Windows.Forms.Label ldni;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.MaskedTextBox txtdni;
        private System.Windows.Forms.MaskedTextBox txtruc;
        private System.Windows.Forms.Label lnacimiento;
        private System.Windows.Forms.Label lruc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdempresa;
        private System.Windows.Forms.RadioButton rdpersona;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label ldireccion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.DateTimePicker dtnacimiento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LdniB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.MaskedTextBox txtrucB;
        private System.Windows.Forms.MaskedTextBox txtdniB;
        private System.Windows.Forms.Label lrucB;
    }
}