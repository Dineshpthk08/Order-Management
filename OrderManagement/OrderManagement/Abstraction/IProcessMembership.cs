using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Abstraction
{
    public interface IProcessMembership
    {
        string ActivateMembership(bool activateMembership);
        string EmailOwner(bool emailOwner);
    }
}
