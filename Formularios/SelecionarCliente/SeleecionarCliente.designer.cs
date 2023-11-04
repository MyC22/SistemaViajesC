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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaCliente));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminarCliente = new System.Windows.Forms.Button();
            this.btneditarCliente = new System.Windows.Forms.Button();
            this.btnañadirCliente = new System.Windows.Forms.Button();
            this.btnguardarCliente = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtapellidocliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcelularcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdestinocliente = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(1044, 15);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(36, 31);
            this.btncancelar.TabIndex = 138;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btneliminarCliente
            // 
            this.btneliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btneliminarCliente.Image")));
            this.btneliminarCliente.Location = new System.Drawing.Point(124, 12);
            this.btneliminarCliente.Name = "btneliminarCliente";
            this.btneliminarCliente.Size = new System.Drawing.Size(30, 33);
            this.btneliminarCliente.TabIndex = 137;
            this.btneliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btneditarCliente
            // 
            this.btneditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btneditarCliente.Image")));
            this.btneditarCliente.Location = new System.Drawing.Point(50, 12);
            this.btneditarCliente.Name = "btneditarCliente";
            this.btneditarCliente.Size = new System.Drawing.Size(31, 33);
            this.btneditarCliente.TabIndex = 135;
            this.btneditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnañadirCliente
            // 
            this.btnañadirCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnañadirCliente.Image")));
            this.btnañadirCliente.Location = new System.Drawing.Point(12, 12);
            this.btnañadirCliente.Name = "btnañadirCliente";
            this.btnañadirCliente.Size = new System.Drawing.Size(32, 33);
            this.btnañadirCliente.TabIndex = 134;
            this.btnañadirCliente.UseVisualStyleBackColor = true;
            // 
            // btnguardarCliente
            // 
            this.btnguardarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnguardarCliente.Image")));
            this.btnguardarCliente.Location = new System.Drawing.Point(87, 12);
            this.btnguardarCliente.Name = "btnguardarCliente";
            this.btnguardarCliente.Size = new System.Drawing.Size(31, 33);
            this.btnguardarCliente.TabIndex = 133;
            this.btnguardarCliente.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1033, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 28);
            this.button5.TabIndex = 132;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtdestinocliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcelularcliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnombrecliente);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.txtapellidocliente);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 72);
            this.panel1.TabIndex = 131;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellidos:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(74, 26);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(199, 20);
            this.txtnombrecliente.TabIndex = 14;
            // 
            // txtapellidocliente
            // 
            this.txtapellidocliente.Location = new System.Drawing.Point(337, 26);
            this.txtapellidocliente.Name = "txtapellidocliente";
            this.txtapellidocliente.Size = new System.Drawing.Size(204, 20);
            this.txtapellidocliente.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 316);
            this.dataGridView1.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Celular:";
            // 
            // txtcelularcliente
            // 
            this.txtcelularcliente.Location = new System.Drawing.Point(595, 26);
            this.txtcelularcliente.Name = "txtcelularcliente";
            this.txtcelularcliente.Size = new System.Drawing.Size(190, 20);
            this.txtcelularcliente.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "Destino:";
            // 
            // txtdestinocliente
            // 
            this.txtdestinocliente.FormattingEnabled = true;
            this.txtdestinocliente.Location = new System.Drawing.Point(843, 26);
            this.txtdestinocliente.Name = "txtdestinocliente";
            this.txtdestinocliente.Size = new System.Drawing.Size(184, 21);
            this.txtdestinocliente.TabIndex = 135;
            // 
            // TablaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 458);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminarCliente);
            this.Controls.Add(this.btneditarCliente);
            this.Controls.Add(this.btnañadirCliente);
            this.Controls.Add(this.btnguardarCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaCliente";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminarCliente;
        private System.Windows.Forms.Button btneditarCliente;
        private System.Windows.Forms.Button btnañadirCliente;
        private System.Windows.Forms.Button btnguardarCliente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtapellidocliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtdestinocliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcelularcliente;
    }
}