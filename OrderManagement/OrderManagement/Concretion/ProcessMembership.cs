using OrderManagement.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Concretion
{
    class ProcessMembership : IProcessMembership
    {
        public string ActivateMembership(bool activateMembership)
        {
            if (activateMembership)
            {
                return "Membership activated";
            }
            else
            {
                return "Membership activation failed due to an error";
            }
        }
    }
}
