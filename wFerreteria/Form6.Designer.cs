namespace wFerreteria
{
    partial class FrmProducto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpDatos5 = new System.Windows.Forms.GroupBox();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCodProveedor = new System.Windows.Forms.Label();
            this.lblCodCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.dtgDatos5 = new System.Windows.Forms.DataGridView();
            this.btnConsultar5 = new System.Windows.Forms.Button();
            this.btnIngresar5 = new System.Windows.Forms.Button();
            this.btnModificar5 = new System.Windows.Forms.Button();
            this.btnLimpiar5 = new System.Windows.Forms.Button();
            this.btnEliminar5 = new System.Windows.Forms.Button();
            this.btnCVS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpDatos5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            this.archivoToolStripMenuItem.Visible = false;
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarToolStripMenuItem.MergeIndex = 1;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 426);
            this.textBox1.TabIndex = 1;
            // 
            // grpDatos5
            // 
            this.grpDatos5.Controls.Add(this.txtCodCategoria);
            this.grpDatos5.Controls.Add(this.txtCodProducto);
            this.grpDatos5.Controls.Add(this.txtPrecio);
            this.grpDatos5.Controls.Add(this.txtStock);
            this.grpDatos5.Controls.Add(this.txtCodProveedor);
            this.grpDatos5.Controls.Add(this.txtNombreProducto);
            this.grpDatos5.Controls.Add(this.lblStock);
            this.grpDatos5.Controls.Add(this.lblCodProveedor);
            this.grpDatos5.Controls.Add(this.lblCodCategoria);
            this.grpDatos5.Controls.Add(this.lblPrecio);
            this.grpDatos5.Controls.Add(this.lblNombreProducto);
            this.grpDatos5.Controls.Add(this.lblCodProducto);
            this.grpDatos5.Location = new System.Drawing.Point(12, 37);
            this.grpDatos5.Name = "grpDatos5";
            this.grpDatos5.Size = new System.Drawing.Size(741, 135);
            this.grpDatos5.TabIndex = 2;
            this.grpDatos5.TabStop = false;
            this.grpDatos5.Text = "Datos5";
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Location = new System.Drawing.Point(339, 96);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCodCategoria.TabIndex = 11;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(99, 38);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProducto.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(339, 34);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(578, 96);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 8;
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.Location = new System.Drawing.Point(578, 38);
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodProveedor.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(99, 91);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(496, 99);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // lblCodProveedor
            // 
            this.lblCodProveedor.AutoSize = true;
            this.lblCodProveedor.Location = new System.Drawing.Point(483, 45);
            this.lblCodProveedor.Name = "lblCodProveedor";
            this.lblCodProveedor.Size = new System.Drawing.Size(78, 13);
            this.lblCodProveedor.TabIndex = 4;
            this.lblCodProveedor.Text = "Cod Proveedor";
            // 
            // lblCodCategoria
            // 
            this.lblCodCategoria.AutoSize = true;
            this.lblCodCategoria.Location = new System.Drawing.Point(248, 99);
            this.lblCodCategoria.Name = "lblCodCategoria";
            this.lblCodCategoria.Size = new System.Drawing.Size(71, 13);
            this.lblCodCategoria.TabIndex = 3;
            this.lblCodCategoria.Text = "CodCategoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(269, 38);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(6, 99);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(6, 45);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(72, 13);
            this.lblCodProducto.TabIndex = 0;
            this.lblCodProducto.Text = "Cod Producto";
            // 
            // dtgDatos5
            // 
            this.dtgDatos5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos5.Location = new System.Drawing.Point(12, 190);
            this.dtgDatos5.Name = "dtgDatos5";
            this.dtgDatos5.Size = new System.Drawing.Size(658, 230);
            this.dtgDatos5.TabIndex = 3;
            // 
            // btnConsultar5
            // 
            this.btnConsultar5.Location = new System.Drawing.Point(696, 215);
            this.btnConsultar5.Name = "btnConsultar5";
            this.btnConsultar5.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar5.TabIndex = 4;
            this.btnConsultar5.Text = "Consultar5";
            this.btnConsultar5.UseVisualStyleBackColor = true;
            this.btnConsultar5.Click += new System.EventHandler(this.btnConsultar5_Click);
            // 
            // btnIngresar5
            // 
            this.btnIngresar5.Location = new System.Drawing.Point(696, 254);
            this.btnIngresar5.Name = "btnIngresar5";
            this.btnIngresar5.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar5.TabIndex = 5;
            this.btnIngresar5.Text = "Ingresar5";
            this.btnIngresar5.UseVisualStyleBackColor = true;
            this.btnIngresar5.Click += new System.EventHandler(this.btnIngresar5_Click);
            // 
            // btnModificar5
            // 
            this.btnModificar5.Location = new System.Drawing.Point(696, 295);
            this.btnModificar5.Name = "btnModificar5";
            this.btnModificar5.Size = new System.Drawing.Size(75, 23);
            this.btnModificar5.TabIndex = 6;
            this.btnModificar5.Text = "Modificar5";
            this.btnModificar5.UseVisualStyleBackColor = true;
            this.btnModificar5.Click += new System.EventHandler(this.btnModificar5_Click);
            // 
            // btnLimpiar5
            // 
            this.btnLimpiar5.Location = new System.Drawing.Point(696, 334);
            this.btnLimpiar5.Name = "btnLimpiar5";
            this.btnLimpiar5.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar5.TabIndex = 7;
            this.btnLimpiar5.Text = "Limpiar5";
            this.btnLimpiar5.UseVisualStyleBackColor = true;
            this.btnLimpiar5.Click += new System.EventHandler(this.btnLimpiar5_Click);
            // 
            // btnEliminar5
            // 
            this.btnEliminar5.Location = new System.Drawing.Point(696, 373);
            this.btnEliminar5.Name = "btnEliminar5";
            this.btnEliminar5.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar5.TabIndex = 8;
            this.btnEliminar5.Text = "Eliminar5";
            this.btnEliminar5.UseVisualStyleBackColor = true;
            this.btnEliminar5.Click += new System.EventHandler(this.btnEliminar5_Click);
            // 
            // btnCVS
            // 
            this.btnCVS.Location = new System.Drawing.Point(696, 415);
            this.btnCVS.Name = "btnCVS";
            this.btnCVS.Size = new System.Drawing.Size(75, 23);
            this.btnCVS.TabIndex = 11;
            this.btnCVS.Text = "Cargar CVS";
            this.btnCVS.UseVisualStyleBackColor = true;
            this.btnCVS.Click += new System.EventHandler(this.btnCVS_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCVS);
            this.Controls.Add(this.btnEliminar5);
            this.Controls.Add(this.btnLimpiar5);
            this.Controls.Add(this.btnModificar5);
            this.Controls.Add(this.btnIngresar5);
            this.Controls.Add(this.btnConsultar5);
            this.Controls.Add(this.dtgDatos5);
            this.Controls.Add(this.grpDatos5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmProducto";
            this.Text = "Producto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDatos5.ResumeLayout(false);
            this.grpDatos5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpDatos5;
        private System.Windows.Forms.DataGridView dtgDatos5;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCodProveedor;
        private System.Windows.Forms.Label lblCodCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnConsultar5;
        private System.Windows.Forms.Button btnIngresar5;
        private System.Windows.Forms.Button btnModificar5;
        private System.Windows.Forms.Button btnLimpiar5;
        private System.Windows.Forms.Button btnEliminar5;
        private System.Windows.Forms.Button btnCVS;
    }
}