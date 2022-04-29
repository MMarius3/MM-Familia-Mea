using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familia_2._0.Models
{
    public class Subscription
    {
        public int ID { get; set; }

        // user ID from AspNetUser table.
        public string OwnerID { get; set; }
        public SubscriptionType Type { get; set; }
        public CashOrCard Payment { get; set; }
        public string Address { get; set; }
    }

    public enum SubscriptionType
    {
        one,
        six,
        twelve
    }
    public enum CashOrCard
    {
        cash,
        card
    }
}