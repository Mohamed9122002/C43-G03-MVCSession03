﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Models
{
    public class BaseEntity
    {
        public int Id { get; set; } // PK
        public int CreatedBy { get; set; } // yser Id
        public DateTime? CreatedOn { get; set; }
        public int LastModifiedBy { get; set; } // user Id 
        public DateTime? LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; } // soft Delete 

    }
}
