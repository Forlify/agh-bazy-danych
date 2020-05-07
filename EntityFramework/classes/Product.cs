using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazejKustraHellow
{
    public class Product
    {
        public ICollection<InvoiceProduct> InvoiceProducts { get; set; }

        public Supplier Supplier { get; set; }
        public Category Category { get; set; }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }

        public Product()
        {
            InvoiceProducts = new Collection<InvoiceProduct>();
        }
    }
}
