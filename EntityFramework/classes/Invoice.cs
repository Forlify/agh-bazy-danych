using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlazejKustraHellow
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int InvoiceNumber { get; set; }
        public int Quantity { get; set; }
        public ICollection<InvoiceProduct> InvoiceProducts { get; set; }

        public Invoice()
        {
            InvoiceProducts = new Collection<InvoiceProduct>();
        }
    }
}
