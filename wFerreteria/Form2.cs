using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


//Summary
//Autores: Juan Manuel Torres, Jose Veneco Uribe, Oscar David Ramos, Santiago Lozano
//Descripcion: Proyecto Final
//Fecha: 02/06/2022

namespace wFerreteria
{
    public partial class FrmVendedor :  Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void btnConsultar1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                if (txtCodVendedor.Text == "")
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos1.DataSource = p1.ConsultarDato1();
                }
                else
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos1.DataSource = p1.SeleccionarDato1();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar dato" + ex.Message);
            }
        }

        private void btnIngresar1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCodVendedor.Text), txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtTelefono.Text), txtCorreo.Text, txtDireccion.Text);
                p1.IngresarDato1();
                MessageBox.Show("Dato ingresado");
                dtgDatos1.DataSource = p1.ConsultarDato1();

            }


            catch (Exception)
            {
                MessageBox.Show("Error al ingresar dato");
            }
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexio = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexio.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCodVendedor.Text), txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtTelefono.Text), txtCorreo.Text, txtDireccion.Text);
                p1.ModificarDato1();
                MessageBox.Show("Dato modificados");
                dtgDatos1.DataSource = p1.ConsultarDato1();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar dato");
            }

        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            txtCodVendedor.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            dtgDatos1.DataSource = "";
            
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos();
                p1.EliminarDato1();
                dtgDatos1.DataSource = p1.SeleccionarDato1();
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
            columna1.HeaderText = "Cod Vendedor";
            columna1.Width = 220;
            columna1.ReadOnly = true;
            dtgDatos1.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Nombre";
            columna2.Width = 220;
            columna2.ReadOnly = true;
            dtgDatos1.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Apellido";
            columna3.Width = 220;
            columna3.ReadOnly = true;
            dtgDatos1.Columns.Add(columna3);

            DataGridViewTextBoxColumn colmna4 = new DataGridViewTextBoxColumn();
            colmna4.HeaderText = "Telefono";
            colmna4.Width = 220;
            colmna4.ReadOnly = true;
            dtgDatos1.Columns.Add(colmna4);

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "Correo";
            columna5.Width = 220;
            columna5.ReadOnly = true;
            dtgDatos1.Columns.Add(columna5);

            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "Direccion";
            columna6.Width = 220;
            columna6.ReadOnly = true;
            dtgDatos1.Columns.Add(columna6);

            
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

                                dtgDatos1.Rows.Add(valores.ToArray());
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
