using CN;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Data;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Negocio custom = new Negocio();
            DataSet data = new DataSet();
            Lista lista = new Lista();
            Customer customer = new Customer();
            data = custom.MostrarCust();
            DataTable tabla = data.Tables["Customer"];

            var query = from DataRow row in tabla.Rows
                        select new Customer
                        {
                            CustomerId = (int)row["CustomerId"],
                            FirstName = (string)row["FirstName"],
                            LastName = (string)row["LastName"],
                            Company = row["Company"] != DBNull.Value ? (string)row["Company"] : null,
                            Address = row["Address"] != DBNull.Value ? (string)row["Address"] : null,
                            City = row["City"] != DBNull.Value ? (string)row["City"] : null,
                            State = row["State"] != DBNull.Value ? (string)row["State"] : null,
                            Country = row["COuntry"] != DBNull.Value ? (string)row["Country"] : null,
                            PostalCode = row["PostalCode"] != DBNull.Value ? (string)row["PostalCode"] : null,
                            Phone = row["Phone"] != DBNull.Value ? (string)row["Phone"] : null,
                            Fax = row["Fax"] != DBNull.Value ? (string)row["Fax"] : null,
                            Email = (string)row["Email"],
                            SupportRepId = row["SupportRepId"] != DBNull.Value ? (int)row["SupportRepId"] : null
                        };

            lista.Customers = query.ToList();
            lista.CustomerColumn = NameColumn(tabla);
            return View(lista);
        }
        public IActionResult InvoiceLine()
        {
            Negocio custom = new Negocio();
            DataSet data = new DataSet();
            Lista lista = new Lista();
            data = custom.MostrarCust();
            DataTable tabla = data.Tables["InvoiceLine"];
            var query = from DataRow row in tabla.Rows
                        select new InvoiceLine
                        {
                            InvoiceLineId = (int)row["InvoiceLineId"],
                            InvoiceId = (int)row["InvoiceId"],
                            TrackId = (int)row["TrackId"],
                            UnitPrice = (decimal)row["UnitPrice"],
                            Quantity = (byte)row["Quantity"]
                        };
            lista.InvoiceLine = query.ToList();
            lista.ILColumn = NameColumn(tabla);
            return View(lista);
        }
        public IActionResult Invoice()
        {
            Negocio custom = new Negocio();
            DataSet data = new DataSet();
            Lista lista = new Lista();
            data = custom.MostrarCust();
            DataTable tabla = data.Tables["Invoice"];
            var query = from DataRow row in tabla.Rows
                        select new Invoice
                        {
                            InvoiceId = (int)row["InvoiceId"],
                            CustomerId = (int)row["CustomerId"],
                            InvoiceDate = (DateTime)row["InvoiceDate"],
                            Address = row["BillingAddress"] != DBNull.Value ? (string)row["BillingAddress"] : null,
                            City = row["BillingCity"] != DBNull.Value ? (string)row["BillingCity"] : null,
                            State = row["BillingState"] != DBNull.Value ? (string)row["BillingState"] : null,
                            Country = row["BillingCountry"] != DBNull.Value ? (string)row["BillingCountry"] : null,
                            PostalCode = row["BillingPostalCode"] != DBNull.Value ? (string)row["BillingPostalCode"] : null,
                            Total = (int)row["CustomerId"]
                        };
            lista.Invoice = query.ToList();
            lista.InvoiceColumn = NameColumn(tabla);
            return View(lista);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public static List<string> NameColumn(DataTable tabla)
        {            
            return tabla.Columns.Cast<DataColumn>()
                            .Select(column => column.ColumnName)
                            .ToList();
        }
    }
}