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
    public class Datos_Cliente
    {
        List<R_Cliente> r_Clientes = new List<R_Cliente>();
        public void GuardarC(R_Cliente cliente)
        {
            r_Clientes.Add(cliente);
        }
        public List<R_Cliente> ConsultarC()
        {
            return r_Clientes;
        }
        public void EliminarC(string cliente)
        {
            var elementoC = r_Clientes.FirstOrDefault(d => d.Nombre == cliente);
            if (elementoC != null)
            {
                r_Clientes.Remove(elementoC);
            }
        }
    }
    public class Datos_Venta
    {
        List<R_Venta> r_Ventas = new List<R_Venta>();
        public void GuardarV(R_Venta venta)
        {
            r_Ventas.Add(venta);
        }
        public List<R_Venta> ConsultarV()
        {
            return r_Ventas;
        }
        public void EliminarV(int venta)
        {
            var elementoV = r_Ventas.FirstOrDefault(d => d.ID == venta);
            if (elementoV != null)
            {
                r_Ventas.Remove(elementoV);
            }
        }
    }
    public class Datos_Empleado
    {
        List<R_Empleado> r_Empleados = new List<R_Empleado>();
        public void Guardar(R_Empleado empleado)
        {
            r_Empleados.Add(empleado);
        }
        public List<R_Empleado> ConsultarE()
        {
            return r_Empleados;
        }
        public void EliminarE(string empleado)
        {
            var elementoE = r_Empleados.FirstOrDefault(d => d.Nombre == empleado);
            if (elementoE != null)
            {
                r_Empleados.Remove(elementoE);
            }
        }
    }
    public class Datos_Vehiculo
    {
        List<R_Vehiculo> r_Vehiculos = new List<R_Vehiculo>();
        public void GuardarVe(R_Vehiculo vehiculo)
        {
            r_Vehiculos.Add(vehiculo);
        }
        public List<R_Vehiculo> ConsultarVe()
        {
            return r_Vehiculos;
        }
        public void EliminarVe(string vehiculo)
        {
            var elementoVe = r_Vehiculos.FirstOrDefault(d => d.Marca == vehiculo);
            if (elementoVe != null)
            {
                r_Vehiculos.Remove(elementoVe);
            }
        }
    }
}
