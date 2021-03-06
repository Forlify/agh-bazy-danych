﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlazejKustraHellow
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new Collection<Product>();
        }
    }
}
