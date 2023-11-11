namespace sistema_de_viajes
{
    partial class Seleccionarprograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccionarprograma));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 333);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(981, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 69;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 135;
            this.label4.Text = "Seleccione el cronograma que desea el cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 25);
            this.label5.TabIndex = 136;
            this.label5.Text = "Cronogramas disponibles";
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
            this.panel2.Location = new System.Drawing.Point(15, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 81);
            this.panel2.TabIndex = 139;
            // 
            // mtxtfechaB
            // 
            this.mtxtfechaB.Location = new System.Drawing.Point(761, 47);
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
            this.button5.Location = new System.Drawing.Point(941, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 28);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtdestinoB
            // 
            this.txtdestinoB.Location = new System.Drawing.Point(407, 46);
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
            this.label6.Location = new System.Drawing.Point(702, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 50);
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
            // Seleccionarprograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Seleccionarprograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Programa";
            this.Load += new System.EventHandler(this.Seleccionarprograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mtxtfechaB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtdestinoB;
        private System.Windows.Forms.TextBox txtorigenB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}