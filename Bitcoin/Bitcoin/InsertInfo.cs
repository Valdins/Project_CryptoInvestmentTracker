using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Bitcoin
{
    [Serializable()]
    public class InsertInfo : IComparable, ISerializable
    {
        private int id;
        private string purchaseDate;
        private decimal amountBought;
        private decimal feePaid;
        private decimal pricePerCoin;

        public InsertInfo() { }
        public InsertInfo(int id)
        {
            this.id = id;
        }
        public InsertInfo(string purchaseDate, decimal amountBought, decimal feePaid, decimal pricePerCoin)
        {
            this.id = CreateID();
            this.purchaseDate = purchaseDate;
            this.amountBought = amountBought;
            this.feePaid = feePaid;
            this.pricePerCoin = pricePerCoin;
        }

        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string PurchaseDate
        {
            set { purchaseDate = value; }
            get { return purchaseDate; }
        }
        public decimal AmountBought
        {
            set { amountBought = value; }
            get { return amountBought; }
        }
        public decimal FeePaid
        {
            set { feePaid = value; }
            get { return feePaid; }
        }
        public decimal PricePerCoin
        {
            set { pricePerCoin = value; }
            get { return pricePerCoin; }
        }

        public int CreateID()
        {
            int id, highest = 0;
            List<InsertInfo> list = Storage<InsertInfo>.getList();
            if (list.Count == 0)
                id = 1;
            else
            {
                foreach (InsertInfo n in list)
                {
                    if (n.id > highest)
                        highest = n.id;
                }
                id = highest + 1;
            }
            return id;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", id);
            info.AddValue("Date", purchaseDate);
            info.AddValue("AmountBought", amountBought);
            info.AddValue("Fee", feePaid);
            info.AddValue("PricePerCoin", pricePerCoin);
        }

        public InsertInfo(SerializationInfo info, StreamingContext context)
        {
            id = (int)info.GetValue("ID", typeof(int));
            purchaseDate = (string)info.GetValue("Date",typeof(string));
            amountBought = (decimal)info.GetValue("AmountBought", typeof(decimal));
            feePaid = (decimal)info.GetValue("Fee", typeof(decimal));
            pricePerCoin = (decimal)info.GetValue("PricePerCoin", typeof(decimal));
        }
        public int CompareTo(Object other)
        {
            InsertInfo info = (InsertInfo)other;
            return this.id.CompareTo(info.id);
        }
    }
}
