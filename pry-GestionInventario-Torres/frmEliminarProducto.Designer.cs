namespace pry_GestionInventario_Torres
{
    partial class frmEliminarProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richDescripcionEliminar = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockEliminar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoriaEliminar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.txtCodigoEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Producto";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(482, 61);
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
            this.optBuscarCategoria.CheckedChanged += new System.EventHandler(this.optBuscarCategoria_CheckedChanged);
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
            this.optBuscarCodigo.CheckedChanged += new System.EventHandler(this.optBuscarCodigo_CheckedChanged);
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
            this.optBuscarNombre.CheckedChanged += new System.EventHandler(this.optBuscarNombre_CheckedChanged);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(503, 100);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(127, 33);
            this.btnBuscarProducto.TabIndex = 15;
            this.btnBuscarProducto.Text = "Buscar 🔎";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(90, 63);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(146, 20);
            this.txtBuscarNombre.TabIndex = 15;
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(317, 63);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtBuscarCodigo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Categorias:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Codigo: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvProductos.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 172);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(645, 141);
            this.dgvProductos.TabIndex = 5;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.richDescripcionEliminar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStockEliminar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCategoriaEliminar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioEliminar);
            this.groupBox1.Controls.Add(this.btnEliminarProducto);
            this.groupBox1.Controls.Add(this.txtNombreEliminar);
            this.groupBox1.Controls.Add(this.txtCodigoEliminar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 187);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Producto";
            // 
            // richDescripcionEliminar
            // 
            this.richDescripcionEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richDescripcionEliminar.Location = new System.Drawing.Point(77, 106);
            this.richDescripcionEliminar.Name = "richDescripcionEliminar";
            this.richDescripcionEliminar.Size = new System.Drawing.Size(377, 67);
            this.richDescripcionEliminar.TabIndex = 24;
            this.richDescripcionEliminar.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Descripción: ";
            // 
            // txtStockEliminar
            // 
            this.txtStockEliminar.Location = new System.Drawing.Point(280, 67);
            this.txtStockEliminar.Name = "txtStockEliminar";
            this.txtStockEliminar.Size = new System.Drawing.Size(71, 20);
            this.txtStockEliminar.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stock:";
            // 
            // txtCategoriaEliminar
            // 
            this.txtCategoriaEliminar.Location = new System.Drawing.Point(75, 67);
            this.txtCategoriaEliminar.Name = "txtCategoriaEliminar";
            this.txtCategoriaEliminar.Size = new System.Drawing.Size(132, 20);
            this.txtCategoriaEliminar.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Categoria: ";
            // 
            // txtPrecioEliminar
            // 
            this.txtPrecioEliminar.Location = new System.Drawing.Point(440, 27);
            this.txtPrecioEliminar.Name = "txtPrecioEliminar";
            this.txtPrecioEliminar.Size = new System.Drawing.Size(71, 20);
            this.txtPrecioEliminar.TabIndex = 18;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(503, 140);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(127, 33);
            this.btnEliminarProducto.TabIndex = 15;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Location = new System.Drawing.Point(219, 27);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(146, 20);
            this.txtNombreEliminar.TabIndex = 15;
            // 
            // txtCodigoEliminar
            // 
            this.txtCodigoEliminar.Location = new System.Drawing.Point(63, 27);
            this.txtCodigoEliminar.Name = "txtCodigoEliminar";
            this.txtCodigoEliminar.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoEliminar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Codigo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre:";
            // 
            // frmEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEliminarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Producto";
            this.Load += new System.EventHandler(this.frmEliminarProducto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioEliminar;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.TextBox txtCodigoEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoriaEliminar;
        private System.Windows.Forms.RichTextBox richDescripcionEliminar;
    }
}