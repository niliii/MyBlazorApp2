﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorApp2.Shared
{
    public class Product
    {
        public int  Id { get; set; }
        public string Titel { get; set; }=string.Empty; 
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; }
        public  decimal Price{ get; set; }

    }
}
