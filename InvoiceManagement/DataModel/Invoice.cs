using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.DataModel
{
    public class Invoice
    {
        public int Id { get; set; }

        public int SupplierId { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public decimal SGST { get; set; }

        public decimal CGST { get; set; }

        public decimal netAmount { get; set; }

        public string amountInWord { get; set; }
    }
}
