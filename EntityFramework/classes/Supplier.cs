using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlazejKustraHellow
{
    public class Supplier : Company
    {
        public int BankAccountNumber { get; set; }
        public ICollection<Product> Products { get; set; }

        public Supplier()
        {
            Products = new Collection<Product>();
        }
    }
}
