using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Departament { get; set; }

        public List<Empleado> EmpleadoList { get; set; }

        public Departamento(int id, string departament, List<Empleado> empleadoList)
        {
            Id = id;
            Departament = departament;
            EmpleadoList = empleadoList;
        }

        public Departamento()
        {
        }
    }
}
