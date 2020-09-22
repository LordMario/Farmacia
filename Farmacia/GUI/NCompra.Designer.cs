namespace Farmacia
{
    partial class NCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCompra));
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbCodProd = new System.Windows.Forms.TextBox();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCosto = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbIDProv = new System.Windows.Forms.TextBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txbFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCompra.Location = new System.Drawing.Point(59, 224);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCompra.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(463, 204);
            this.dgvCompra.TabIndex = 0;
            this.dgvCompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellEndEdit);
            this.dgvCompra.DoubleClick += new System.EventHandler(this.dgvCompra_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bttCancelar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.bttGuardar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 480);
            this.panel1.TabIndex = 1;
            // 
            // bttGuardar
            // 
            this.bttGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttGuardar.FlatAppearance.BorderSize = 0;
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.Image = ((System.Drawing.Image)(resources.GetObject("bttGuardar.Image")));
            this.bttGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttGuardar.Location = new System.Drawing.Point(540, 241);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(140, 70);
            this.bttGuardar.TabIndex = 5;
            this.bttGuardar.Text = "Guardar Compra";
            this.bttGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttCancelar.FlatAppearance.BorderSize = 0;
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bttCancelar.Image")));
            this.bttCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttCancelar.Location = new System.Drawing.Point(575, 349);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 58);
            this.bttCancelar.TabIndex = 4;
            this.bttCancelar.Text = "Salir";
            this.bttCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txbCodProd);
            this.groupBox2.Controls.Add(this.bttEliminar);
            this.groupBox2.Controls.Add(this.bttAgregar);
            this.groupBox2.Controls.Add(this.txbCosto);
            this.groupBox2.Controls.Add(this.txbCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxProducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(22, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Compra";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txbCodProd
            // 
            this.txbCodProd.Enabled = false;
            this.txbCodProd.Location = new System.Drawing.Point(74, 52);
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.Size = new System.Drawing.Size(54, 20);
            this.txbCodProd.TabIndex = 25;
            // 
            // bttEliminar
            // 
            this.bttEliminar.FlatAppearance.BorderSize = 0;
            this.bttEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEliminar.Image = ((System.Drawing.Image)(resources.GetObject("bttEliminar.Image")));
            this.bttEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttEliminar.Location = new System.Drawing.Point(508, 19);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(83, 50);
            this.bttEliminar.TabIndex = 23;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // bttAgregar
            // 
            this.bttAgregar.FlatAppearance.BorderSize = 0;
            this.bttAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAgregar.Image = ((System.Drawing.Image)(resources.GetObject("bttAgregar.Image")));
            this.bttAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttAgregar.Location = new System.Drawing.Point(425, 20);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(75, 50);
            this.bttAgregar.TabIndex = 20;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // txbTotal
            // 
            this.txbTotal.Enabled = false;
            this.txbTotal.Location = new System.Drawing.Point(430, 434);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(75, 20);
            this.txbTotal.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total:";
            // 
            // txbCosto
            // 
            this.txbCosto.Location = new System.Drawing.Point(317, 23);
            this.txbCosto.Name = "txbCosto";
            this.txbCosto.Size = new System.Drawing.Size(40, 20);
            this.txbCosto.TabIndex = 19;
            this.txbCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCosto_KeyPress);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(317, 52);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(41, 20);
            this.txbCantidad.TabIndex = 18;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Costo:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(74, 23);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(138, 21);
            this.cbxProducto.TabIndex = 16;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbIDProv);
            this.groupBox1.Controls.Add(this.cbxProveedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txbFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra";
            // 
            // txbIDProv
            // 
            this.txbIDProv.Enabled = false;
            this.txbIDProv.Location = new System.Drawing.Point(566, 31);
            this.txbIDProv.Name = "txbIDProv";
            this.txbIDProv.Size = new System.Drawing.Size(36, 20);
            this.txbIDProv.TabIndex = 12;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.BackColor = System.Drawing.Color.White;
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(417, 31);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(134, 21);
            this.cbxProveedor.TabIndex = 1;
            this.cbxProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxProveedor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Proveedor:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(253, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(75, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // txbFactura
            // 
            this.txbFactura.Location = new System.Drawing.Point(123, 30);
            this.txbFactura.MaxLength = 8;
            this.txbFactura.Name = "txbFactura";
            this.txbFactura.Size = new System.Drawing.Size(66, 20);
            this.txbFactura.TabIndex = 1;
            this.txbFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFactura_KeyPress);
            this.txbFactura.Leave += new System.EventHandler(this.txbFactura_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura Compra:";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Codigo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "C. Unit.";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cant.";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Subtotal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(597, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Eliminar todo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Código:";
            // 
            // NCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NCompra";
            this.Text = "NCompra";
            this.Load += new System.EventHandler(this.NCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txbFactura;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCosto;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbIDProv;
        private System.Windows.Forms.TextBox txbCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}