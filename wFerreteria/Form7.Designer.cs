namespace wFerreteria
{
    partial class FrmFactura
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
            this.grpDatos6 = new System.Windows.Forms.GroupBox();
            this.lblCantidadVendida = new System.Windows.Forms.Label();
            this.lblCodVendedor = new System.Windows.Forms.Label();
            this.lblCodVenta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCedCliente = new System.Windows.Forms.Label();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCodVenta = new System.Windows.Forms.TextBox();
            this.txtCedCliente = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCantidadVendida = new System.Windows.Forms.TextBox();
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtgDatos6 = new System.Windows.Forms.DataGridView();
            this.btnConsultar6 = new System.Windows.Forms.Button();
            this.btnIngresar6 = new System.Windows.Forms.Button();
            this.btnModificar6 = new System.Windows.Forms.Button();
            this.btnLimpiar6 = new System.Windows.Forms.Button();
            this.btnEliminar6 = new System.Windows.Forms.Button();
            this.btnCVS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpDatos6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos6)).BeginInit();
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
            // grpDatos6
            // 
            this.grpDatos6.Controls.Add(this.lblCantidadVendida);
            this.grpDatos6.Controls.Add(this.lblCodVendedor);
            this.grpDatos6.Controls.Add(this.lblCodVenta);
            this.grpDatos6.Controls.Add(this.lblFecha);
            this.grpDatos6.Controls.Add(this.lblCedCliente);
            this.grpDatos6.Controls.Add(this.lblCodProducto);
            this.grpDatos6.Controls.Add(this.lblNombreProducto);
            this.grpDatos6.Controls.Add(this.lblTotal);
            this.grpDatos6.Controls.Add(this.txtCodVenta);
            this.grpDatos6.Controls.Add(this.txtCedCliente);
            this.grpDatos6.Controls.Add(this.txtCodProducto);
            this.grpDatos6.Controls.Add(this.txtFecha);
            this.grpDatos6.Controls.Add(this.txtCantidadVendida);
            this.grpDatos6.Controls.Add(this.txtCodVendedor);
            this.grpDatos6.Controls.Add(this.txtNombreProducto);
            this.grpDatos6.Controls.Add(this.txtTotal);
            this.grpDatos6.Location = new System.Drawing.Point(12, 27);
            this.grpDatos6.Name = "grpDatos6";
            this.grpDatos6.Size = new System.Drawing.Size(776, 156);
            this.grpDatos6.TabIndex = 1;
            this.grpDatos6.TabStop = false;
            this.grpDatos6.Text = "Datos6";
            // 
            // lblCantidadVendida
            // 
            this.lblCantidadVendida.AutoSize = true;
            this.lblCantidadVendida.Location = new System.Drawing.Point(0, 130);
            this.lblCantidadVendida.Name = "lblCantidadVendida";
            this.lblCantidadVendida.Size = new System.Drawing.Size(91, 13);
            this.lblCantidadVendida.TabIndex = 5;
            this.lblCantidadVendida.Text = "Cantidad Vendida";
            // 
            // lblCodVendedor
            // 
            this.lblCodVendedor.AutoSize = true;
            this.lblCodVendedor.Location = new System.Drawing.Point(230, 47);
            this.lblCodVendedor.Name = "lblCodVendedor";
            this.lblCodVendedor.Size = new System.Drawing.Size(75, 13);
            this.lblCodVendedor.TabIndex = 6;
            this.lblCodVendedor.Text = "Cod Vendedor";
            // 
            // lblCodVenta
            // 
            this.lblCodVenta.AutoSize = true;
            this.lblCodVenta.Location = new System.Drawing.Point(19, 40);
            this.lblCodVenta.Name = "lblCodVenta";
            this.lblCodVenta.Size = new System.Drawing.Size(57, 13);
            this.lblCodVenta.TabIndex = 3;
            this.lblCodVenta.Text = "Cod Venta";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(19, 88);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCedCliente
            // 
            this.lblCedCliente.AutoSize = true;
            this.lblCedCliente.Location = new System.Drawing.Point(228, 88);
            this.lblCedCliente.Name = "lblCedCliente";
            this.lblCedCliente.Size = new System.Drawing.Size(61, 13);
            this.lblCedCliente.TabIndex = 7;
            this.lblCedCliente.Text = "Ced Cliente";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(228, 133);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(72, 13);
            this.lblCodProducto.TabIndex = 8;
            this.lblCodProducto.Text = "Cod Producto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(485, 56);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 9;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(516, 118);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // txtCodVenta
            // 
            this.txtCodVenta.Location = new System.Drawing.Point(89, 40);
            this.txtCodVenta.Name = "txtCodVenta";
            this.txtCodVenta.Size = new System.Drawing.Size(100, 20);
            this.txtCodVenta.TabIndex = 11;
            // 
            // txtCedCliente
            // 
            this.txtCedCliente.Location = new System.Drawing.Point(320, 85);
            this.txtCedCliente.Name = "txtCedCliente";
            this.txtCedCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCedCliente.TabIndex = 12;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(320, 130);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProducto.TabIndex = 13;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(89, 81);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 14;
            // 
            // txtCantidadVendida
            // 
            this.txtCantidadVendida.Location = new System.Drawing.Point(97, 127);
            this.txtCantidadVendida.Name = "txtCantidadVendida";
            this.txtCantidadVendida.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVendida.TabIndex = 15;
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.Location = new System.Drawing.Point(320, 46);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodVendedor.TabIndex = 16;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(615, 53);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(615, 115);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // dtgDatos6
            // 
            this.dtgDatos6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos6.Location = new System.Drawing.Point(12, 196);
            this.dtgDatos6.Name = "dtgDatos6";
            this.dtgDatos6.Size = new System.Drawing.Size(680, 242);
            this.dtgDatos6.TabIndex = 2;
            // 
            // btnConsultar6
            // 
            this.btnConsultar6.Location = new System.Drawing.Point(713, 217);
            this.btnConsultar6.Name = "btnConsultar6";
            this.btnConsultar6.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar6.TabIndex = 3;
            this.btnConsultar6.Text = "Consultar6";
            this.btnConsultar6.UseVisualStyleBackColor = true;
            this.btnConsultar6.Click += new System.EventHandler(this.btnConsultar6_Click);
            // 
            // btnIngresar6
            // 
            this.btnIngresar6.Location = new System.Drawing.Point(713, 257);
            this.btnIngresar6.Name = "btnIngresar6";
            this.btnIngresar6.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar6.TabIndex = 4;
            this.btnIngresar6.Text = "Ingresar6";
            this.btnIngresar6.UseVisualStyleBackColor = true;
            this.btnIngresar6.Click += new System.EventHandler(this.btnIngresar6_Click);
            // 
            // btnModificar6
            // 
            this.btnModificar6.Location = new System.Drawing.Point(713, 297);
            this.btnModificar6.Name = "btnModificar6";
            this.btnModificar6.Size = new System.Drawing.Size(75, 23);
            this.btnModificar6.TabIndex = 5;
            this.btnModificar6.Text = "Modificar6";
            this.btnModificar6.UseVisualStyleBackColor = true;
            this.btnModificar6.Click += new System.EventHandler(this.btnModificar6_Click);
            // 
            // btnLimpiar6
            // 
            this.btnLimpiar6.Location = new System.Drawing.Point(713, 339);
            this.btnLimpiar6.Name = "btnLimpiar6";
            this.btnLimpiar6.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar6.TabIndex = 6;
            this.btnLimpiar6.Text = "Limpiar6";
            this.btnLimpiar6.UseVisualStyleBackColor = true;
            this.btnLimpiar6.Click += new System.EventHandler(this.btnLimpiar6_Click);
            // 
            // btnEliminar6
            // 
            this.btnEliminar6.Location = new System.Drawing.Point(713, 384);
            this.btnEliminar6.Name = "btnEliminar6";
            this.btnEliminar6.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar6.TabIndex = 7;
            this.btnEliminar6.Text = "Eliminar6";
            this.btnEliminar6.UseVisualStyleBackColor = true;
            this.btnEliminar6.Click += new System.EventHandler(this.btnEliminar6_Click);
            // 
            // btnCVS
            // 
            this.btnCVS.Location = new System.Drawing.Point(713, 424);
            this.btnCVS.Name = "btnCVS";
            this.btnCVS.Size = new System.Drawing.Size(75, 23);
            this.btnCVS.TabIndex = 11;
            this.btnCVS.Text = "Cargar CVS";
            this.btnCVS.UseVisualStyleBackColor = true;
            this.btnCVS.Click += new System.EventHandler(this.btnCVS_Click);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCVS);
            this.Controls.Add(this.btnEliminar6);
            this.Controls.Add(this.btnLimpiar6);
            this.Controls.Add(this.btnModificar6);
            this.Controls.Add(this.btnIngresar6);
            this.Controls.Add(this.btnConsultar6);
            this.Controls.Add(this.dtgDatos6);
            this.Controls.Add(this.grpDatos6);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmFactura";
            this.Text = "Factura";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDatos6.ResumeLayout(false);
            this.grpDatos6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDatos6;
        private System.Windows.Forms.DataGridView dtgDatos6;
        private System.Windows.Forms.Label lblCantidadVendida;
        private System.Windows.Forms.Label lblCodVendedor;
        private System.Windows.Forms.Label lblCodVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCedCliente;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCodVenta;
        private System.Windows.Forms.TextBox txtCedCliente;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCantidadVendida;
        private System.Windows.Forms.TextBox txtCodVendedor;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnConsultar6;
        private System.Windows.Forms.Button btnIngresar6;
        private System.Windows.Forms.Button btnModificar6;
        private System.Windows.Forms.Button btnLimpiar6;
        private System.Windows.Forms.Button btnEliminar6;
        private System.Windows.Forms.Button btnCVS;
    }
}