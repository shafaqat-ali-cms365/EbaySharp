﻿using EbaySharp.Entities.Common;

namespace EbaySharp.Entities.Sell.Inventory.Offer
{
    public class EconomicOperator: Address
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
