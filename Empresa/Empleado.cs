using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Empleado jefedirecto;

        public Cargo cargo;

        public Empleado(int id, string name, string lastName, Empleado jefedirecto, Cargo cargo)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            this.jefedirecto = jefedirecto;
            this.cargo = cargo;
        }

        public Empleado()
        {

        }
    }
}
