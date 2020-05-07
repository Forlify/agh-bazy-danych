using System;
namespace BlazejKustraHellow
{
    public class InvoiceProduct
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }
    }
}
