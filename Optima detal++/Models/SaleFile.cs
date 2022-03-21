using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optima_detal__.Models
{
    public class SaleFile
    {
        public string codeItem { get; set; }
        public string salePriceBrutto { get; set; }
        public string oldPriceBrutto { get; set; }
        public string typePrice { get; set; }
        public DateTime saleFrom { get; set; }
        public DateTime saleTo { get; set; }
    }
}
