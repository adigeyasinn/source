﻿using AdigeFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.Northwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public virtual int CategoryID { get; set; }
        public virtual string CategoryName { get; set; }
    }
}
