using OrderManagement.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Concretion
{
    public class MembershipUpgrade : IMembershipUpgrade
    {
        public string UpgradeMembership(bool upgradeMembership)
        {
            if (upgradeMembership)
            {
                return "Upgrade applied";
            } else
            {
                return "Upgrade failed due to an error";
            }
        }
    }
}
