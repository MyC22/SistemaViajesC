namespace sistema_de_viajes
{
    partial class CrearBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearBoleto));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lprecio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbpiso = new System.Windows.Forms.ComboBox();
            this.lnombre = new System.Windows.Forms.Label();
            this.lapellido = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtasientos = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.Precio});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 399);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lprecio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbpiso);
            this.panel1.Controls.Add(this.lnombre);
            this.panel1.Controls.Add(this.lapellido);
            this.panel1.Controls.Add(this.txtapellido);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 59);
            this.panel1.TabIndex = 28;
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.Location = new System.Drawing.Point(795, 20);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(36, 13);
            this.lprecio.TabIndex = 150;
            this.lprecio.Text = "precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 149;
            this.label2.Text = "S/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 148;
            this.label1.Text = "Piso:";
            // 
            // cbpiso
            // 
            this.cbpiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpiso.FormattingEnabled = true;
            this.cbpiso.Items.AddRange(new object[] {
            "Piso 2",
            "Piso 1"});
            this.cbpiso.Location = new System.Drawing.Point(567, 16);
            this.cbpiso.Name = "cbpiso";
            this.cbpiso.Size = new System.Drawing.Size(186, 21);
            this.cbpiso.TabIndex = 147;
            this.cbpiso.SelectedIndexChanged += new System.EventHandler(this.cbpiso_SelectedIndexChanged);
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(27, 20);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(47, 13);
            this.lnombre.TabIndex = 145;
            this.lnombre.Text = "Nombre:";
            // 
            // lapellido
            // 
            this.lapellido.AutoSize = true;
            this.lapellido.Location = new System.Drawing.Point(264, 20);
            this.lapellido.Name = "lapellido";
            this.lapellido.Size = new System.Drawing.Size(52, 13);
            this.lapellido.TabIndex = 146;
            this.lapellido.Text = "Apellidos:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(322, 17);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(157, 20);
            this.txtapellido.TabIndex = 144;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(80, 17);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(157, 20);
            this.txtnombre.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(856, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 151;
            this.label5.Text = "S/";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(158, 10);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(35, 34);
            this.btncancelar.TabIndex = 142;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(122, 10);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(30, 33);
            this.btneliminar.TabIndex = 141;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(48, 10);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(31, 33);
            this.btneditar.TabIndex = 140;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Image = ((System.Drawing.Image)(resources.GetObject("btnañadir.Image")));
            this.btnañadir.Location = new System.Drawing.Point(10, 10);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(32, 33);
            this.btnañadir.TabIndex = 139;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(85, 10);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(31, 33);
            this.btnguardar.TabIndex = 138;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(878, 523);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(137, 20);
            this.txttotal.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 151;
            this.label4.Text = "Acientos disponibles:";
            // 
            // txtasientos
            // 
            this.txtasientos.Enabled = false;
            this.txtasientos.Location = new System.Drawing.Point(650, 523);
            this.txtasientos.Name = "txtasientos";
            this.txtasientos.Size = new System.Drawing.Size(97, 20);
            this.txtasientos.TabIndex = 152;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 153;
            this.button2.Text = "Confirmar compra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrearBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 565);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtasientos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.btnguardar);
            this.Name = "CrearBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CrearBoleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label lapellido;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtasientos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbpiso;
    }
}