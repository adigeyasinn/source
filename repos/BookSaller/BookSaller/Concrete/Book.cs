﻿using BookSaller.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Concrete
{
    public class Book:IEntity //Book bir tablo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public override string ToString()
        {
            return $"{Id,-5}" +
                $"{Title,-35}" +
                $"{UnitPrice,-5}";
        }
    }
}
