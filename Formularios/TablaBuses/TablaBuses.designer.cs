using System;

namespace sistema_de_viajes
{
    partial class TablaBuses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaBuses));
            this.dateDisponible = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textLugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textFiltrar = new System.Windows.Forms.TextBox();
            this.comboFiltrar = new System.Windows.Forms.ComboBox();
            this.DvgDatos = new System.Windows.Forms.DataGridView();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DvgDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateDisponible
            // 
            this.dateDisponible.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDisponible.Location = new System.Drawing.Point(75, 177);
            this.dateDisponible.MinDate = new System.DateTime(2023, 11, 11, 11, 39, 37, 706);
            this.dateDisponible.Name = "dateDisponible";
            this.dateDisponible.Size = new System.Drawing.Size(193, 20);
            this.dateDisponible.TabIndex = 77;
            this.dateDisponible.Value = new System.DateTime(2023, 11, 11, 11, 39, 37, 707);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Disponible:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 73;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textLugar
            // 
            this.textLugar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textLugar.Location = new System.Drawing.Point(75, 139);
            this.textLugar.Name = "textLugar";
            this.textLugar.Size = new System.Drawing.Size(193, 20);
            this.textLugar.TabIndex = 67;
            this.textLugar.Text = "Lugar";
            this.textLugar.Enter += new System.EventHandler(this.textLugar_Enter);
            this.textLugar.Leave += new System.EventHandler(this.textLugar_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Lugar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Placa:";
            // 
            // textFiltrar
            // 
            this.textFiltrar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textFiltrar.Location = new System.Drawing.Point(628, 16);
            this.textFiltrar.Name = "textFiltrar";
            this.textFiltrar.Size = new System.Drawing.Size(146, 20);
            this.textFiltrar.TabIndex = 59;
            this.textFiltrar.Text = "Buscar por filtro";
            this.textFiltrar.Enter += new System.EventHandler(this.textFiltrar_Enter);
            // 
            // comboFiltrar
            // 
            this.comboFiltrar.FormattingEnabled = true;
            this.comboFiltrar.Location = new System.Drawing.Point(452, 16);
            this.comboFiltrar.Name = "comboFiltrar";
            this.comboFiltrar.Size = new System.Drawing.Size(170, 21);
            this.comboFiltrar.TabIndex = 58;
            // 
            // DvgDatos
            // 
            this.DvgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DvgDatos.Location = new System.Drawing.Point(324, 48);
            this.DvgDatos.Name = "DvgDatos";
            this.DvgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgDatos.Size = new System.Drawing.Size(644, 335);
            this.DvgDatos.TabIndex = 57;
            this.DvgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgDatos_CellClick);
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(74, 99);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(194, 21);
            this.comboModelo.TabIndex = 78;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(789, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 28);
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textPlaca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textLugar);
            this.panel1.Controls.Add(this.comboModelo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateDisponible);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 335);
            this.panel1.TabIndex = 80;
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(75, 65);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(193, 20);
            this.textPlaca.TabIndex = 82;
            this.textPlaca.Text = "Placa";
            this.textPlaca.TextChanged += new System.EventHandler(this.textPlaca_TextChanged);
            this.textPlaca.Enter += new System.EventHandler(this.textPlaca_Enter_1);
            this.textPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPlaca_KeyPress);
            this.textPlaca.Leave += new System.EventHandler(this.textPlaca_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Buses";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(176, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 74;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(338, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 83;
            this.label7.Text = "Buscar";
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(160, 6);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(35, 34);
            this.btncancelar.TabIndex = 142;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(124, 6);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(30, 33);
            this.btneliminar.TabIndex = 141;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(50, 6);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(31, 33);
            this.btneditar.TabIndex = 140;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnañadir.Image = ((System.Drawing.Image)(resources.GetObject("btnañadir.Image")));
            this.btnañadir.Location = new System.Drawing.Point(12, 6);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(32, 33);
            this.btnañadir.TabIndex = 139;
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnanadir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(87, 6);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(31, 33);
            this.btnguardar.TabIndex = 138;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // TablaBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 400);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textFiltrar);
            this.Controls.Add(this.comboFiltrar);
            this.Controls.Add(this.DvgDatos);
            this.Name = "TablaBuses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buses";
            this.Load += new System.EventHandler(this.TablaBuses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDisponible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textLugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFiltrar;
        private System.Windows.Forms.ComboBox comboFiltrar;
        private System.Windows.Forms.DataGridView DvgDatos;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textPlaca;
    }
}