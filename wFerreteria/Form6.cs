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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnConsultar5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                if (txtCodProducto.Text == "")
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos5.DataSource = p1.ConsultarDato5();
                }
                else
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos5.DataSource = p1.SeleccionarDato5();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar dato" + ex.Message);
            }
        }

        private void btnIngresar5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCodProducto.Text), txtNombreProducto.Text, txtPrecio.Text, Convert.ToInt32(txtCodCategoria.Text), txtCodProveedor.Text, txtStock.Text);
                p1.IngresarDato5();
                MessageBox.Show("Dato Ingresado");
                dtgDatos5.DataSource = p1.ConsultarDato5();


            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar Dato");

            }
        }

        private void btnModificar5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database = dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCodProducto.Text), txtNombreProducto.Text, txtPrecio.Text, Convert.ToInt32(txtCodCategoria.Text), txtCodProveedor.Text, txtStock.Text);
                p1.ModificarDato5();
                MessageBox.Show("Dato modificados");
                dtgDatos5.DataSource = p1.ConsultarDato5();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar dato");
            }
        }

        private void btnLimpiar5_Click(object sender, EventArgs e)
        {
            txtCodProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecio.Text = "";
            txtCodCategoria.Text = "";
            txtCodProveedor.Text = "";
            txtStock.Text = "";
            dtgDatos5.DataSource = "";
        }

        private void btnEliminar5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos();
                p1.EliminarDato5();
                dtgDatos5.DataSource = p1.SeleccionarDato5();
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
            columna1.HeaderText = "Cod Producto";
            columna1.Width = 220;
            columna1.ReadOnly = true;
            dtgDatos5.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Nombre Producto";
            columna2.Width = 220;
            columna2.ReadOnly = true;
            dtgDatos5.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Precio";
            columna3.Width = 220;
            columna3.ReadOnly = true;
            dtgDatos5.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "Cod Categoria";
            columna4.Width = 220;
            columna4.ReadOnly = true;
            dtgDatos5.Columns.Add(columna4);

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "Cod Proveedor";
            columna5.Width = 220;
            columna5.ReadOnly = true;
            dtgDatos5.Columns.Add(columna5);

            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "Stock";
            columna6.Width = 220;
            columna6.ReadOnly = true;
            dtgDatos5.Columns.Add(columna6);


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

                                dtgDatos5.Rows.Add(valores.ToArray());
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
