using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data.Odbc;
using System.Collections;
using System.IO;

namespace CapaModelo
{
    public class Sentencias
    {

        Conexion con = new Conexion();
       

        // obtener datos de una tabla CAPA MODELO

        public OdbcDataAdapter llenarTblClientes(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call consultaGenClientes();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }



        public OdbcDataAdapter llenarTblFactura(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "call consultaGenFactura();";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }


        public bool ingreso(string idCliente, string nombre, string apellido, string telefono) //Ingreso Clientes
        {
            int i = 0;
            try
            {
                string cadena = "call ingClientes('" + idCliente + "','" + nombre + "','" + apellido + "','" + telefono + "'); ";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ingresoFac(string idFactura, string idCliente, string nombre_facturacion, string fecha, string descripcion, string monto) //Ingreso Facturas
        {
            int i = 0;
            try
            {
                string cadena = "call ingFacturas('" + idFactura + "','" + idCliente + "','" + nombre_facturacion + "','" + fecha + "','" + descripcion + "','" + monto + "'); ";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
