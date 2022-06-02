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
using System.Data.SqlClient;

//Summary
//Autores: Juan Manuel Torres, Jose Julian Berrio, Oscar David Ramos, Santiago Lozano
//Descripcion: Proyecto Final
//Fecha: 02/06/2022

namespace wFerreteria
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void btnConsultar6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                if (txtCodVenta.Text == "")
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos6.DataSource = p1.ConsultarDato6();
                }
                else
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos6.DataSource = p1.SeleccionarDato6();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar dato" + ex.Message);
            }
        }

        private void btnIngresar6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCodVenta.Text), txtFecha.Text, Convert.ToInt32(txtCantidadVendida.Text), Convert.ToInt32(txtCodVendedor.Text), Convert.ToInt32(txtCedCliente.Text), Convert.ToInt32(txtCodProducto.Text), txtNombreProducto.Text, Convert.ToInt32(txtTotal.Text)) ; 
                p1.IngresarDato6();
                MessageBox.Show("Dato Ingresado");
                dtgDatos6.DataSource = p1.ConsultarDato6();


            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar Dato");

            }
        }

        private void btnModificar6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database = dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCodVenta.Text), txtFecha.Text, Convert.ToInt32(txtCantidadVendida.Text), Convert.ToInt32(txtCodVendedor.Text), Convert.ToInt32(txtCedCliente.Text), Convert.ToInt32(txtCodProducto.Text), txtNombreProducto.Text, Convert.ToInt32(txtTotal.Text));
                p1.ModificarDato6();
                MessageBox.Show("Dato modificados");
                dtgDatos6.DataSource = p1.ConsultarDato6();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar dato");
            }
        }

        private void btnLimpiar6_Click(object sender, EventArgs e)
        {
            txtCodVenta.Text = "";
            txtFecha.Text = "";
            txtCantidadVendida.Text = "";
            txtCodVendedor.Text = "";
            txtCedCliente.Text = "";
            txtCodProducto.Text = "";
            txtNombreProducto.Text = "";
            txtTotal.Text = "";
            dtgDatos6.DataSource = "";
        }

        private void btnEliminar6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos();
                p1.EliminarDato6();
                dtgDatos6.DataSource = p1.SeleccionarDato6();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el registro");
            }
        }
        private Stream stream;
        int contador = 0;
        String Linea;
        private void btnCVS_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "Cod Venta";
            columna1.Width = 220;
            columna1.ReadOnly = true;
            dtgDatos6.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Fecha";
            columna2.Width = 220;
            columna2.ReadOnly = true;
            dtgDatos6.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Cantidad Vendida";
            columna3.Width = 220;
            columna3.ReadOnly = true;
            dtgDatos6.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "Cod Vendedor";
            columna4.Width = 220;
            columna4.ReadOnly = true;
            dtgDatos6.Columns.Add(columna4);

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "Ced Cliente";
            columna5.Width = 220;
            columna5.ReadOnly = true;
            dtgDatos6.Columns.Add(columna5);

            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "Cod Producto";
            columna6.Width = 220;
            columna6.ReadOnly = true;
            dtgDatos6.Columns.Add(columna6);

            DataGridViewTextBoxColumn columna7 = new DataGridViewTextBoxColumn();
            columna7.HeaderText = "Nombre Producto";
            columna7.Width = 220;
            columna7.ReadOnly = true;
            dtgDatos6.Columns.Add(columna7);

            DataGridViewTextBoxColumn columna8 = new DataGridViewTextBoxColumn();
            columna8.HeaderText = "Total";
            columna8.Width = 220;
            columna8.ReadOnly = true;
            dtgDatos6.Columns.Add(columna8);

            char delimitador = ';';
            string[] valores;


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.CSV) | *.CSV";

            if ((openFileDialog.ShowDialog()) == DialogResult.OK)
                try
                {
                    if ((stream = openFileDialog.OpenFile()) != null)
                    {
                        System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);

                        while ((Linea = file.ReadLine()) != null)
                        {
                            if (contador >= 1)
                            {
                                valores = Linea.Split(delimitador);

                                dtgDatos6.Rows.Add(valores.ToArray());
                                contador++;
                            }
                            else
                            {
                                contador++;
                            }
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
