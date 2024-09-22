namespace pry_GestionInventario_Torres
{
    partial class frmModificarProducto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbModificarCategoria = new System.Windows.Forms.ComboBox();
            this.richDescripcionModificar = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockModificar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioModificar = new System.Windows.Forms.TextBox();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.txtCodigoModificar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.optBuscarCategoria = new System.Windows.Forms.RadioButton();
            this.optBuscarCodigo = new System.Windows.Forms.RadioButton();
            this.optBuscarNombre = new System.Windows.Forms.RadioButton();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.cmbModificarCategoria);
            this.groupBox1.Controls.Add(this.richDescripcionModificar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStockModificar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioModificar);
            this.groupBox1.Controls.Add(this.btnModificarProducto);
            this.groupBox1.Controls.Add(this.txtNombreModificar);
            this.groupBox1.Controls.Add(this.txtCodigoModificar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 195);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Producto";
            // 
            // cmbModificarCategoria
            // 
            this.cmbModificarCategoria.FormattingEnabled = true;
            this.cmbModificarCategoria.Location = new System.Drawing.Point(74, 61);
            this.cmbModificarCategoria.Name = "cmbModificarCategoria";
            this.cmbModificarCategoria.Size = new System.Drawing.Size(148, 21);
            this.cmbModificarCategoria.TabIndex = 25;
            // 
            // richDescripcionModificar
            // 
            this.richDescripcionModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richDescripcionModificar.Location = new System.Drawing.Point(76, 99);
            this.richDescripcionModificar.Name = "richDescripcionModificar";
            this.richDescripcionModificar.Size = new System.Drawing.Size(377, 78);
            this.richDescripcionModificar.TabIndex = 24;
            this.richDescripcionModificar.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Descripción: ";
            // 
            // txtStockModificar
            // 
            this.txtStockModificar.Location = new System.Drawing.Point(279, 61);
            this.txtStockModificar.Name = "txtStockModificar";
            this.txtStockModificar.Size = new System.Drawing.Size(71, 20);
            this.txtStockModificar.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Categoria: ";
            // 
            // txtPrecioModificar
            // 
            this.txtPrecioModificar.Location = new System.Drawing.Point(439, 25);
            this.txtPrecioModificar.Name = "txtPrecioModificar";
            this.txtPrecioModificar.Size = new System.Drawing.Size(71, 20);
            this.txtPrecioModificar.TabIndex = 18;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(499, 144);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(127, 33);
            this.btnModificarProducto.TabIndex = 15;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Location = new System.Drawing.Point(218, 25);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(146, 20);
            this.txtNombreModificar.TabIndex = 15;
            // 
            // txtCodigoModificar
            // 
            this.txtCodigoModificar.Location = new System.Drawing.Point(62, 25);
            this.txtCodigoModificar.Name = "txtCodigoModificar";
            this.txtCodigoModificar.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoModificar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Codigo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProductos.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 168);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(645, 141);
            this.dgvProductos.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Controls.Add(this.optBuscarCategoria);
            this.groupBox2.Controls.Add(this.optBuscarCodigo);
            this.groupBox2.Controls.Add(this.optBuscarNombre);
            this.groupBox2.Controls.Add(this.btnBuscarProducto);
            this.groupBox2.Controls.Add(this.txtBuscarNombre);
            this.groupBox2.Controls.Add(this.txtBuscarCodigo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 153);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Producto";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(481, 64);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(148, 21);
            this.cmbCategoria.TabIndex = 21;
            // 
            // optBuscarCategoria
            // 
            this.optBuscarCategoria.AutoSize = true;
            this.optBuscarCategoria.Location = new System.Drawing.Point(319, 30);
            this.optBuscarCategoria.Name = "optBuscarCategoria";
            this.optBuscarCategoria.Size = new System.Drawing.Size(131, 17);
            this.optBuscarCategoria.TabIndex = 20;
            this.optBuscarCategoria.TabStop = true;
            this.optBuscarCategoria.Text = "Buscar por Categorías";
            this.optBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // optBuscarCodigo
            // 
            this.optBuscarCodigo.AutoSize = true;
            this.optBuscarCodigo.Location = new System.Drawing.Point(166, 30);
            this.optBuscarCodigo.Name = "optBuscarCodigo";
            this.optBuscarCodigo.Size = new System.Drawing.Size(112, 17);
            this.optBuscarCodigo.TabIndex = 19;
            this.optBuscarCodigo.TabStop = true;
            this.optBuscarCodigo.Text = "Buscar por Código";
            this.optBuscarCodigo.UseVisualStyleBackColor = true;
            // 
            // optBuscarNombre
            // 
            this.optBuscarNombre.AutoSize = true;
            this.optBuscarNombre.Location = new System.Drawing.Point(14, 30);
            this.optBuscarNombre.Name = "optBuscarNombre";
            this.optBuscarNombre.Size = new System.Drawing.Size(116, 17);
            this.optBuscarNombre.TabIndex = 18;
            this.optBuscarNombre.TabStop = true;
            this.optBuscarNombre.Text = "Buscar por Nombre";
            this.optBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(500, 101);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(127, 33);
            this.btnBuscarProducto.TabIndex = 15;
            this.btnBuscarProducto.Text = "Buscar 🔎";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(89, 66);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(146, 20);
            this.txtBuscarNombre.TabIndex = 15;
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(316, 66);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtBuscarCodigo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Categorias:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Codigo: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre:";
            // 
            // frmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbModificarCategoria;
        private System.Windows.Forms.RichTextBox richDescripcionModificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioModificar;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.TextBox txtCodigoModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.RadioButton optBuscarCategoria;
        private System.Windows.Forms.RadioButton optBuscarCodigo;
        private System.Windows.Forms.RadioButton optBuscarNombre;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}