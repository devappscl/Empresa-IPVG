using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa;

namespace EmpresaUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cargo cargo = new Cargo(1,"Profesor");
            Cargo cargo1 = new Cargo(2, "Supervisor");




            Empleado empleado= new Empleado();
            Empleado empleadojefe = new Empleado(1,"Jonathan","Hernández",null,cargo1);

            Console.WriteLine("Ingrese ID Empleado");
            empleado.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nombre Empleado");
            empleado.Name = Console.ReadLine();

            Console.WriteLine("Ingrese Apellido Empleado");
            empleado.LastName = Console.ReadLine();

            Console.WriteLine("Ingrese Cargo Empleado");
            empleado.cargo = cargo;

            Console.WriteLine("Ingrese Jefe Directo");
            empleado.jefedirecto = empleadojefe;

            Console.WriteLine("El empleado ingresado es {0} {1}, con ID {2} y se desepeña en el cargo {3} y su jefe directo tiene ID {4} y se llama {5} {6} con el cargo de {7}", empleado.Name,empleado.LastName,empleado.Id,empleado.cargo.Name,empleado.jefedirecto.Id,empleado.jefedirecto.Name,empleado.jefedirecto.LastName,empleado.jefedirecto.cargo.Name);






            Console.ReadKey();  

        }
    }
}
