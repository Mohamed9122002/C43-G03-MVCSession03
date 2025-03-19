﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuisnessLogic.DataTransferObject
{
    public class AddDepartmentDTO
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly DateOfCreation { get; set; }

    }
}
