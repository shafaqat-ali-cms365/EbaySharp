﻿namespace EbaySharp.Entities.Sell.Inventory.Offer
{
    public class Tax
    {
        public bool ApplyTax { get; set; }
        public string ThirdPartyTaxCategory { get; set; }
        public float VatPercentage { get; set; }
    }
}