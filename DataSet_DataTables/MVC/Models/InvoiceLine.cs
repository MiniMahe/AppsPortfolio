using System.Data;

namespace MVC.Models
{
    public class InvoiceLine
    { 
        public List<string> colum { get; set; }
        public int InvoiceLineId { get; set; }
        public int InvoiceId { get; set; }
        public int TrackId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}