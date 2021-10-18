using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul4
{
    class Produs
    {
        private int saleNo;
        private string customer;
        private string remarks;
        private string find;
        private string salekey;
        private int ledgerNo;
        private string ledgerKey;
        private string stockLedgerKey;
        private string product;
        private int itemQty;
        private int amount;
        private DateTime date;

        public Produs(int saleNo, string customer, string remarks, string find,
            string salekey, int ledgerNo, string ledgerKey, string stockLedgerKey,
            string product, int itemQty, int amount, DateTime date)
        {
            this.saleNo = saleNo;
            this.customer = customer;
            this.remarks = remarks;
            this.find = find;
            this.salekey = salekey;
            this.ledgerNo = ledgerNo;
            this.ledgerKey = ledgerKey;
            this.stockLedgerKey = stockLedgerKey;
            this.product = product;
            this.itemQty = itemQty;
            this.amount = amount;
            this.date = date;
        }


        public string toString()
        {
            return saleNo + ", " + customer + ", " + remarks
                + ", " + find + ", " + salekey + ", " + ledgerNo
                + ", " + ledgerKey + ", " + stockLedgerKey + ", " + product
                + ", " + itemQty + ", " + amount + ", " + date.ToString();
        }
    }
}
