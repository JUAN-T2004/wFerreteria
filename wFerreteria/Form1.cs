using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Summary
//Autores: Juan Manuel Torres, Jose Julian Berrio, Oscar David Ramos, Santiago Lozano
//Descripcion: Proyecto Final
//Fecha: 02/06/2022

namespace wFerreteria
{
    public partial class FrmFerreteria : Form
    {
        public FrmFerreteria()
        {
            InitializeComponent();
        }
        

        private void nuevoVendedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmVendedor vendedor = new FrmVendedor();
            vendedor.MdiParent = this;
            vendedor.Show();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void nuevoCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria Categoria = new FrmCategoria();
            Categoria.MdiParent = this;
            Categoria.Show();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor Proveedor = new FrmProveedor();
            Proveedor.MdiParent = this;
            Proveedor.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto Producto = new FrmProducto();
            Producto.MdiParent = this;
            Producto.Show();
        }

        private void nuevoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactura Factura = new FrmFactura();
            Factura.MdiParent = this;
            Factura.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
