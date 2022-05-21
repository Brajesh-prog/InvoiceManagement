using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.DataModel
{
    public class Particulars
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int Item { get; set; }
        public string Particular { get; set; }

        public string HSN { get; set; }

        public string Qty { get; set; }

        public decimal Rate { get; set; }

        public decimal Amount { get; set; }
    }
}
