namespace sistema_de_viajes
{
    partial class TablaPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaPrograma));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.cbturno = new System.Windows.Forms.ComboBox();
            this.mtxtturno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbuses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtservicio = new System.Windows.Forms.TextBox();
            this.txtpiso2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpiso1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtxtfechaB = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtdestinoB = new System.Windows.Forms.TextBox();
            this.txtorigenB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1072, 364);
            this.dataGridView1.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(815, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 61);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 17);
            this.radioButton3.TabIndex = 42;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Turno definidos";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 7);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 17);
            this.radioButton4.TabIndex = 41;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Turno";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // cbturno
            // 
            this.cbturno.FormattingEnabled = true;
            this.cbturno.Location = new System.Drawing.Point(953, 75);
            this.cbturno.Name = "cbturno";
            this.cbturno.Size = new System.Drawing.Size(92, 21);
            this.cbturno.TabIndex = 49;
            // 
            // mtxtturno
            // 
            this.mtxtturno.Location = new System.Drawing.Point(953, 49);
            this.mtxtturno.Mask = "00:00";
            this.mtxtturno.Name = "mtxtturno";
            this.mtxtturno.Size = new System.Drawing.Size(92, 20);
            this.mtxtturno.TabIndex = 51;
            this.mtxtturno.ValidatingType = typeof(System.DateTime);
            this.mtxtturno.MaskChanged += new System.EventHandler(this.mtxtturno_MaskChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Buses disponibles:";
            // 
            // cbbuses
            // 
            this.cbbuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbuses.FormattingEnabled = true;
            this.cbbuses.Location = new System.Drawing.Point(106, 85);
            this.cbbuses.Name = "cbbuses";
            this.cbbuses.Size = new System.Drawing.Size(224, 21);
            this.cbbuses.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Servicio:";
            // 
            // txtservicio
            // 
            this.txtservicio.Enabled = false;
            this.txtservicio.Location = new System.Drawing.Point(394, 87);
            this.txtservicio.Name = "txtservicio";
            this.txtservicio.Size = new System.Drawing.Size(187, 20);
            this.txtservicio.TabIndex = 57;
            // 
            // txtpiso2
            // 
            this.txtpiso2.Enabled = false;
            this.txtpiso2.Location = new System.Drawing.Point(666, 86);
            this.txtpiso2.Name = "txtpiso2";
            this.txtpiso2.Size = new System.Drawing.Size(114, 20);
            this.txtpiso2.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Precio piso 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(783, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "/S";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Fecha:";
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(394, 39);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(187, 20);
            this.dtfecha.TabIndex = 67;
            this.dtfecha.ValueChanged += new System.EventHandler(this.dtfecha_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtruta);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtpiso1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtpiso2);
            this.panel1.Controls.Add(this.dtfecha);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbturno);
            this.panel1.Controls.Add(this.mtxtturno);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtservicio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbuses);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 125);
            this.panel1.TabIndex = 68;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 147;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtruta
            // 
            this.txtruta.Enabled = false;
            this.txtruta.Location = new System.Drawing.Point(87, 42);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(159, 20);
            this.txtruta.TabIndex = 72;
            this.txtruta.TextChanged += new System.EventHandler(this.txtruta_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label13.Location = new System.Drawing.Point(7, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "Cronograma";
            // 
            // txtpiso1
            // 
            this.txtpiso1.Enabled = false;
            this.txtpiso1.Location = new System.Drawing.Point(666, 39);
            this.txtpiso1.Name = "txtpiso1";
            this.txtpiso1.Size = new System.Drawing.Size(114, 20);
            this.txtpiso1.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(783, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "/S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Precio piso1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Ruta:";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(155, 10);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(35, 34);
            this.btncancelar.TabIndex = 137;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(119, 10);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(30, 33);
            this.btneliminar.TabIndex = 136;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(45, 10);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(31, 33);
            this.btneditar.TabIndex = 135;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnañadir
            // 
            this.btnañadir.Image = ((System.Drawing.Image)(resources.GetObject("btnañadir.Image")));
            this.btnañadir.Location = new System.Drawing.Point(7, 10);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(32, 33);
            this.btnañadir.TabIndex = 134;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(82, 10);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(31, 33);
            this.btnguardar.TabIndex = 133;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mtxtfechaB);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.txtdestinoB);
            this.panel2.Controls.Add(this.txtorigenB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(12, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 81);
            this.panel2.TabIndex = 138;
            // 
            // mtxtfechaB
            // 
            this.mtxtfechaB.Location = new System.Drawing.Point(796, 47);
            this.mtxtfechaB.Mask = "00/00/0000";
            this.mtxtfechaB.Name = "mtxtfechaB";
            this.mtxtfechaB.Size = new System.Drawing.Size(151, 20);
            this.mtxtfechaB.TabIndex = 18;
            this.mtxtfechaB.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label12.Location = new System.Drawing.Point(8, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Buscar";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(986, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 28);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtdestinoB
            // 
            this.txtdestinoB.Location = new System.Drawing.Point(415, 46);
            this.txtdestinoB.Name = "txtdestinoB";
            this.txtdestinoB.Size = new System.Drawing.Size(264, 20);
            this.txtdestinoB.TabIndex = 10;
            // 
            // txtorigenB
            // 
            this.txtorigenB.Location = new System.Drawing.Point(71, 46);
            this.txtorigenB.Name = "txtorigenB";
            this.txtorigenB.Size = new System.Drawing.Size(256, 20);
            this.txtorigenB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(737, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Destino:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Origen:";
            // 
            // TablaPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Programa";
            this.Load += new System.EventHandler(this.TablaPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ComboBox cbturno;
        private System.Windows.Forms.MaskedTextBox mtxtturno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbuses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtservicio;
        private System.Windows.Forms.TextBox txtpiso2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpiso1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtdestinoB;
        private System.Windows.Forms.TextBox txtorigenB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mtxtfechaB;
    }
}