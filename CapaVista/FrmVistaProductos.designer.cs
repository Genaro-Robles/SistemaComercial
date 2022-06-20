namespace CapaVista
{
    partial class FrmVistaProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarProd = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnActualizarProd = new System.Windows.Forms.Button();
            this.btnAdicionarProd = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnCerrarProd);
            this.panel1.Controls.Add(this.btnEliminarProd);
            this.panel1.Controls.Add(this.btnActualizarProd);
            this.panel1.Controls.Add(this.btnAdicionarProd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 388);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrarProd
            // 
            this.btnCerrarProd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCerrarProd.FlatAppearance.BorderSize = 2;
            this.btnCerrarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarProd.Location = new System.Drawing.Point(26, 261);
            this.btnCerrarProd.Name = "btnCerrarProd";
            this.btnCerrarProd.Size = new System.Drawing.Size(151, 73);
            this.btnCerrarProd.TabIndex = 0;
            this.btnCerrarProd.Text = "Cerrar Ventana";
            this.btnCerrarProd.UseVisualStyleBackColor = false;
            this.btnCerrarProd.Click += new System.EventHandler(this.btnCerrarProd_Click);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminarProd.FlatAppearance.BorderSize = 2;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarProd.Location = new System.Drawing.Point(26, 182);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(151, 73);
            this.btnEliminarProd.TabIndex = 0;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnActualizarProd
            // 
            this.btnActualizarProd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnActualizarProd.FlatAppearance.BorderSize = 2;
            this.btnActualizarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarProd.Location = new System.Drawing.Point(26, 103);
            this.btnActualizarProd.Name = "btnActualizarProd";
            this.btnActualizarProd.Size = new System.Drawing.Size(151, 73);
            this.btnActualizarProd.TabIndex = 0;
            this.btnActualizarProd.Text = "Actualizar";
            this.btnActualizarProd.UseVisualStyleBackColor = false;
            this.btnActualizarProd.Click += new System.EventHandler(this.btnActualizarProd_Click);
            // 
            // btnAdicionarProd
            // 
            this.btnAdicionarProd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdicionarProd.FlatAppearance.BorderSize = 2;
            this.btnAdicionarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarProd.Location = new System.Drawing.Point(26, 24);
            this.btnAdicionarProd.Name = "btnAdicionarProd";
            this.btnAdicionarProd.Size = new System.Drawing.Size(151, 73);
            this.btnAdicionarProd.TabIndex = 0;
            this.btnAdicionarProd.Text = "Adicionar";
            this.btnAdicionarProd.UseVisualStyleBackColor = false;
            this.btnAdicionarProd.Click += new System.EventHandler(this.btnAdicionarProd_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvProductos.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvProductos.Location = new System.Drawing.Point(15, 14);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(722, 359);
            this.dgvProductos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "IdProd.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Nombre";
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Material";
            this.Column4.HeaderText = "Material";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Personal";
            this.Column5.HeaderText = "Personal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Impuestos";
            this.Column6.HeaderText = "Impuestos";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Transporte";
            this.Column7.HeaderText = "Transporte";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 160;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.dgvProductos);
            this.panel2.Location = new System.Drawing.Point(241, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 388);
            this.panel2.TabIndex = 3;
            // 
            // FrmVistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmVistaProductos";
            this.Text = "FrmVistaProductos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarProd;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnActualizarProd;
        private System.Windows.Forms.Button btnAdicionarProd;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}