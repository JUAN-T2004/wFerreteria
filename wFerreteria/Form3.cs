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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                if (txtCedCliente.Text == "")
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos2.DataSource = p1.ConsultarDato2();
                }
                else
                {
                    clsDatos p1 = new clsDatos();
                    dtgDatos2.DataSource = p1.SeleccionarDato2();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar dato" + ex.Message);
            }
        }

        private void btnIngresar2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCedCliente.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text));
                p1.IngresarDato2();
                MessageBox.Show("Dato Ingresado");
                dtgDatos2.DataSource = p1.ConsultarDato2();


            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar Dato");

            }
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database = dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos(Convert.ToInt32(txtCedCliente.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text));
                p1.ModificarDato2();
                MessageBox.Show("Dato modificados");
                dtgDatos2.DataSource = p1.ConsultarDato2();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar dato");
            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            txtCedCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";          
            txtDireccion.Text = "";
            dtgDatos2.DataSource = "";
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
                conexion.Open();

                clsDatos p1 = new clsDatos();
                p1.EliminarDato2();
                dtgDatos2.DataSource = p1.SeleccionarDato2();
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
            columna1.HeaderText = "Ced Cliente";
            columna1.Width = 220;
            columna1.ReadOnly = true;
            dtgDatos2.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Nombre";
            columna2.Width = 220;
            columna2.ReadOnly = true;
            dtgDatos2.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Apellido";
            columna3.Width = 220;
            columna3.ReadOnly = true;
            dtgDatos2.Columns.Add(columna3);

            DataGridViewTextBoxColumn colmna4 = new DataGridViewTextBoxColumn();
            colmna4.HeaderText = "Direccion";
            colmna4.Width = 220;
            colmna4.ReadOnly = true;
            dtgDatos2.Columns.Add(colmna4);

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "Telefono";
            columna5.Width = 220;
            columna5.ReadOnly = true;
            dtgDatos2.Columns.Add(columna5);
       

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

                                dtgDatos2.Rows.Add(valores.ToArray());
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
