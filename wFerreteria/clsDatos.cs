using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace wFerreteria
{
    class clsDatos
    {
        public int intCodVendedor { get; set; }

        public string strNombre { get; set; }

        public string strApellido { get; set; }

        public int intTelefono { get; set; }

        public string strCorreo { get; set; }

        public string strDireccion { get; set; }

        public int intCedCliente { get; set; } 

        public int intCodCategoria { get; set; }

        public string strNombreProducto { get; set; }

        public int intCodProveedor { get; set; }

        public string strPaginaWeb { get; set; }

        public int intCodProducto { get; set; }

        public double monPrecio { get; set; }

        public int intStock { get; set; }

        public int intCodVenta { get; set; }

        public string datFecha { get; set; }

        public int intCantidadVendida { get; set; }

        public int intTotal { get; set; }



        public clsDatos()
        {

        }


        public clsDatos(int intCodVendedor, string strNombre, string strApellido, int intTelefono, string strCorreo, string strDireccion )
        {
            this.intCodVendedor = intCodVendedor;
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.intTelefono = intTelefono;
            this.strCorreo = strCorreo;
            this.strDireccion = strDireccion;
            
        }

        public clsDatos(int intCedCliente, string strNombre, string strApellido, string strDireccion, int intTelefono)
        {
            this.intCedCliente = intCedCliente;
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.strDireccion = strDireccion;
            this.intTelefono = intTelefono;

        }

        public clsDatos(int intCodCategoria, string strNombreProducto, int intCodProveedor)
        {
            this.intCodCategoria = intCodCategoria;
            this.strNombreProducto = strNombreProducto;           
            this.intCodProveedor = intCodProveedor;
        }

        public clsDatos(int intCodProveedor, string strNombre, string strApellido, string strDireccion, int intTelefono, string strPaginaWeb)
        {
            this.intCodProveedor = intCodProveedor;
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.strDireccion = strDireccion;
            this.intTelefono = intTelefono;
            this.strPaginaWeb = strPaginaWeb;

        }

        public clsDatos(int intCodProducto, string strNombreProducto, double monPrecio, int intCodCategoria, int intCodProveedor, int intStock)
        {
            this.intCodProducto = intCodProducto;
            this.strNombreProducto = strNombreProducto;
            this.monPrecio = monPrecio;
            this.intCodCategoria = intCodCategoria;
            this.intCodProveedor = intCodProveedor;
            this.intStock = intStock;
        }

        public clsDatos(int intCodVenta, string datFecha, int intCantidadVendida, int intCodVendedor, int intCedCliente, int intCodProducto, string strNombreProducto, int intTotal)
        {
            this.intCodVenta = intCodVenta;
            this.datFecha = datFecha;
            this.intCantidadVendida = intCantidadVendida;
            this.intCodVendedor = intCodVendedor;
            this.intCedCliente = intCedCliente;
            this.intCodProducto = intCodProducto;
            this.strNombreProducto = strNombreProducto;
            this.intTotal = intTotal;
        }


        public bool IngresarDato1()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            string insertar = "insert into tblVendedor values( @intCodVendedor, @strNombre, @strApellido, @intTelefono, @strCorreo, @strDireccion)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCodVendedor", this.intCodVendedor);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@intTelefono", this.intTelefono);
            sql.Parameters.AddWithValue("@strCorreo", this.strCorreo);
            sql.Parameters.AddWithValue("@strDireccion", this.strDireccion);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool IngresarDato2()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            string insertar = "insert into tblCliente values( @intCedCliente, @strNombre, @strApellido, @strDireccion, @intTelefono)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCedCliente", this.intCedCliente);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@strDireccion", this.strDireccion);
            sql.Parameters.AddWithValue("@intTelefono", this.intTelefono);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool IngresarDato3()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            string insertar = "insert into tblCategoria values( @intCodCategoria, @strNombreProducto, @intCodProveedor)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCodCategoria", this.intCodCategoria);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@intCodProveedor", this.intCodProveedor);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool IngresarDato4()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            string insertar = "insert into tblProveedor values( @intCodProveedor, @strNombre, @strApellido, @strDireccion, @intTelefono, @strPaginaWeb)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCodProveedor", this.intCodProveedor);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@strDireccion", this.strDireccion);
            sql.Parameters.AddWithValue("@intTelefono", this.intTelefono);
            sql.Parameters.AddWithValue("@strPaginaWeb", this.strPaginaWeb);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool IngresarDato5()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            string insertar = "insert into tblProducto values( @intCodProducto, @strNombreProducto, @monPrecio, @intCodCategoria, @intCodProveedor, @intStock)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCodProducto", this.intCodProducto);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@monPrecio", this.monPrecio);
            sql.Parameters.AddWithValue("@intCodCategoria", this.intCodCategoria);
            sql.Parameters.AddWithValue("@intCodProveedor", this.intCodProveedor);
            sql.Parameters.AddWithValue(" @intStock", this.intStock);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool IngresarDato6()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            string insertar = "insert into tblFactura values( @intCodVenta, @datFecha, @intCantidadVendida, @intCodVendedor, @intCedCliente, @intCodProducto, @strNombreProducto, @intTotal)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@intCodVenta", this.intCodVenta);
            sql.Parameters.AddWithValue("@datFecha", this.datFecha);
            sql.Parameters.AddWithValue("@intCantidadVendida", this.intCantidadVendida);
            sql.Parameters.AddWithValue("@intCodVendedor", this.intCodVendedor);
            sql.Parameters.AddWithValue("@intCedCliente", this.intCedCliente);
            sql.Parameters.AddWithValue("@intCodProducto", this.intCodProducto);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@intTotal", this.intTotal);
            sql.ExecuteNonQuery();

            return true;
        }

        public DataTable ConsultarDato1()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            DataTable Date = new DataTable();         
            string consulta = "Select * from tblVendedor";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Date);

            return Date;
        }

        public DataTable ConsultarDato2()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            DataTable Date = new DataTable();
            string consulta = "select * from tblCliente";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Date);

            return Date;
        }

        public DataTable ConsultarDato3()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            DataTable Date = new DataTable();
            string consulta = "select * from tblCategoria";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Date);

            return Date;
        }

        public DataTable ConsultarDato4()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            DataTable Date = new DataTable();
            string consulta = "select * from tblProveedor";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Date);

            return Date;
        }

        public DataTable ConsultarDato5()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            DataTable Date = new DataTable();
            string consulta = "select * from tblProducto";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Date);

            return Date;
        }

        public DataTable ConsultarDato6()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            DataTable Date = new DataTable();
            string consulta = "select * from tblFactura";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Date);

            return Date;
        }

        public bool EliminarDato1()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            this.intCodVendedor = intCodVendedor;
            string eliminar = "delete tblVendedor where intCodVendedor = @intCodVendedor";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.ExecuteNonQuery();
            

            return true;
        }

        public bool EliminarDato2()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            this.intCedCliente = intCedCliente;
            string eliminar = "delete tblCliente where intCedCliente = @intCedCliente";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool EliminarDato3()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            this.intCodCategoria = intCodCategoria;
            string eliminar = "delete tblCategoria where intCodCategoria = @intCodCategoria";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool EliminarDato4()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboferreteria; integrated security= true");
            conexion.Open();

            this.intCodProveedor = intCodProveedor;
            string eliminar = "delete tblProveedor where intCodProveedor = @intCodProveedor";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool EliminarDato5()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            this.intCodProducto = intCodProducto;
            string eliminar = "delete tblProducto where intCodProducto = @intCodProducto";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool EliminarDato6()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();

            this.intCodVenta = intCodVenta;
            string eliminar = "delete tblFactura where intCodVenta = @intCodVenta";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool ModificarDato1()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();
            string modificar = "update tblVendedor set intCodVendedor = @intCodVendedor, strNombre = @strNombre, strApellido = @strApellido, strTelefono = @strTelefono, strCorreo = @strCorreo, strDireccion = @strDireccion";
            SqlCommand sql = new SqlCommand(modificar, conexion);

            sql.Parameters.AddWithValue("@intCodVendedor", this.intCodVendedor);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@intTelefono", this.intTelefono);
            sql.Parameters.AddWithValue("@strCorreo", this.strCorreo);
            sql.Parameters.AddWithValue("@strDireccion", this.strDireccion);
            sql.ExecuteNonQuery();

            return true;

        }

        public bool ModificarDato2()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();
            string modificar = "update tblCliente set intCedCliente = @intCedCliente, strNombre = @strNombre, strApellido = @strApellido,strDireccion = @strDireccion, intTelefono = @intTelefono";
            SqlCommand sql = new SqlCommand(modificar, conexion);

            sql.Parameters.AddWithValue("@intCedCliente", this.intCedCliente);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@strDireccion", this.strDireccion);
            sql.Parameters.AddWithValue("@intTelefono", this.intTelefono);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool ModificarDato3()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();
            string modificar = "update tblCategoria set intCodCategoria = @intCodCategoria,strNombreProducto = @strNombreProducto, intCodProveedor = @intCodProveedor";
            SqlCommand sql = new SqlCommand(modificar, conexion);

            sql.Parameters.AddWithValue("@intCodCategoria", this.intCodCategoria);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@intCodProveedor", this.intCodProveedor);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool ModificarDato4()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();
            string modificar = "update tblProveedor set intCodProveedor = @intCodProveedor, strNombre = @strNombre, strApellido = @strApellido, strDireccion = @strDireccion, intTelefono = @intTelefono, strPaginaWeb = @strPaginaWeb";
            SqlCommand sql = new SqlCommand(modificar, conexion);

            sql.Parameters.AddWithValue("@intCodProveedor", this.intCodProveedor);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@strDireccion", this.strDireccion);
            sql.Parameters.AddWithValue("@intTelefono", this.intTelefono);
            sql.Parameters.AddWithValue("@strPaginaWeb", this.strPaginaWeb);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool ModificarDato5()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();
            string modificar = "update tblProducto set intCodProducto = @intCodProducto, strNombreProducto = @strNombreProducto, monPrecio = @monPrecio, intCodCategoria = @intCodCategoria, intCodProveedor = @intCodProveedor, intStock = @intStock ";
            SqlCommand sql = new SqlCommand(modificar, conexion);

            sql.Parameters.AddWithValue("@intCodProducto", this.intCodProducto);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@monPrecio", this.monPrecio);
            sql.Parameters.AddWithValue("@intCodCategoria", this.intCodCategoria);
            sql.Parameters.AddWithValue("@intCodProveedor", this.intCodProveedor);
            sql.Parameters.AddWithValue(" @intStock", this.intStock);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool ModificarDato6()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();
            string modificar = "update tblFactura set intCodVenta = @intCodVenta, datFecha = @datFecha, intCantidadVendida = @intCantidadVendida, intCodVendedor = @intCodVendedor, intCedCliente = @intCedCliente, intCodProducto = @intCodProducto, strNombreProducto = @strNombreProducto, intTotal = @intTotal";
            SqlCommand sql = new SqlCommand(modificar, conexion);

            sql.Parameters.AddWithValue("@intCodVenta", this.intCodVenta);
            sql.Parameters.AddWithValue("@datFecha", this.datFecha);
            sql.Parameters.AddWithValue("@intCantidadVendida", this.intCantidadVendida);
            sql.Parameters.AddWithValue("@intCodVendedor", this.intCodVendedor);
            sql.Parameters.AddWithValue("@intCedCliente", this.intCedCliente);
            sql.Parameters.AddWithValue("@intCodProducto", this.intCodProducto);
            sql.Parameters.AddWithValue("@strNombreProducto", this.strNombreProducto);
            sql.Parameters.AddWithValue("@intTotal", this.intTotal);
            sql.ExecuteNonQuery();

            return true;
        }

        public DataTable SeleccionarDato1()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();



            this.intCodVendedor = intCodVendedor;
            DataTable date = new DataTable();
            string seleccionar = "select * from tblVendedor where intCodVendedor = @intCodVendedor";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intCodVendedor", this.intCodVendedor);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(date);



            return date;
        }

        public DataTable SeleccionarDato2()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();



            this.intCedCliente = intCedCliente;
            DataTable date = new DataTable();
            string seleccionar = "select * from tblCliente where intCedCliente = @intCedCliente";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intCedCliente", this.intCedCliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(date);



            return date;
        }

        public DataTable SeleccionarDato3()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();



            this.intCodCategoria = intCodCategoria;
            DataTable date = new DataTable();
            string seleccionar = "select * from tblCategoria where intCodCategoria = @intCodCategoria";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intCodCategoria", this.intCodCategoria);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(date);



            return date;
        }

        public DataTable SeleccionarDato4()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();



            this.intCodProveedor = intCodProveedor;
            DataTable date = new DataTable();
            string seleccionar = "select * from tblProveedor where intCodProveedor = @intCodProveedor";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intCodProveedor", this.intCodProveedor);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(date);



            return date;
        }

        public DataTable SeleccionarDato5()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();



            this.intCodProducto = intCodProducto;
            DataTable date = new DataTable();
            string seleccionar = "select * from tblProducto where intCodProducto = @intCodProducto";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intCodProducto", this.intCodProducto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(date);



            return date;
        }

        public DataTable SeleccionarDato6()
        {
            SqlConnection conexion = new SqlConnection("server = LAPTOP-V0AM8B8E; database=dboFerreteria; integrated security= true");
            conexion.Open();



            this.intCodVenta = intCodVenta;
            DataTable date = new DataTable();
            string seleccionar = "select * from tblFactura where intCodVenta = @intCodVenta";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intCodVenta", this.intCodVenta);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(date);



            return date;
        }

    }
}

  