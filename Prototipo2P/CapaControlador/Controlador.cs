using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Collections;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public DataTable llenarTblClientess(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblClientes(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public DataTable llenarTblFacturaa(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblFactura(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool ingreso(string idCliente, string nombre, string apellido, string telefono)
        {
            return sn.ingreso(idCliente, nombre, apellido,telefono);
        }


        public bool ingresoFac(string idFactura, string idCliente, string nombre_facturacion, string fecha, string descripcion, string monto)
        {
            return sn.ingresoFac(idFactura, idCliente, nombre_facturacion, fecha, descripcion, monto);
        }


    }
}
