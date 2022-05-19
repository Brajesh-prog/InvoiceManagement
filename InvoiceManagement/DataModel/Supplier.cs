using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.DataModel
{
    public class Supplier
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string GSTIN { get; set; }

        public string SupplySite { get; set; }

        
    }
}
