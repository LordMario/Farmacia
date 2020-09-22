namespace Farmacia
{
    partial class ActualizarPrecio
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
            this.cboxProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxprecio = new System.Windows.Forms.TextBox();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPrecioActual = new System.Windows.Forms.TextBox();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxProducto
            // 
            this.cboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProducto.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProducto.FormattingEnabled = true;
            this.cboxProducto.Location = new System.Drawing.Point(89, 35);
            this.cboxProducto.Name = "cboxProducto";
            this.cboxProducto.Size = new System.Drawing.Size(232, 26);
            this.cboxProducto.TabIndex = 0;
            this.cboxProducto.SelectedIndexChanged += new System.EventHandler(this.cboxprod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo Precio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tboxprecio
            // 
            this.tboxprecio.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxprecio.Location = new System.Drawing.Point(127, 141);
            this.tboxprecio.Name = "tboxprecio";
            this.tboxprecio.Size = new System.Drawing.Size(72, 25);
            this.tboxprecio.TabIndex = 3;
            this.tboxprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // bttGuardar
            // 
            this.bttGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.Location = new System.Drawing.Point(93, 208);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(134, 34);
            this.bttGuardar.TabIndex = 4;
            this.bttGuardar.Text = "Guardar Cambios";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.Location = new System.Drawing.Point(422, 38);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(40, 20);
            this.tbxCodigo.TabIndex = 6;
            this.tbxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCodigo.TextChanged += new System.EventHandler(this.tbxCodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio Actual:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbPrecioActual
            // 
            this.txbPrecioActual.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecioActual.Location = new System.Drawing.Point(127, 97);
            this.txbPrecioActual.Name = "txbPrecioActual";
            this.txbPrecioActual.ReadOnly = true;
            this.txbPrecioActual.Size = new System.Drawing.Size(100, 25);
            this.txbPrecioActual.TabIndex = 8;
            // 
            // bttCancelar
            // 
            this.bttCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar.Location = new System.Drawing.Point(288, 208);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(128, 34);
            this.bttCancelar.TabIndex = 9;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // ActualizarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 254);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.txbPrecioActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.tboxprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ActualizarPrecio";
            this.Text = "ActualizarPrecio";
            this.Load += new System.EventHandler(this.ActualizarPrecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxprecio;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPrecioActual;
        private System.Windows.Forms.Button bttCancelar;
    }
}