﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Cargo
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public Cargo(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Cargo()
        {


        }
    }
}
