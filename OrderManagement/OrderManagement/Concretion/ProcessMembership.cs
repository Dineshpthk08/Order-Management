using OrderManagement.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Concretion
{
    public class ProcessMembership : IProcessMembership
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
    }
}
