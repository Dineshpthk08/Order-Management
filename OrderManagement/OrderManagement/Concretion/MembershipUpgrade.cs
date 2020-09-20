using OrderManagement.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Concretion
{
    public class MembershipUpgrade : IMembershipUpgrade
    {
        public string EmailOwner(bool emailOwner)
        {
            if (emailOwner)
            {
                return "Email sent to Owner";
            }
            else
            {
                return "Email failed to sent to Onwer";
            }
        }

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
