namespace CapaVista
{
    partial class FrmOperaPedidos
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
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dgdDetalle = new System.Windows.Forms.DataGrid();
            this.Label11 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombreP = new System.Windows.Forms.TextBox();
            this.cboCostos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtnroP = new System.Windows.Forms.TextBox();
            this.Cant = new System.Windows.Forms.NumericUpDown();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.cboP = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtuni = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDetalle)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cant)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(397, 431);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(103, 20);
            this.txttotal.TabIndex = 55;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgdDetalle
            // 
            this.dgdDetalle.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgdDetalle.BackColor = System.Drawing.Color.GhostWhite;
            this.dgdDetalle.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgdDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdDetalle.CaptionBackColor = System.Drawing.Color.RoyalBlue;
            this.dgdDetalle.CaptionForeColor = System.Drawing.Color.White;
            this.dgdDetalle.CaptionText = "Descripcion del Detalle";
            this.dgdDetalle.DataMember = "";
            this.dgdDetalle.FlatMode = true;
            this.dgdDetalle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgdDetalle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgdDetalle.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgdDetalle.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgdDetalle.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgdDetalle.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgdDetalle.LinkColor = System.Drawing.Color.Teal;
            this.dgdDetalle.Location = new System.Drawing.Point(12, 176);
            this.dgdDetalle.Name = "dgdDetalle";
            this.dgdDetalle.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgdDetalle.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgdDetalle.ReadOnly = true;
            this.dgdDetalle.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgdDetalle.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgdDetalle.Size = new System.Drawing.Size(488, 249);
            this.dgdDetalle.TabIndex = 53;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(321, 434);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(79, 13);
            this.Label11.TabIndex = 52;
            this.Label11.Text = "Total Monto:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.btnNuevo);
            this.Panel1.Controls.Add(this.btnAdministrar);
            this.Panel1.Controls.Add(this.btnRegistrar);
            this.Panel1.Controls.Add(this.btnEliminar);
            this.Panel1.Controls.Add(this.btnAgregar);
            this.Panel1.Location = new System.Drawing.Point(506, 176);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(126, 249);
            this.Panel1.TabIndex = 50;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(18, 182);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 44);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo Pedido";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.Location = new System.Drawing.Point(18, 139);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(94, 44);
            this.btnAdministrar.TabIndex = 3;
            this.btnAdministrar.Text = "Administrar Pedidos";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(18, 96);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 44);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar Pedido";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(18, 53);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 44);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Detalle";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(18, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 44);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Detalle";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.GroupBox1.Controls.Add(this.txtfecha);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.txtnombreP);
            this.GroupBox1.Controls.Add(this.cboCostos);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtnroP);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(619, 84);
            this.GroupBox1.TabIndex = 48;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del Pedido";
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(322, 40);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(99, 20);
            this.txtfecha.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha";
            // 
            // txtnombreP
            // 
            this.txtnombreP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombreP.Location = new System.Drawing.Point(126, 41);
            this.txtnombreP.Name = "txtnombreP";
            this.txtnombreP.Size = new System.Drawing.Size(153, 20);
            this.txtnombreP.TabIndex = 23;
            this.txtnombreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboCostos
            // 
            this.cboCostos.FormattingEnabled = true;
            this.cboCostos.Location = new System.Drawing.Point(494, 43);
            this.cboCostos.Name = "cboCostos";
            this.cboCostos.Size = new System.Drawing.Size(75, 21);
            this.cboCostos.TabIndex = 22;
            this.cboCostos.SelectedIndexChanged += new System.EventHandler(this.cboCostos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Id de Costos";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(157, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(93, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Nombre Pedido";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Nro.Pedido";
            // 
            // txtnroP
            // 
            this.txtnroP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnroP.Location = new System.Drawing.Point(10, 43);
            this.txtnroP.Name = "txtnroP";
            this.txtnroP.ReadOnly = true;
            this.txtnroP.Size = new System.Drawing.Size(92, 20);
            this.txtnroP.TabIndex = 0;
            this.txtnroP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Cant
            // 
            this.Cant.Location = new System.Drawing.Point(408, 36);
            this.Cant.Name = "Cant";
            this.Cant.Size = new System.Drawing.Size(53, 20);
            this.Cant.TabIndex = 14;
            this.Cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cant.ValueChanged += new System.EventHandler(this.Cant_ValueChanged);
            // 
            // txtmonto
            // 
            this.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmonto.Location = new System.Drawing.Point(482, 38);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.ReadOnly = true;
            this.txtmonto.Size = new System.Drawing.Size(99, 20);
            this.txtmonto.TabIndex = 13;
            this.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GroupBox2.Controls.Add(this.Cant);
            this.GroupBox2.Controls.Add(this.txtmonto);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.txtprecio);
            this.GroupBox2.Controls.Add(this.cboP);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(12, 102);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(619, 68);
            this.GroupBox2.TabIndex = 50;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Detalle del Producto";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(405, 19);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(57, 13);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Cantidad";
            // 
            // txtprecio
            // 
            this.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecio.Location = new System.Drawing.Point(297, 37);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(99, 20);
            this.txtprecio.TabIndex = 11;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboP
            // 
            this.cboP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboP.FormattingEnabled = true;
            this.cboP.Location = new System.Drawing.Point(4, 36);
            this.cboP.Name = "cboP";
            this.cboP.Size = new System.Drawing.Size(198, 21);
            this.cboP.TabIndex = 10;
            this.cboP.SelectedIndexChanged += new System.EventHandler(this.cboP_SelectedIndexChanged_1);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(482, 22);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(64, 13);
            this.Label9.TabIndex = 10;
            this.Label9.Text = "Monto S/.";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(7, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(133, 13);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Seleccionar Producto:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(300, 20);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 13);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Precio S/.";
            // 
            // txtuni
            // 
            this.txtuni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuni.Location = new System.Drawing.Point(129, 431);
            this.txtuni.Name = "txtuni";
            this.txtuni.ReadOnly = true;
            this.txtuni.Size = new System.Drawing.Size(103, 20);
            this.txtuni.TabIndex = 56;
            this.txtuni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(13, 434);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(113, 13);
            this.Label10.TabIndex = 55;
            this.Label10.Text = "Unidades Pedidos:";
            // 
            // FrmOperaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(643, 463);
            this.Controls.Add(this.txtuni);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dgdDetalle);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmOperaPedidos";
            this.Text = "FrmOperaPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgdDetalle)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cant)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txttotal;
        internal System.Windows.Forms.DataGrid dgdDetalle;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnAdministrar;
        internal System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtnroP;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboCostos;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtnombreP;
        internal System.Windows.Forms.NumericUpDown Cant;
        internal System.Windows.Forms.TextBox txtmonto;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtprecio;
        internal System.Windows.Forms.ComboBox cboP;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtuni;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.DateTimePicker txtfecha;
    }
}