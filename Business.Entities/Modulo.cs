﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Modulo : BusinessEntity
    {
        public int IdModulo { get; set; }
        public string DescModulo { get; set; }

        public string Ejecuta { get; set; }
    }
}
