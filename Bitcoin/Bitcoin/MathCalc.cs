using System;
using System.Collections.Generic;
using System.Text;

namespace Bitcoin
{
    public class MathCalc
    {
        private decimal BTCexchangeRate;
        private decimal GBPexchangeRate;
        private decimal USDexchangeRate;
        private decimal EUR = (decimal) 1.00;
        private decimal GBP;
        private decimal USD;
        private decimal currentCurrency, currentExchange;

        private int currencyDecs = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalDigits;

        public async void SaveCurrencyData()
        {
            var currencyInfo = await CurrencyProcessor.LoadCurrency();
            BTCexchangeRate = currencyInfo.Btc;
            GBPexchangeRate = currencyInfo.Gbp;
            USDexchangeRate = currencyInfo.Usd;

            setCurrencyParameters();
        }

        private void setCurrencyParameters()
        {
            GBP = EUR / GBPexchangeRate;
            USD = EUR / USDexchangeRate;
        }

        public decimal CurrentBTCprice()
        {
            return Math.Round((EUR / BTCexchangeRate)* currentExchange, currencyDecs, MidpointRounding.AwayFromZero);
        }

        public decimal AmountInvested()
        {
            decimal amountInv = 0;
            List<InsertInfo> list = Storage<InsertInfo>.getList();
            foreach (InsertInfo n in list)
            {
                amountInv += n.AmountBought;
            }
            return Math.Round(amountInv * currentExchange, currencyDecs, MidpointRounding.AwayFromZero);
        }
        public decimal PortfolioValue()
        {
            return AmountInvested() + GetReturnOnInv();
        }
        public decimal FeesPaid()
        {
            decimal feesPaid = 0;
            List<InsertInfo> list = Storage<InsertInfo>.getList();
            foreach (InsertInfo n in list)
            {
                feesPaid += n.FeePaid;
            }
            return feesPaid;
        }

        public void ChangeCurrentCurrency(string curr)
        {
            if (curr == "USD")
            {
                currentCurrency = USD;
                currentExchange = USDexchangeRate;
            }
            else if (curr == "GBP")
            {
                currentCurrency = GBP;
                currentExchange = GBPexchangeRate;
            }
            else
            {
                currentCurrency = EUR;
                currentExchange = (decimal)1.00;
            }
        }

        public decimal GetReturnOnInv()
        {
            decimal result = 0;
            decimal currBTC = Math.Round((EUR / BTCexchangeRate), currencyDecs, MidpointRounding.AwayFromZero); ;
            List<InsertInfo> list = Storage<InsertInfo>.getList();
            foreach (InsertInfo n in list)
            {
                decimal tempPer = ((currBTC * 100) / n.PricePerCoin) - 100;
                result += ((n.AmountBought * tempPer) / 100);
            }
            return Math.Round(result* currentExchange, currencyDecs, MidpointRounding.AwayFromZero);
        }
        public decimal GetReturnOnInvPerc()
        {
            decimal result;
            result = (GetReturnOnInv() / AmountInvested()) * 100;
            return Math.Round(result, currencyDecs, MidpointRounding.AwayFromZero);
        }
    }
}
