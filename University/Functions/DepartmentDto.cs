﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Functions
{
    [Keyless]
    public class DepartmentDto
    {
        public string Name { get; set; }
    }
}
