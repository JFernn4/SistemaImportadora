using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeImportadora
{
    class Clases
    {

    }
    class R_Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
    class R_Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
        public double Salario { get; set; }
    }
    class R_Vehiculo
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public string Color { get; set; }
        public DateTime DateTime { get; set; }
        public string Matricula { get; set; }
    }
    class R_Venta
    {
        public int ID { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Vehiculo { get; set; }
        public int ID_Empleado { get; set; }
        public DateTime Datetime { get; set; }
        public string Metodo_Pago { get; set; }
        public double Monto { get; set; }
        public double Pago { get; set; }
        public double Pendiente { get; set; }
    }
}
