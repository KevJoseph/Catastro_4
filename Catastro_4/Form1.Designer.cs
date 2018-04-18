namespace Catastro_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button btn1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNFicha = new System.Windows.Forms.TextBox();
            this.txtCodCont = new System.Windows.Forms.TextBox();
            this.txtCoopre = new System.Windows.Forms.TextBox();
            this.txtTipHab = new System.Windows.Forms.TextBox();
            this.txtNomHab = new System.Windows.Forms.TextBox();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtMz = new System.Windows.Forms.TextBox();
            this.txtLt = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            btn1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            label2.Location = new System.Drawing.Point(15, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 21);
            label2.TabIndex = 6;
            label2.Text = "Buscar :";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn1
            // 
            btn1.BackColor = System.Drawing.Color.DodgerBlue;
            btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1.ForeColor = System.Drawing.Color.White;
            btn1.Location = new System.Drawing.Point(274, 10);
            btn1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(131, 38);
            btn1.TabIndex = 3;
            btn1.Text = "Consultar";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(219, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "FICHA INDIVIDUAL (Consulta)";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.Lavender;
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(90, 19);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(170, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(label12);
            this.groupBox1.Controls.Add(this.txtLt);
            this.groupBox1.Controls.Add(label11);
            this.groupBox1.Controls.Add(this.txtMz);
            this.groupBox1.Controls.Add(label10);
            this.groupBox1.Controls.Add(this.txtSector);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.txtNomHab);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(this.txtTipHab);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(this.txtCoopre);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(this.txtCodCont);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.txtNFicha);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(label15);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 228);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(177, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 21);
            label4.TabIndex = 7;
            label4.Text = "Nombres:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(btn1);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 55);
            this.panel1.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Lavender;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(274, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(459, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Lavender;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(274, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(459, 20);
            this.txtApellido.TabIndex = 23;
            this.txtApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(177, 64);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(88, 21);
            label15.TabIndex = 24;
            label15.Text = "Apellidos: ";
            label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtNFicha
            // 
            this.txtNFicha.BackColor = System.Drawing.Color.Lavender;
            this.txtNFicha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFicha.Location = new System.Drawing.Point(274, 101);
            this.txtNFicha.Name = "txtNFicha";
            this.txtNFicha.Size = new System.Drawing.Size(73, 20);
            this.txtNFicha.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(177, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 20);
            label3.TabIndex = 26;
            label3.Text = "N° Ficha:";
            // 
            // txtCodCont
            // 
            this.txtCodCont.BackColor = System.Drawing.Color.Lavender;
            this.txtCodCont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCont.Location = new System.Drawing.Point(452, 101);
            this.txtCodCont.Name = "txtCodCont";
            this.txtCodCont.Size = new System.Drawing.Size(81, 20);
            this.txtCodCont.TabIndex = 27;
            this.txtCodCont.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(363, 101);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 20);
            label5.TabIndex = 28;
            label5.Text = "Cod Cont:";
            // 
            // txtCoopre
            // 
            this.txtCoopre.BackColor = System.Drawing.Color.Lavender;
            this.txtCoopre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoopre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoopre.Location = new System.Drawing.Point(631, 101);
            this.txtCoopre.Name = "txtCoopre";
            this.txtCoopre.Size = new System.Drawing.Size(73, 20);
            this.txtCoopre.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(542, 101);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 20);
            label6.TabIndex = 30;
            label6.Text = "COOPRE:";
            // 
            // txtTipHab
            // 
            this.txtTipHab.BackColor = System.Drawing.Color.Lavender;
            this.txtTipHab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipHab.Location = new System.Drawing.Point(274, 127);
            this.txtTipHab.Name = "txtTipHab";
            this.txtTipHab.Size = new System.Drawing.Size(73, 20);
            this.txtTipHab.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(177, 127);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(61, 20);
            label7.TabIndex = 32;
            label7.Text = "TipHab:";
            // 
            // txtNomHab
            // 
            this.txtNomHab.BackColor = System.Drawing.Color.Lavender;
            this.txtNomHab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomHab.Location = new System.Drawing.Point(452, 127);
            this.txtNomHab.Name = "txtNomHab";
            this.txtNomHab.Size = new System.Drawing.Size(81, 20);
            this.txtNomHab.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(363, 127);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(77, 20);
            label8.TabIndex = 34;
            label8.Text = "NomHab:";
            // 
            // txtSector
            // 
            this.txtSector.BackColor = System.Drawing.Color.Lavender;
            this.txtSector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.Location = new System.Drawing.Point(274, 156);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(81, 20);
            this.txtSector.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(178, 156);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(60, 20);
            label9.TabIndex = 36;
            label9.Text = "Sector:";
            // 
            // txtMz
            // 
            this.txtMz.BackColor = System.Drawing.Color.Lavender;
            this.txtMz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMz.Location = new System.Drawing.Point(452, 153);
            this.txtMz.Name = "txtMz";
            this.txtMz.Size = new System.Drawing.Size(39, 20);
            this.txtMz.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(363, 156);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(34, 20);
            label10.TabIndex = 38;
            label10.Text = "Mz:";
            // 
            // txtLt
            // 
            this.txtLt.BackColor = System.Drawing.Color.Lavender;
            this.txtLt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLt.Location = new System.Drawing.Point(631, 153);
            this.txtLt.Name = "txtLt";
            this.txtLt.Size = new System.Drawing.Size(39, 20);
            this.txtLt.TabIndex = 39;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(542, 153);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(25, 20);
            label11.TabIndex = 40;
            label11.Text = "Lt:";
            // 
            // txtRuc
            // 
            this.txtRuc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.Location = new System.Drawing.Point(631, 127);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(73, 20);
            this.txtRuc.TabIndex = 41;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.ForeColor = System.Drawing.SystemColors.Highlight;
            label12.Location = new System.Drawing.Point(542, 127);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(45, 20);
            label12.TabIndex = 42;
            label12.Text = "RUC:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 43);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(776, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ficha Individual";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodCont;
        private System.Windows.Forms.TextBox txtNFicha;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtLt;
        private System.Windows.Forms.TextBox txtMz;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.TextBox txtNomHab;
        private System.Windows.Forms.TextBox txtTipHab;
        private System.Windows.Forms.TextBox txtCoopre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

