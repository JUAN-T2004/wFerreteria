namespace wFerreteria
{
    partial class FrmCategoria
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
            this.grpDatos3 = new System.Windows.Forms.GroupBox();
            this.lblCodProveedor = new System.Windows.Forms.Label();
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.lblCodCategoria = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.dtgDatos3 = new System.Windows.Forms.DataGridView();
            this.btnConsultar3 = new System.Windows.Forms.Button();
            this.btnIngresar3 = new System.Windows.Forms.Button();
            this.btnModificar3 = new System.Windows.Forms.Button();
            this.btnLimpiar3 = new System.Windows.Forms.Button();
            this.btnEliminar3 = new System.Windows.Forms.Button();
            this.btnCVS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpDatos3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos3)).BeginInit();
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
            // grpDatos3
            // 
            this.grpDatos3.Controls.Add(this.lblCodProveedor);
            this.grpDatos3.Controls.Add(this.txtCodProveedor);
            this.grpDatos3.Controls.Add(this.lblNombreProducto);
            this.grpDatos3.Controls.Add(this.txtCodCategoria);
            this.grpDatos3.Controls.Add(this.lblCodCategoria);
            this.grpDatos3.Controls.Add(this.txtNombreProducto);
            this.grpDatos3.Location = new System.Drawing.Point(23, 40);
            this.grpDatos3.Name = "grpDatos3";
            this.grpDatos3.Size = new System.Drawing.Size(684, 110);
            this.grpDatos3.TabIndex = 2;
            this.grpDatos3.TabStop = false;
            this.grpDatos3.Text = "Datos3";
            // 
            // lblCodProveedor
            // 
            this.lblCodProveedor.AutoSize = true;
            this.lblCodProveedor.Location = new System.Drawing.Point(472, 50);
            this.lblCodProveedor.Name = "lblCodProveedor";
            this.lblCodProveedor.Size = new System.Drawing.Size(78, 13);
            this.lblCodProveedor.TabIndex = 6;
            this.lblCodProveedor.Text = "Cod Proveedor";
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.Location = new System.Drawing.Point(567, 50);
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodProveedor.TabIndex = 7;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(239, 46);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Location = new System.Drawing.Point(107, 40);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCodCategoria.TabIndex = 8;
            // 
            // lblCodCategoria
            // 
            this.lblCodCategoria.AutoSize = true;
            this.lblCodCategoria.Location = new System.Drawing.Point(15, 46);
            this.lblCodCategoria.Name = "lblCodCategoria";
            this.lblCodCategoria.Size = new System.Drawing.Size(74, 13);
            this.lblCodCategoria.TabIndex = 4;
            this.lblCodCategoria.Text = "Cod Categoria";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(349, 43);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // dtgDatos3
            // 
            this.dtgDatos3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos3.Location = new System.Drawing.Point(23, 166);
            this.dtgDatos3.Name = "dtgDatos3";
            this.dtgDatos3.Size = new System.Drawing.Size(647, 259);
            this.dtgDatos3.TabIndex = 3;
            // 
            // btnConsultar3
            // 
            this.btnConsultar3.Location = new System.Drawing.Point(696, 201);
            this.btnConsultar3.Name = "btnConsultar3";
            this.btnConsultar3.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar3.TabIndex = 10;
            this.btnConsultar3.Text = "Consultar3";
            this.btnConsultar3.UseVisualStyleBackColor = true;
            this.btnConsultar3.Click += new System.EventHandler(this.btnConsultar3_Click);
            // 
            // btnIngresar3
            // 
            this.btnIngresar3.Location = new System.Drawing.Point(696, 248);
            this.btnIngresar3.Name = "btnIngresar3";
            this.btnIngresar3.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar3.TabIndex = 11;
            this.btnIngresar3.Text = "Ingresar3";
            this.btnIngresar3.UseVisualStyleBackColor = true;
            this.btnIngresar3.Click += new System.EventHandler(this.btnIngresar3_Click);
            // 
            // btnModificar3
            // 
            this.btnModificar3.Location = new System.Drawing.Point(696, 291);
            this.btnModificar3.Name = "btnModificar3";
            this.btnModificar3.Size = new System.Drawing.Size(75, 23);
            this.btnModificar3.TabIndex = 12;
            this.btnModificar3.Text = "Modificar3";
            this.btnModificar3.UseVisualStyleBackColor = true;
            this.btnModificar3.Click += new System.EventHandler(this.btnModificar3_Click);
            // 
            // btnLimpiar3
            // 
            this.btnLimpiar3.Location = new System.Drawing.Point(696, 332);
            this.btnLimpiar3.Name = "btnLimpiar3";
            this.btnLimpiar3.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar3.TabIndex = 13;
            this.btnLimpiar3.Text = "Limpiar3";
            this.btnLimpiar3.UseVisualStyleBackColor = true;
            this.btnLimpiar3.Click += new System.EventHandler(this.btnLimpiar3_Click);
            // 
            // btnEliminar3
            // 
            this.btnEliminar3.Location = new System.Drawing.Point(696, 381);
            this.btnEliminar3.Name = "btnEliminar3";
            this.btnEliminar3.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar3.TabIndex = 14;
            this.btnEliminar3.Text = "Eliminar3";
            this.btnEliminar3.UseVisualStyleBackColor = true;
            this.btnEliminar3.Click += new System.EventHandler(this.btnEliminar3_Click);
            // 
            // btnCVS
            // 
            this.btnCVS.Location = new System.Drawing.Point(696, 415);
            this.btnCVS.Name = "btnCVS";
            this.btnCVS.Size = new System.Drawing.Size(75, 23);
            this.btnCVS.TabIndex = 15;
            this.btnCVS.Text = "Cargar CVS";
            this.btnCVS.UseVisualStyleBackColor = true;
            this.btnCVS.Click += new System.EventHandler(this.btnCVS_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCVS);
            this.Controls.Add(this.btnConsultar3);
            this.Controls.Add(this.btnIngresar3);
            this.Controls.Add(this.btnModificar3);
            this.Controls.Add(this.btnLimpiar3);
            this.Controls.Add(this.btnEliminar3);
            this.Controls.Add(this.dtgDatos3);
            this.Controls.Add(this.grpDatos3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCategoria";
            this.Text = "Categoria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDatos3.ResumeLayout(false);
            this.grpDatos3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpDatos3;
        private System.Windows.Forms.DataGridView dtgDatos3;
        private System.Windows.Forms.Label lblCodCategoria;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCodProveedor;
        private System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnConsultar3;
        private System.Windows.Forms.Button btnIngresar3;
        private System.Windows.Forms.Button btnModificar3;
        private System.Windows.Forms.Button btnLimpiar3;
        private System.Windows.Forms.Button btnEliminar3;
        private System.Windows.Forms.Button btnCVS;
    }
}