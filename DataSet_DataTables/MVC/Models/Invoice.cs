using System.Data;

namespace MVC.Models
{
    public class Invoice
    {
        public List<string> colum { get; set; }
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public int Total { get; set; }
    }
}