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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnConsultar3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                if (txtCodCategoria.Text == "")
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos3.DataSource = p1.ConsultarDato3();
                }
                else
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos3.DataSource = p1.SeleccionarDato3();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar dato" + ex.Message);
            }
        }

        private void btnIngresar3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCodCategoria.Text), txtNombreProducto.Text, Convert.ToInt32(txtCodProveedor.Text));
                p1.IngresarDato3();
                MessageBox.Show("Dato Ingresado");
                dtgDatos3.DataSource = p1.ConsultarDato3();


            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar Dato");

            }
        }

        private void btnModificar3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database = dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCodCategoria.Text), txtNombreProducto.Text, Convert.ToInt32(txtCodProveedor.Text));
                p1.ModificarDato3();
                MessageBox.Show("Dato modificados");
                dtgDatos3.DataSource = p1.ConsultarDato3();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar dato");
            }
        }

        private void btnLimpiar3_Click(object sender, EventArgs e)
        {
            txtCodCategoria.Text = "";
            txtNombreProducto.Text = "";
            txtCodProveedor.Text = "";
            dtgDatos3.DataSource = "";
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos();
                p1.EliminarDato3();
                dtgDatos3.DataSource = p1.SeleccionarDato3();
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
            columna1.HeaderText = "Cod Categoria";
            columna1.Width = 220;
            columna1.ReadOnly = true;
            dtgDatos3.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Nombre Producto";
            columna2.Width = 220;
            columna2.ReadOnly = true;
            dtgDatos3.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Cod Proveedor";
            columna3.Width = 220;
            columna3.ReadOnly = true;
            dtgDatos3.Columns.Add(columna3);


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

                                dtgDatos3.Rows.Add(valores.ToArray());
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
