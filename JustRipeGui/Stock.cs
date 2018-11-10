using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeGui
{
    public class Stock
    {
        private int type;
        private int quantity;
        private int supplierId;
        private DateTime purchaseDate;
        private DateTime expiryDate;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }




    }
}
