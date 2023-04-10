namespace MVC.Models
{
    public class Lista
    {
        public List<Customer> Customers = new List<Customer>();
        public List<Invoice> Invoice = new List<Invoice>();
        public List<InvoiceLine> InvoiceLine = new List<InvoiceLine>();
        public List<string> CustomerColumn = new List<string>();
        public List<string> InvoiceColumn = new List<string>();
        public List<string> ILColumn = new List<string>();

    }
}
