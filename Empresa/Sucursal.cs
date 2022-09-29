using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public List<Departamento> departamentos;

        public Sucursal(int id, string name, List<Departamento> departamentos)
        {
            Id = id;
            Name = name;
            this.departamentos = departamentos;
        }

        public Sucursal()
        {


        }
    }
}
