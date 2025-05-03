using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeImportadora
{
    class Lista
    {

    }
    class Datos_Cliente
    {
        List<R_Cliente> r_Clientes = new List<R_Cliente>();
        public void GuardarC(R_Cliente cliente)
        {
            r_Clientes.Add(cliente);
        }
    }
    class Datos_Venta
    {
        List<R_Venta> r_Ventas = new List<R_Venta>();
        public void GuardarV(R_Venta venta)
        {
            r_Ventas.Add(venta);
        }
    }
    class Datos_Empleado
    {
        List<R_Empleado> r_Empleados = new List<R_Empleado>();
        public void Guardar(R_Empleado empleado)
        {
            r_Empleados.Add(empleado);
        }
    }
    class Datos_Vehiculo
    {
        List<R_Vehiculo> r_Vehiculos = new List<R_Vehiculo>();
        public void GuardarVe(R_Vehiculo vehiculo)
        {
            r_Vehiculos.Add(vehiculo);
        }
    }
}
